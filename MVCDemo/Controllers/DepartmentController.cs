using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContex = new EmployeeContext();
            List<Department> departments = employeeContex.Departments.ToList();
            return View(departments);
        }

    }
}
