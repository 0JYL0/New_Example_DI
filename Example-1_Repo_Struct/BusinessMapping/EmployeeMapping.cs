using Ex_BAL.Interface;
using Ex_DL;
using Example_1_Repo_Struct.Models;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace Example_1_Repo_Struct.BusinessMapping
{
    public class EmployeeMapping
    {
        private readonly IEmployeeBL _employeeBL;
        public EmployeeMapping(IEmployeeBL employeeBL)
        {
            _employeeBL = employeeBL;
        }

        public EmployeeModel GetEmployees()
        {
            var employees = new EmployeeModel();

            var oList = _employeeBL.GetEmployees();

            if (oList != null)
            {
                foreach (var item in oList)
                {
                    var obj = new EmployeeM()
                    {
                        EmployeeName = item.EmployeeName,
                        EmployeeAddress = item.EmployeeAddress,
                        Department = item.Department,
                        EmployeeEmail = item.EmployeeEmail,
                        EmployeeId = item.EmployeeId,
                        EmployeeExperience = item.EmployeeExperience,
                        EmployeeStatus = item.EmployeeStatus,
                        EmployeeJoiningDate = item.EmployeeJoiningDate,
                        Role = item.Role,
                    };

                    employees.EmployeesDetails.Add(obj);
                }
            }

            List<ProjectModel> projectList = GetProjects();

            employees.ProjectDetails = projectList;


            return employees;
        }

        public List<ProjectModel> GetProjects()
        {
            var projects = new List<ProjectModel>();

            var Olist = _employeeBL.GetProjects();

            if (Olist != null)
            {
                foreach (var item in Olist)
                {
                    var obj = new ProjectModel()
                    {
                        ProjectId = item.ProjectId,
                        ProjectName = item.ProjectName,
                        ProjectDescription = item.ProjectDescription,
                        EndDate = item.EndDate,
                        ProjectTech = item.ProjectTech,
                        StartDate = item.StartDate,
                    };

                    projects.Add(obj);
                }
            }
            return projects;
        }

        public void InsertEmployee(EmployeeM employeeM)
        {
            var emp = new Employee()
            {
                EmployeeName = employeeM.EmployeeName,
                EmployeeId = employeeM.EmployeeId,
                EmployeeStatus = employeeM.EmployeeStatus,
                EmployeeAddress = employeeM.EmployeeAddress,
                EmployeeEmail = employeeM.EmployeeEmail
            };
            _employeeBL.Insert(emp);
        }
    }
}
