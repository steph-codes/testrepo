using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class Permission
    {
        public Permission()
        {
            TeamMembers = new HashSet<TeamMember>();
        }

        public int PermissionId { get; set; }
        public string? PermissionType { get; set; }
        public short? PermissionLevel { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<TeamMember> TeamMembers { get; set; }
    }
}
