using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("ClassRequest")]
  public partial class ClassRequest
  {
    [Key]
    [DisplayName("Request Id")]
    public int RequestId { get; set; }

    [DisplayName("Student Id")]
    public int StudentId { get; set; }

    [DisplayName("Scheduled Class Id")]
    public int ScheduledClassId { get; set; }

    [DisplayName("Request Date")]
    [Column(TypeName = "smalldatetime")]
    public DateTime? RequestDate { get; set; }

    [DisplayName("Approval Sent")]
    [Column(TypeName = "smalldatetime")]
    public DateTime? ApprovalSent { get; set; }

    [DisplayName("Approval Received")]
    [Column(TypeName = "smalldatetime")]
    public DateTime? ApprovalReceived { get; set; }

    [StringLength(3)]
    public string Denied { get; set; }

    [StringLength(3)]
    public string Withdrew { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Enrolled { get; set; }

    [DisplayName("Withdrawal Reason")]
    [StringLength(255)]
    public string WithdrawReason { get; set; }
  }
}
