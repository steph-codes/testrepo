using System;
using System.Collections.Generic;

namespace EmploymentData.API.Models
{
    public partial class ProductTeam
    {
        public int ProductTeamId { get; set; }
        public int? TeamId { get; set; }
        public int? ProductId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Team? Team { get; set; }
    }
}
