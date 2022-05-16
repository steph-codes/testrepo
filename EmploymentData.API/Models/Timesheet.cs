using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class Timesheet
    {
        public int TimesheetId { get; set; }
        public DateTime? TimeSheetDate { get; set; }
        public int? TaskId { get; set; }
        public string? ActivityDesc { get; set; }
        public byte? Status { get; set; }
        public DateTime? HoursWorked { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual TaskType? Task { get; set; }
        public virtual User? User { get; set; }
    }
}
