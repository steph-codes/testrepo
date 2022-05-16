using AutoMapper;
using EmploymentData.API.Dto;
using EmploymentData.API.Models;

namespace EmploymentData.API.Model.Profiles
{
    public class EmployeeCreateDtoProfiles : Profile
    {
        public EmployeeCreateDtoProfiles()
        {
            //Source => Destination
            CreateMap<EmployeeCreateDto, Employee>();
        }
    }
}
