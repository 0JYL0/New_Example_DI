using System;
using System.Collections.Generic;

namespace Ex_DL
{
    public partial class ProjectMember
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime JoiningDate { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
    }
}
