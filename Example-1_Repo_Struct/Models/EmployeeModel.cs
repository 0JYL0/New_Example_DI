namespace Example_1_Repo_Struct.Models
{
    public class EmployeeModel
    {
        public List<EmployeeM> EmployeesDetails { get; set; } = new List<EmployeeM>();
        public List<ProjectModel> ProjectDetails { get; set; } = new List<ProjectModel>();
    }

    public class EmployeeM
    {
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
    }

}
