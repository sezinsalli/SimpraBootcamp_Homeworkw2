using Simpra_Homework_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpra_Homework_Core.Repositories
{
    public interface IStaffRepository
    {        
        Task<List<Staff>> GetStaffWithCityAsync(string cityName);
        Task<Staff> GetStaffInfoAsync(int id);
    }
}
