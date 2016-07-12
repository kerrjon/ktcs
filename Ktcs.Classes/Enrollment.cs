using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  public partial class Enrollment
  {
    [Key]
    [DisplayName("Confirmation Number")]
    public int ConfirmationNum { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Enrolled { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Confirmation { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Reminder { get; set; }

    [Column(TypeName = "money")]
    public decimal? Paid { get; set; }

    [StringLength(10)]
    public string Invoice { get; set; }

    [Column(TypeName = "money")]
    public decimal? Discount { get; set; }

    [Column(TypeName = "money")]
    [DisplayName("MTS Fee")]
    public decimal? MtSfee { get; set; }

    public int StatusId { get; set; }

    [Column(TypeName = "money")]
    [DisplayName("Amount Due")]
    public decimal? Amountdue { get; set; }

    [DisplayName("student Id")]
    public int StudentId { get; set; }

    [DisplayName("Schedule Class Id")]
    public int ScheduledClassId { get; set; }

    [StringLength(10)]
    [DisplayName("Cancellation Number")]
    public string CancellationNum { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Cancellation Date")]
    public DateTime? CancellationDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Date Due")]
    public DateTime? DateDue { get; set; }

    [StringLength(3)]
    [DisplayName("Manager Confirmation")]
    public string MgrConfirmation { get; set; }

    [StringLength(3)]
    public string Conarchived { get; set; }

    [Column(TypeName = "money")]
    [DisplayName("Discount in Dollars")]
    public decimal? DiscountDollars { get; set; }

    [DisplayName("Scheduled Class")]
    public virtual ScheduledClass ScheduledClass { get; set; }

    public virtual Status Status { get; set; }

    public virtual Student Student { get; set; }
  }
}
