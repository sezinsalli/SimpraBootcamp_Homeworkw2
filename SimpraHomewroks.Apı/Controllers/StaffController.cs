using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simpra_Homework_Core.Entity;
using Simpra_Homework_Core.RequestResponseModel;
using Simpra_Homework_Core.RequestResponseModel.Staff;
using Simpra_Homework_Core.Services;
using Simpra_Homework_Core.Services.StaffService;
using SimpraHomework.Service.Service;

namespace SimpraHomewroks.Apı.Controllers
{
    
    public class StaffController : CustomBaseController
    {
        private readonly IMapper _mapper;        
        private readonly IStaffService staffService;
        public StaffController(IMapper mapper,IStaffService staffService)
        {
            _mapper = mapper;
            this.staffService= staffService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetStaff(int id)
        {
            return CreateActionResult(await staffService.GetStaffInfoAsync(id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetStaffWithCity(string cityName)
        {
            return CreateActionResult(await staffService.GetStaffWithCityAsync(cityName));
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var staffs = await staffService.GetAllAsync();
            var staffResponse = _mapper.Map<List<StaffResponse>>(staffs.ToList());

            return Ok(CustomResponse<List<StaffResponse>>.Success(200, staffResponse));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var staff = await staffService.GetByIdAsync(id);
            var staffResponse = _mapper.Map<StaffResponse>(staff);
            return CreateActionResult(CustomResponse<StaffResponse>.Success(200, staffResponse));
        }

        [HttpPost]
        public async Task<IActionResult> Save(StaffCreateRequest staffCreateRequest)
        {
            var staff = await staffService.AddAsync(_mapper.Map<Staff>(staffCreateRequest));
            var staffCreateRequests = _mapper.Map<StaffCreateRequest>(staff);
            return CreateActionResult(CustomResponse<StaffCreateRequest>.Success(201,staffCreateRequests));
        }

        [HttpPut]
        public async Task<IActionResult> Update(StaffUpdateRequest staffUpdateRequest)
        {
            await staffService.UpdateAsync(_mapper.Map<Staff>(staffUpdateRequest));
            
            return CreateActionResult(CustomResponse<List<NoContent>>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var staff = await staffService.GetByIdAsync(id);
            await staffService.RemoveAsync(staff);
            return CreateActionResult(CustomResponse<NoContent>.Success(204));
        }
    }
}
