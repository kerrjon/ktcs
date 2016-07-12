using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("IncomeType")]
  public partial class IncomeType
  {
    public int IncomeTypeId { get; set; }

    [Column("IncomeType")]
    [Required]
    [StringLength(50)]
    [DisplayName("Income Type")]
    public string IncomeType1 { get; set; }
  }
}
