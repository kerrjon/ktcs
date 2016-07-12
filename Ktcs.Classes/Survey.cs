using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Survey")]
  public partial class Survey
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Survey()
    {
      ScheduledClasses = new HashSet<ScheduledClass>();
      SurveyQuestions = new HashSet<SurveyQuestion>();
    }
    [DisplayName("Survey Id")]
    public int SurveyId { get; set; }

    [Required]
    [StringLength(75)]
    [DisplayName("Name")]
    public string SurveyName { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Created")]
    public DateTime DateCreated { get; set; }

    [StringLength(50)]
    public string Creator { get; set; }

    [Required]
    [StringLength(3)]
    [DisplayName("Is Default Survey")]
    public string DefaultSurvey { get; set; }

    [DisplayName("Schedule Classes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }

    [DisplayName("Survey Questions")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
  }
}
