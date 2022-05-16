

using EmploymentData.API.Models;

namespace EmploymentData.Dto
{
    public class ReadEmploymentDto
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public DateTime CreatedAt { get; set; }

    }
 
}
