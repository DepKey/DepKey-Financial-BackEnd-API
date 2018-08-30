using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackEnd_API.Models.SearchParams
{
    public class LogParams
    {
        public int? ID { get; set; }
        public string Details { get; set; }
        public int? Action { get; set; }
        public int? RelatedID { get; set; }
        public int? StaffID { get; set; }
        public int? Type { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string TicketNumber { get; set; }
        public string ActionSearch { get; set; }
        public string TypeSearch { get; set; }
    }
}