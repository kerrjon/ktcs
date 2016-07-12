using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("insCategory")]
  public partial class InsCategory
  {
    [Key]
    [Column("insCategory")]
    [StringLength(50)]
    [DisplayName("Instructor Category")]
    public string InsCategory1 { get; set; }
  }
}
