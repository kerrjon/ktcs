using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("ReferredBy")]
  public partial class ReferredBy
  {
    public int ReferredById { get; set; }

    [Column("ReferredBy")]
    [Required]
    [StringLength(50)]
    [DisplayName("Referred By")]
    public string ReferredBy1 { get; set; }
  }
}
