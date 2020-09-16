using Microsoft.EntityFrameworkCore;

namespace DemoApp.Models
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options)
        {

        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Depot> Depots { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }

}
    

