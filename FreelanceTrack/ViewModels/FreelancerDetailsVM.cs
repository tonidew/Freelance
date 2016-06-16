using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreelanceTrack.ViewModels
{
    public class FreelancerDetailsVM
    {
        public int FreelancerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AssignmentName { get; set; }
        public string Description { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool Completed { get; set; }
        public string URL { get; set; }
        public int AssignmentId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime DatePaid { get; set; }
        public float AmountPaid { get; set; }
      

    }
}