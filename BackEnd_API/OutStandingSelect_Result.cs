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
    
    public partial class OutStandingSelect_Result
    {
        public int ID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public string MovementDescription { get; set; }
        public int JournalID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> JournalMovementID { get; set; }
    }
}