using Simpra_Homework_Core.Entity;
using Simpra_Homework_Core.RequestResponseModel.Staff;
using Simpra_Homework_Core.RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpra_Homework_Core.Services.StaffService
{
    public interface IStaffService : IService<Staff>
    {
        Task<CustomResponse<List<StaffResponse>>> GetStaffWithCityAsync(string cityName);

        Task<CustomResponse<StaffResponse>> GetStaffInfoAsync(int id);
       
    }
}
