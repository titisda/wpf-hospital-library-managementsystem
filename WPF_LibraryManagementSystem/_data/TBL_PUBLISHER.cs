//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_LibraryManagementSystem._data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PUBLISHER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_PUBLISHER()
        {
            this.TBL_BOOK = new HashSet<TBL_BOOK>();
        }
    
        public int ID { get; set; }
        public string PUBLISHER { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BOOK> TBL_BOOK { get; set; }
    }
}