//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd_API
{
    using System;
    
    public partial class LogSelect_Result
    {
        public int ID { get; set; }
        public string Details { get; set; }
        public Nullable<int> Action { get; set; }
        public Nullable<int> RelatedID { get; set; }
        public Nullable<int> StaffID { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> Type { get; set; }
        public string StaffName { get; set; }
        public string ActionView { get; set; }
        public string TypeView { get; set; }
        public Nullable<int> TotalRows { get; set; }
    }
}
