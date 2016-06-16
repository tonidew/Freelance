using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreelanceTrack.Models
{
    public class Freelancer
    {
        public int FreelancerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}