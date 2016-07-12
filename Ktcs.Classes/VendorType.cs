using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("VendorType")]
  public partial class VendorType
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public VendorType()
    {
      Vendors = new HashSet<Vendor>();
    }
    [DisplayName("vendor Type Id")]
    public int VendorTypeId { get; set; }

    [Column("VendorType")]
    [Required]
    [StringLength(50)]
    [DisplayName("vendor Type")]
    public string VendorType1 { get; set; }


    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Vendor> Vendors { get; set; }
  }
}
