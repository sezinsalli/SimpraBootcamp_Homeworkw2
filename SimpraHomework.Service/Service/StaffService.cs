using AutoMapper;
using Simpra_Homework_Core.Entity;
using Simpra_Homework_Core.Repositories;
using Simpra_Homework_Core.RequestResponseModel;
using Simpra_Homework_Core.RequestResponseModel.Staff;
using Simpra_Homework_Core.Services.StaffService;
using Simpra_Homework_Core.UnitofWorks;
using SimpraHomework.Repository.UnitofWork;

namespace SimpraHomework.Service.Service
{
    public class StaffService : Service<Staff>, IStaffService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IMapper _mapper;
        public StaffService(IGenericRepository<Staff> repository, IUnitofWork unitofWork, IMapper mapper, IStaffRepository staffRepository) : base(repository, unitofWork)
        {
            _mapper = mapper;
            _staffRepository = staffRepository;
        }

        public async Task<CustomResponse<StaffResponse>> GetStaffInfoAsync(int id)
        {
            var staff = await _staffRepository.GetStaffInfoAsync(id);

            if (staff == null)
            {
                return CustomResponse<StaffResponse>.Fail(404, "Staff not found");
            }

            var staffResponse = _mapper.Map<StaffResponse>(staff);
            return CustomResponse<StaffResponse>.Success(200, staffResponse);


        }

        public async Task<CustomResponse<List<StaffResponse>>> GetStaffWithCityAsync(string cityName)
        {
            var staffList = await _staffRepository.GetStaffWithCityAsync(cityName);
            var staffResponseList = _mapper.Map<List<StaffResponse>>(staffList);
            return CustomResponse<List<StaffResponse>>.Success(200, staffResponseList);
        }
    }
}
