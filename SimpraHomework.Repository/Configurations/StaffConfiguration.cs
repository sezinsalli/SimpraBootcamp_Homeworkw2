using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simpra_Homework_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Repository.Configurations
{
    internal class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedAt).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
            builder.Property(x=>x.Email).IsRequired().HasMaxLength(50);

            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.Phone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.DateOfBirth).IsRequired().HasMaxLength(20);
            builder.Property(x => x.AddressLine1).IsRequired().HasMaxLength(100);
            builder.Property(x => x.City).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Country).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Province).IsRequired().HasMaxLength(50);
            


            builder.ToTable("Staffs");

           
        }
    }
}
