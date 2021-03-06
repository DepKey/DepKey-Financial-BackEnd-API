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
    
    public partial class Journal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Journal()
        {
            this.JournalMovements = new HashSet<JournalMovement>();
            this.JournalMovementHistories = new HashSet<JournalMovementHistory>();
        }
    
        public int ID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public int JournalNumber { get; set; }
        public Nullable<System.DateTime> JournalDate { get; set; }
        public int JournalTypeID { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<int> StaffID { get; set; }
        public Nullable<int> SalesID { get; set; }
        public Nullable<int> SalesStatusID { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual Lookup Lookup1 { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalMovement> JournalMovements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalMovementHistory> JournalMovementHistories { get; set; }
    }
}
