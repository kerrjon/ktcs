using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Answer")]
  public partial class Answer
  {
    [DisplayName("Answer Id")]
    public int AnswerId { get; set; }

    [Column(TypeName = "ntext")]
    [DisplayName("Answer Text")]
    public string AnswerTxt { get; set; }

    [DisplayName("Answer Number")]
    public decimal? AnswerNum { get; set; }

    [DisplayName("Survey Question Id")]
    public int Sqid { get; set; }

    [DisplayName("student Id")]
    public int? StudentId { get; set; }

    [DisplayName("Scheduled Class Id")]
    public int? ScheduledClassId { get; set; }
  }
}
