using AutoMapper;
using EmploymentData.API.Models;

namespace EmploymentData.API.Model.Profiles
{
    public class EmployeeReadDtoProfiles : Profile
    {
        public EmployeeReadDtoProfiles()
        {
            // Source -> Destination
            //maps Models => Dto
            CreateMap<Employee, EmployeeReadDtoProfiles>();
        }
    }
}
