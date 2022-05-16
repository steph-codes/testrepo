namespace EmploymentData.API.Dto
{
    public class EmployeeCreateDto
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
