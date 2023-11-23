using System;
using System.Collections.Generic;

namespace Ex_DL
{
    public partial class EmployeeMapping
    {
        public int Id { get; set; }
        public int ManagerId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Employee Manager { get; set; } = null!;
    }
}
