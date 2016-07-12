using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Question")]
  public partial class Question
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Question()
    {
      SurveyQuestions = new HashSet<SurveyQuestion>();
    }

    [Key]
    [DisplayName("Question Id")]
    public int Qid { get; set; }

    [Column("Question")]
    [Required]
    [StringLength(255)]
    [DisplayName("Question")]
    public string Question1 { get; set; }

    [DisplayName("Answer Type Id")]
    public int ATypeId { get; set; }

    [DisplayName("Section Id")]
    public int SectionId { get; set; }

    [DisplayName("Answser Type")]
    public virtual AType AType { get; set; }

    [DisplayName("Section Type")]
    public virtual SectionType SectionType { get; set; }

    [DisplayName("Survey Questions")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
  }
}
