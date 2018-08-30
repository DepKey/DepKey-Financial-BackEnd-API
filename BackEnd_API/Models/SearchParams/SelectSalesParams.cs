using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_API.Models.SearchParams
{
    public class SalesParams
    {
        public int? ID { get; set; }
        public string PaxName { get; set; }
        public string PNR { get; set; }
        public int? DKNumber { get; set; }
        public int? AirlineID { get; set; }
        public int? CreatedStaffID { get; set; }
        public int? SalesTypeID { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool? IsDeleted { get; set; }
        public int? SalesStatusID { get; set; }
        public int? InvoiceNumber { get; set; }
        public string TicketNumber { get; set; }
        public bool? RefPaid { get; set; }
        public int? BranchID { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public int? NotSalesStatusID { get; set; }
        public int? InvoiceNumberPNR { get; set; }
    }
}