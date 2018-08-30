using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_API.Models.SearchParams
{
    public class NotificationParams
    {
        public int? ID { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsSeen { get; set; }
        public DateTime CreationDate { get; set; }
        public int? RelatedID { get; set; }

    }
}