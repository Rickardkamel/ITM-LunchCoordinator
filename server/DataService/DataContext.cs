using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Models;

namespace DataService
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ITMLunchDB") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Lunch> Lunches { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
