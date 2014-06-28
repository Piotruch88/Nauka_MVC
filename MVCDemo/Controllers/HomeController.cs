using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Company company = new Company();
            return View(company);
        }

        [HttpPost]
        public string Index(Company company)
        {
            if (string.IsNullOrEmpty(company.SelectedDepartment))
            {
                return "Nie wybrałeś żadnego department";
            }
            else
            {
                return "Wybrałeś department z Id = " + company.SelectedDepartment;
            }
        }  
    }
}
