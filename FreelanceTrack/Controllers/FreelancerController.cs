using FreelanceTrack.Models;
using FreelanceTrack.ViewModels;
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

            var freelancerDetails = (from freelancer in _myFreelancers.Freelancer
                                     join assignment in _myFreelancers.Assignment
                                     on freelancer.FreelancerId equals assignment.FreelancerId
                                     orderby assignment.AssignmentName
                                     select new FreelancerDetailsVM
                                     {
                                         FirstName = freelancer.FirstName,
                                         LastName = freelancer.LastName,
                                         State = freelancer.State,
                                         Address = freelancer.Address,
                                         Phone = freelancer.Phone,
                                         Email = freelancer.Email,
                                         AssignmentName = assignment.AssignmentName,
                                         Description = assignment.Description,
                                         DateAssigned = assignment.DateAssigned,
                                         DateDue = assignment.DateDue,
                                         PublicationDate = assignment.PublicationDate,
                                         Completed = assignment.Completed,
                                         URL = assignment.URL
                                     }).ToList();

            FreelancerDetailsVM freelancersDetails = new FreelancerDetailsVM
            {
                Freelancers = freelancerDetails
            };
            return View(freelancerDetails);

        }
    }
}







            