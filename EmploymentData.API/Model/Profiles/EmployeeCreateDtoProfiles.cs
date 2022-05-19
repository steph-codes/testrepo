using AutoMapper;
using EmploymentData.API.Dto;
using EmploymentData.API.Model.Data;
using EmploymentData.API.Models;

namespace EmploymentData.API.Model.Profiles
{
    public class EmployeeCreateDtoProfiles : Profile
    {
        public EmployeeCreateDtoProfiles()
        {
            //Source => Destination
            
            CreateMap<EmployeeCreateDto, Employee>();
            //expression.ForMember(property.Name, opt => opt.Ignore());
            //CreateMap<Source, Destination>()
            //.ForSourceMember(src => src.ReadOnlyProperty, opt => opt.Ignore())
        }
    }
}
