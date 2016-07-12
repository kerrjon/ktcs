using System.ComponentModel;

namespace Ktcs.Classes
{
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;

  [Table("insSkill")]
  public partial class InsSkill
  {
    [Key]
    [Column("insSkill")]
    [StringLength(50)]
    [DisplayName("Instructor Skill")]
    public string InsSkill1 { get; set; }
  }
}
