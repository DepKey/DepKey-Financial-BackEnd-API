using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_API.Models.SearchParams
{
    public class BranchParams
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}