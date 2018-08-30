using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackEnd_API.Models.SearchParams
{
    public class LookupParams
    {
        public int? ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool? IsDeleted { get; set; }
        public int? LookupTypeID { get; set; }
        public int? LookupOrder { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}