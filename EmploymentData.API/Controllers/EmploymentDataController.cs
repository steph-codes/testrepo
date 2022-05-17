using AutoMapper;
using EmploymentData.API.Dto;
using EmploymentData.API.Model;
using EmploymentData.API.Models;
using EmploymentData.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentDataController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmploymentDataController(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        // GET: api/<EmployeeController>
        [HttpGet] 
        public ActionResult<IEnumerable<ReadEmploymentDto>> Get()
        {
            var employees = _employeeRepository.GetAll();

            var employeeDto = _mapper.Map<IEnumerable<ReadEmploymentDto>>(employees);

            if (employees == null)
            {
                return NotFound();
            }
            //return employees;
            return Ok(employeeDto);

        }

        [HttpGet("{id}", Name = "GetEmployeeById")]
        public ActionResult<ReadEmploymentDto> GetEmployeeById(int id)
        {
            var employee = _employeeRepository.Get(id);
            if (employee == null)
            {
                return NotFound(id);
            }
            return (_mapper.Map<ReadEmploymentDto>(employee));
        }

        [HttpPost]
        public ActionResult<ReadEmploymentDto> CreateEmployee(
            EmployeeCreateDto employeeCreateDto)
        {

            //Mapping to Persist to Data
            var employeeModel = _mapper.Map<Employee>(employeeCreateDto);

            _employeeRepository.Create(employeeModel);
            _employeeRepository.SaveChanges();

            //Mapp from Employee to its Dtod
            var employeeReadDto = _mapper.Map<ReadEmploymentDto>(employeeModel);

            return CreatedAtRoute(nameof(GetEmployeeById),
                new { Id = employeeReadDto.EmpId }, employeeReadDto);
        }
    }
}
