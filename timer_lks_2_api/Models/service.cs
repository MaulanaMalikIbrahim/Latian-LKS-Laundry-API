//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace timer_lks_2_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            this.detail_package = new HashSet<detail_package>();
            this.detail_transaction = new HashSet<detail_transaction>();
        }
    
        public Nullable<int> id_category { get; set; }
        public Nullable<int> id_unit { get; set; }
        public int id_service { get; set; }
        public string name_service { get; set; }
        public Nullable<int> price_unit_service { get; set; }
        public Nullable<int> estimation_duration_service { get; set; }
    
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail_package> detail_package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail_transaction> detail_transaction { get; set; }
        public virtual unit unit { get; set; }
    }
}