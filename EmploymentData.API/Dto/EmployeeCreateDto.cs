using EmploymentData.API.Models;

namespace EmploymentData.API.Dto
{
    public class EmployeeCreateDto
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Company? Company { get; set; }
        public virtual User? User { get; set; }
    }
}
