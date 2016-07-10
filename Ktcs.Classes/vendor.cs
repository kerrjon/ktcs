namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("vendor")]
    public partial class vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vendor()
        {
            Locations = new HashSet<Location>();
        }

        public int vendorID { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        [StringLength(75)]
        public string address { get; set; }

        [StringLength(30)]
        public string city { get; set; }

        [StringLength(2)]
        public string state { get; set; }

        [StringLength(12)]
        public string zip { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(20)]
        public string fax { get; set; }

        [StringLength(30)]
        public string country { get; set; }

        [StringLength(255)]
        public string NegDiscount { get; set; }

        public int VendorTypeID { get; set; }

        [StringLength(75)]
        public string maplink { get; set; }

        [StringLength(255)]
        public string notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Locations { get; set; }

        public virtual VendorType VendorType { get; set; }
    }
}
