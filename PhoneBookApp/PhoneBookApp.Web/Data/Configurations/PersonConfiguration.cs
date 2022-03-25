using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Web.Data.Entities;

namespace PhoneBookApp.Web.Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.PersonsFullName).HasColumnType("varchar").HasMaxLength(200);

            builder.Property(x => x.PersonsFullName).IsRequired();

            builder.HasMany(x=>x.Informations).WithOne(x=>x.Person).HasForeignKey(x=>x.PersonsID);
        }
    }
}
