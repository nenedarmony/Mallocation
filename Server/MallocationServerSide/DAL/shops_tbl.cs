//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class shops_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shops_tbl()
        {
            this.categorys_in_shop = new HashSet<categorys_in_shop>();
            this.custumer_historys_tbl = new HashSet<custumer_historys_tbl>();
            this.shopsInMall_tbl = new HashSet<shopsInMall_tbl>();
        }
    
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public int IdFromAudience { get; set; }
    
        public virtual audiences_tbl audiences_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<categorys_in_shop> categorys_in_shop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<custumer_historys_tbl> custumer_historys_tbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shopsInMall_tbl> shopsInMall_tbl { get; set; }
    }
}