//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERPDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class StorageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StorageType()
        {
            this.PurchaseItems = new HashSet<PurchaseItem>();
            this.Storages = new HashSet<Storage>();
        }
    
        public int StorageTypeId { get; set; }
        public string StorageTypen { get; set; }
        public Nullable<int> FarePerMinute { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
