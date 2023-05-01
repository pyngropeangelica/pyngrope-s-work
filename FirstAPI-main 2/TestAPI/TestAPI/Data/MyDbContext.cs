using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class MyDbContext:DbContext
    {
        //public MyDbContext()
        //{
        //    Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=ServerName;Database=Dbname;Trusted_Connection=True;");
        }

        public DbSet<Event> Events { get; set; }
    }
}
