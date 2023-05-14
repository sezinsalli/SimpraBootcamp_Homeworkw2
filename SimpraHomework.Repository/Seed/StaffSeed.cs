using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Simpra_Homework_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Repository.Seed
{
    internal class StaffSeed : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff {Id=1,FirstName="Sezin",LastName="Şallı",Email="sezinsalli1@gmail.com",Phone="05383187542",DateOfBirth = new DateTime(1990, 6, 15),AddressLine1="Test",City="Test",Country="Test",Province="Test",CreatedAt= new DateTime(2023, 1, 15),CreatedBy="Sezin salli" },
                new Staff {Id=2,FirstName="Fatih",LastName="Şallı",Email="fatihsalli1@gmail.com",Phone="05384568541",DateOfBirth = new DateTime(1990, 12, 15),AddressLine1="Test",City="Test",Country="Test",Province="Test",CreatedAt= new DateTime(2023, 1, 15),CreatedBy="Fatih salli" }
               
                );
        }
    }
}
