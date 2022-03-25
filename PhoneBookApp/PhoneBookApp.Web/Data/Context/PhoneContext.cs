using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Web.Data.Configurations;
using PhoneBookApp.Web.Data.Entities;

namespace PhoneBookApp.Web.Data.Context
{
    public class PhoneContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Information> Informations { get; set; }

        public PhoneContext(DbContextOptions<PhoneContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new InformationConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
