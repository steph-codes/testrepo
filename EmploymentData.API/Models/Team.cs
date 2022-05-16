using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class Team
    {
        public Team()
        {
            ProductTeams = new HashSet<ProductTeam>();
            Products = new HashSet<Product>();
            TaskTypes = new HashSet<TaskType>();
            TeamMembers = new HashSet<TeamMember>();
        }

        public int TeamId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<ProductTeam> ProductTeams { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<TaskType> TaskTypes { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
    }
}
