using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("ExpenseType")]
  public partial class ExpenseType
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ExpenseType()
    {
      Expenses = new HashSet<Expense>();
    }
    [DisplayName("Expense Type Id")]
    public int ExpenseTypeId { get; set; }

    [Column("ExpenseType")]
    [Required]
    [StringLength(75)]
    [DisplayName("Expense Type")]
    public string ExpenseType1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Expense> Expenses { get; set; }
  }
}
