using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  public partial class Status
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Status()
    {
      Enrollments = new HashSet<Enrollment>();
    }
    [DisplayName("Status Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int StatusId { get; set; }

    [Column("Status")]
    [Required]
    [StringLength(30)]
    [DisplayName("Status")]
    public string Status1 { get; set; }

    [StringLength(6)]
    [DisplayName("Background Color")]
    public string BgColor { get; set; }

    [StringLength(6)]
    [DisplayName("Font Color")]
    public string FtColor { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Enrollment> Enrollments { get; set; }
  }
}
