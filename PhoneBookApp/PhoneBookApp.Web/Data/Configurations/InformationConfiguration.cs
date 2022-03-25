using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBookApp.Web.Data.Entities;

namespace PhoneBookApp.Web.Data.Configurations
{
    public class InformationConfiguration : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.Property(x => x.MobileNumber).HasMaxLength(30);
            builder.Property(x => x.MobileNumber).IsRequired();
            builder.Property(x => x.HomePhone).HasMaxLength(30);
            builder.Property(x => x.HomePhone).IsRequired();
            builder.Property(x => x.OfficePhone).HasMaxLength(30);
            builder.Property(x => x.OfficePhone).IsRequired();
            builder.Property(x => x.Mail).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Adress).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(x => x.Adress).IsRequired();

            
            
        }
    }
}
