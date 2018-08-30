using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_API.Models.SearchParams
{
    public class OutstandingParams
    {
        public int? ID { get; set; }
        public int? OsNumber { get; set; }
        public DateTime? OsDate { get; set; }
        public float? Amount { get; set; }
        public int? StatusID { get; set; }
        public int? JournalMovementID { get; set; }
        public int? AccountID { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

    }
}