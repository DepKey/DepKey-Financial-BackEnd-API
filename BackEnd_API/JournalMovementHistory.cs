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
    using System.Collections.Generic;
    
    public partial class JournalMovementHistory
    {
        public int ID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<double> Debit { get; set; }
        public Nullable<double> Credit { get; set; }
        public string MovementDescription { get; set; }
        public string RejectionReason { get; set; }
        public int JournalID { get; set; }
        public Nullable<int> JournalMovementID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> ApprovalStatusID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Journal Journal { get; set; }
        public virtual JournalMovement JournalMovement { get; set; }
        public virtual Lookup Lookup { get; set; }
    }
}
