using System.Data.Entity;

namespace ExploreDhaka.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("ExploreDhaka")
        {

        }

        public DbSet<Tour> Tours { get; set; }
    }
}
