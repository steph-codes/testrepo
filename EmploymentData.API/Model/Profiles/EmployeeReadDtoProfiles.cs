using AutoMapper;
using EmploymentData.API.Model.Data;
using EmploymentData.API.Models;
using EmploymentData.Dto;

namespace EmploymentData.API.Model.Profiles
{
    public class EmployeeReadDtoProfiles : Profile
    {
        public EmployeeReadDtoProfiles()
        {
            // Source -> Destination
            //maps Models => Dto
            CreateMap<Employee, ReadEmploymentDto>();
              //  .ForMember(x => x.CompanyId, opt => opt.Ignore());
            
            //Mapper.CreateMap<Employee, EmployeeReadDtoProfiles>().IgnoreAllVirtual();
        }
    }
}
