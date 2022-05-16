using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class TeamMember
    {
        public TeamMember()
        {
            TeamMembersPermissions = new HashSet<TeamMembersPermission>();
        }

        public int MemberId { get; set; }
        public int? TeamId { get; set; }
        public int? UserId { get; set; }
        public int? PermissionId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Permission? Permission { get; set; }
        public virtual Team? Team { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<TeamMembersPermission> TeamMembersPermissions { get; set; }
    }
}
