using System;
using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models
{
    public class Event
    {
        [Key]
        public int uid { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public DateTime schedule { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public int rigor_rank { get; set; }
        public string moderator { get; set; }
        public string category { get; set; }
        public string sub_category { get; set; }
    }
}
