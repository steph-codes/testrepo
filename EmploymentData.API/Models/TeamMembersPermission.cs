using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class TeamMembersPermission
    {
        public int TmPermissionId { get; set; }
        public string? Description { get; set; }
        public int? MemberId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual TeamMember? Member { get; set; }
    }
}
