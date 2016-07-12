using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  [Table("instructorCert")]
  public partial class InstructorCert
  {
    [Key]
    [Column(Order = 0)]
    [StringLength(50)]
    [DisplayName("Instructor Certification")]
    public string InsCertification { get; set; }

    [Key]
    [Column(Order = 1)]
    [StringLength(10)]
    [DisplayName("Instructor Id")]
    public string InstructorId { get; set; }
  }
}
