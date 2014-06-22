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
        //
        // GET: /Home/

        public ActionResult Index()
        {
            SampleDBContext db = new SampleDBContext();
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            foreach (Department department in db.tblDepartments)
            {
                SelectListItem selectListItem = new SelectListItem
                {
                    Text = department.Name,
                    Value = department.Id.ToString(),
                    Selected = department.IsSelected.HasValue ? department.IsSelected.Value : false
                };
                selectListItems.Add(selectListItem);
            }

            ViewBag.Departments = selectListItems;
            return View();
        }
    }
}
