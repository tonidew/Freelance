using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreelanceTrack.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime DatePaid { get; set; }
        public float AmountPaid {get; set;}
        public int AssignmentId { get; set; }

    }
}