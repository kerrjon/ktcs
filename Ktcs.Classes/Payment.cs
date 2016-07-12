using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Payment")]
  public partial class Payment
  {
    [DisplayName("Payment Id")]
    public int PaymentId { get; set; }

    [Column(TypeName = "money")]
    [DisplayName("Amount Paid")]
    public decimal PayAmount { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Payment Date")]
    public DateTime PayDate { get; set; }

    [DisplayName("Confirmation Number")]
    public int ConfirmationNum { get; set; }
  }
}
