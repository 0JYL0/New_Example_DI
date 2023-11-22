using Ex_BAL.Interface;
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
            var obj = _employeeBL.GetEmployees();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}