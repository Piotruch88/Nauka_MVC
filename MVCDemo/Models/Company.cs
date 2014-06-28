using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Company
    {
        private string _name;
        public Company(string name)
        {
            this._name = name;
        }

        public List<Department> Departments
        {
            get
            {
                SampleDBContext db = new SampleDBContext();
                return db.tblDepartments.ToList();
            }
        }

        public string CompanyName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    } 
}