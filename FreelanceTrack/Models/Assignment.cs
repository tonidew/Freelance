using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreelanceTrack.Models
{
    public class Assignment
    {
        public string AssignmentName { get; set; }
        public string Description { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool Completed { get; set; }
        public string URL { get; set; }
        public int AssignmentId { get; set; }
        public int FreelancerId { get; set; }
        
    }
}