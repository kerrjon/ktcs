using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  [Table("vendor")]
  public partial class Vendor
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Vendor()
    {
      Locations = new HashSet<Location>();
    }
    [DisplayName("vendor Id")]
    public int VendorId { get; set; }

    [Required]
    [StringLength(75)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string Address { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string City { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string State { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string Zip { get; set; }

    [StringLength(20)]
    public string Phone { get; set; }

    [StringLength(20)]
    public string Fax { get; set; }

    [StringLength(30)]
    public string Country { get; set; }

    [StringLength(255)]
    [DisplayName("Negotiated Discount")]
    public string NegDiscount { get; set; }

    [DisplayName("vendor Type Id")]
    public int VendorTypeId { get; set; }

    [StringLength(75)]
    [DisplayName("Map Link")]
    public string Maplink { get; set; }

    [StringLength(255)]
    public string Notes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Location> Locations { get; set; }

    [DisplayName("vendor Type")]
    public virtual VendorType VendorType { get; set; }
  }
}
