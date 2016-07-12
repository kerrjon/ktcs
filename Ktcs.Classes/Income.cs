using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Income")]
  public partial class Income
  {
    [DisplayName("Income Id")]
    public int IncomeId { get; set; }

    [DisplayName("Company Id")]
    public int CompanyId { get; set; }

    [Column(TypeName = "smallmoney")]
    public decimal? Cost { get; set; }

    [DisplayName("Quantity")]
    public int? Qty { get; set; }

    [StringLength(300)]
    public string Description { get; set; }

    [DisplayName("Income Type Id")]
    public int? IncomeTypeId { get; set; }

    [DisplayName("Schedule Class Id")]
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
  }
}
