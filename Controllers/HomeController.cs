using HRApplocationAR.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplocationAR.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Repository.addEmployee(employee);
                return View("ConfirmPage", employee);
            }
            else
            {
                return View();
            }
        }
        public ViewResult AllEmployees()
        {
            return View(Repository.getAllEmployees().Where(emp => emp.IsActive == true));
        }

    }
}
