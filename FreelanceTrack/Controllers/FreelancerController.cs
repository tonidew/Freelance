using FreelanceTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreelanceTrack.Controllers
{
    public class FreelancerController : Controller
    {
        // GET: Freelancer
        public ActionResult Index()
        {
            FreelancersDatabaseContext _myFreelancers = new FreelancersDatabaseContext();
            return View();
        }
    }
}

----


        

            //LINQ to bring in Department Table
            var FreelancerDetails = (from freelancer in _myFreelancers.LastName
                                   join dept in _myEmployeeContext.Department
                                   on emp.DepartmentId equals dept.DepartmentId
                                   orderby dept.DepartmentName
                                   select new EmployeeDetailsViewModel
                                   {
                                       Name = emp.Name,
                                       DepartmentName = dept.DepartmentName
                                   }).ToList();


            EmployeeDepartmentDetailsViewModel employeeDepartmentDetails = new EmployeeDepartmentDetailsViewModel
            {
                Employees = employeeDetails
            };
            return View(employeeDepartmentDetails);
        }
    }
}
