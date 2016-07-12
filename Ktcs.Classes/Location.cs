using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Location")]
  public partial class Location
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Location()
    {
      ScheduledClasses = new HashSet<ScheduledClass>();
    }

    [DisplayName("Location Id")]
    public int LocationId { get; set; }

    [Required]
    [StringLength(75)]
    [DisplayName("Location Name")]
    public string LocName { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string Locaddress { get; set; }

    [Required]
    [StringLength(30)]
    [DisplayName("City")]
    public string Loccity { get; set; }

    [Required]
    [StringLength(2)]
    [DisplayName("State")]
    public string Locstate { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string Loczip { get; set; }

    [StringLength(300)]
    [DisplayName("Notes")]
    public string Locnotes { get; set; }

    [DisplayName("vendor Id")]
    public int? VendorId { get; set; }

    [StringLength(75)]
    [DisplayName("Map Link")]
    public string LocmapLink { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string Locphone { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string Loccountry { get; set; }

    public virtual Vendor Vendor { get; set; }

    [DisplayName("Scheduled Classes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
  }
}
