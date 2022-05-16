using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class TaskType
    {
        public TaskType()
        {
            Timesheets = new HashSet<Timesheet>();
        }

        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskDescription { get; set; }
        public int? ProductId { get; set; }
        public string? CreatedBy { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? AssignedTo { get; set; }
        public int? TeamId { get; set; }

        public virtual Team? Team { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Timesheet> Timesheets { get; set; }
    }
}
