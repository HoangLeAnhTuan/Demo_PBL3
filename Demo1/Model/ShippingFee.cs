//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShippingFee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShippingFee()
        {
            this.Parcels = new HashSet<Parcel>();
        }
    
        public int shippingFeeID { get; set; }
        public double locations { get; set; }
        public bool shippingMethods { get; set; }
        public string parcelID { get; set; }
        public double totalCost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parcel> Parcels { get; set; }
    }
}