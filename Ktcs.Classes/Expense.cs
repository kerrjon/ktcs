using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  [Table("Expense")]
  public partial class Expense
  {
    [DisplayName("Expense Id")]
    public int ExpenseId { get; set; }

    [DisplayName("vendor Id")]
    public int VendorId { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal? Cost { get; set; }

    [DisplayName("Quantity")]
    public int? Qty { get; set; }

    [StringLength(300)]
    public string Description { get; set; }

    [DisplayName("Expense Type Id")]
    public int? ExpenseTypeId { get; set; }

    [DisplayName("Scheduled Class Id")]
    public int? ScheduledClassId { get; set; }

    [StringLength(10)]
    [DisplayName("vendor Invoice Number")]
    public string VenInvoiceNum { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("vendor Invoice Date")]
    public DateTime? VenInvoiceDate { get; set; }

    [StringLength(3)]
    [DisplayName("vendor Invoice Paid")]
    public string VenInvoicePaid { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal? Tax { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal? Shipping { get; set; }

    [DisplayName("Expense Type")]
    public virtual ExpenseType ExpenseType { get; set; }
  }
}
