using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ex_DL
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeMappingEmployees = new HashSet<EmployeeMapping>();
            EmployeeMappingManagers = new HashSet<EmployeeMapping>();
            ProjectMembers = new HashSet<ProjectMember>();
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? EmployeeAddress { get; set; }
        public string EmployeeEmail { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime EmployeeJoiningDate { get; set; }
        public string EmployeeExperience { get; set; } = null!;
        public int Technology { get; set; }
        public int Role { get; set; }
        public int? Department { get; set; }
        public string? EmployeeStatus { get; set; }


        public virtual ICollection<EmployeeMapping> EmployeeMappingEmployees { get; set; }
        public virtual ICollection<EmployeeMapping> EmployeeMappingManagers { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
    }
}
