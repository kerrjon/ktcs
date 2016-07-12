using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("SurveyQuestion")]
  public partial class SurveyQuestion
  {
    [Key]
    [DisplayName("Survey Question Id")]
    public int Sqid { get; set; }

    [DisplayName("Question Id")]
    public int Qid { get; set; }

    [DisplayName("Survey Id")]
    public int SurveyId { get; set; }

    public virtual Question Question { get; set; }

    public virtual Survey Survey { get; set; }
  }
}
