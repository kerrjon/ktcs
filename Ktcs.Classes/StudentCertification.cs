using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  public partial class StudentCertification
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [DisplayName("student Id")]
    public int StudentId { get; set; }

    [DisplayName("Certification Id")]
    public int CertificationId { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Expiration Date")]
    public DateTime ExpireDate { get; set; }
  }
}
