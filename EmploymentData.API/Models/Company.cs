using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
            Products = new HashSet<Product>();
        }

        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyLink { get; set; }
        public int? EmpId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Username { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
