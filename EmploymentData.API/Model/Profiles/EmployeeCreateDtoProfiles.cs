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
            //CreateMap<Source, Destination>()
            //.ForSourceMember(src => src.ReadOnlyProperty, opt => opt.Ignore())
            CreateMap<EmployeeCreateDto, Employee>().IgnoreAllVirtual();
            //expression.ForMember(property.Name, opt => opt.Ignore());
        }
    }
}
