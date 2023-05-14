using AutoMapper;
using Simpra_Homework_Core.Entity;
using Simpra_Homework_Core.RequestResponseModel.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraHomework.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Staff, StaffResponse>();
            CreateMap<StaffCreateRequest, Staff>().ReverseMap();
            CreateMap<StaffUpdateRequest, Staff>().ReverseMap();

        }
    }
}
