using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class Employee
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
