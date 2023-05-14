using Microsoft.EntityFrameworkCore;
using Simpra_Homework_Core.Entity;
using Simpra_Homework_Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Repository.Repositories
{
    public class StaffRepository:GenericRepository<Staff>,IStaffRepository
    {
        public StaffRepository(AppDbContext context) : base(context)
        {
            
        }
       
        public async Task<List<Staff>> GetStaffWithCityAsync(string cityName)
        {
            
            return await _appDbContext.Staffs.Where(x => x.City == cityName).ToListAsync();
        }
        public async Task<Staff> GetStaffInfoAsync(int id)
        {
            var staffQuery = from s in _appDbContext.Staffs
                             where s.Id == id
                             select new Staff
                             {
                                 FirstName = s.FirstName,
                                 LastName = s.LastName,
                                 Email=s.Email
                             };
            var staff = await staffQuery.FirstOrDefaultAsync();
            return staff;
        }

        
    }
}
