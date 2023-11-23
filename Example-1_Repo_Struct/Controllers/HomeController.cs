using Ex_BAL.Interface;
using Example_1_Repo_Struct.BusinessMapping;
using Example_1_Repo_Struct.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Example_1_Repo_Struct.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeBL _employeeBL;

        public HomeController(ILogger<HomeController> logger, IEmployeeBL employeeBL)
        {
            _logger = logger;
            _employeeBL = employeeBL;
        }

        public IActionResult Index()
        {
            EmployeeMapping employeeMapping = new EmployeeMapping(_employeeBL);
            var obj = employeeMapping.GetEmployees();
            
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ProjectDetails()
        {
            EmployeeMapping employeeMapping = new EmployeeMapping(_employeeBL);
            var obj = employeeMapping.GetProjects();
            return PartialView("ProjectDetails",obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult InsertEmpDetails()
        {
            var obj = new EmployeeM();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertEmpDetails(EmployeeM obj)
        {
            EmployeeMapping employeeMapping = new EmployeeMapping(_employeeBL);

            employeeMapping.InsertEmployee(obj);
            return View(obj);
        }
    }
}