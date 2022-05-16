using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class User
    {
        public User()
        {
            Employees = new HashSet<Employee>();
            TaskTypes = new HashSet<TaskType>();
            TeamMembers = new HashSet<TeamMember>();
            Timesheets = new HashSet<Timesheet>();
        }

        public int UserId { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public string Password { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; } = null!;
        public string? Username { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<TaskType> TaskTypes { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
    }
}
