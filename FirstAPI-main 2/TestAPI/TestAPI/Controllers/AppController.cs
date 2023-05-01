using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestAPI.Data;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/v3/[controller]/events")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private MyDbContext context;
        public AppController(MyDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public ActionResult<Event> Event(int id)
        {
            var Event = context.Events.Find(id);
            return Event;
        }

        [HttpPost]
        public ActionResult Event(Event model)
        {
            context.Events.Add(model);
            context.SaveChanges();
            return Ok(model);
        }

        [HttpPut]
        public ActionResult Events(Event model)
        {
            context.Events.Update(model);
            context.SaveChanges();
            return Ok(model);
        }

        [HttpDelete]
        public ActionResult Events(int id)
        {
            var obj = context.Events.Find(id);
            context.Events.Remove(obj);
            context.SaveChanges();
            return Ok();
        }


    }
}
