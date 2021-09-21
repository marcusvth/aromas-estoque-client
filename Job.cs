//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AromasEstoque
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.Transactions = new HashSet<Transactions>();
        }
    
        public int JobId { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public string Specification { get; set; }
        public System.DateTime EventDate { get; set; }
        public Nullable<short> CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
    }
}