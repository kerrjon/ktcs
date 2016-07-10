namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VendorType")]
    public partial class VendorType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VendorType()
        {
            vendors = new HashSet<vendor>();
        }

        public int VendorTypeID { get; set; }

        [Column("VendorType")]
        [Required]
        [StringLength(50)]
        public string VendorType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vendor> vendors { get; set; }
    }
}
