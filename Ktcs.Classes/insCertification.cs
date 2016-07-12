using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("insCertification")]
  public partial class InsCertification
  {
    [Key]
    [Column("insCertification")]
    [StringLength(50)]
    [DisplayName("Instructor Certification")]
    public string InsCertification1 { get; set; }
  }
}
