using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductTeams = new HashSet<ProductTeam>();
            Timesheets = new HashSet<Timesheet>();
        }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductDesc { get; set; }
        public int? TeamId { get; set; }
        public int? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Team? Team { get; set; }
        public virtual ICollection<ProductTeam> ProductTeams { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
    }
}
