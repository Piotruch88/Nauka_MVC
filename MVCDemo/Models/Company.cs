using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Company
    {
        public string SelectedDepartment { get; set; }
        public List<Department> Departments
        {
            get
            {
                SampleDBContext db = new SampleDBContext();
                return db.tblDepartments.ToList();
            }
        }
    }
}