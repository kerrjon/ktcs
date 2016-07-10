namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Survey")]
    public partial class Survey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Survey()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
            SurveyQuestions = new HashSet<SurveyQuestion>();
        }

        public int SurveyID { get; set; }

        [Required]
        [StringLength(75)]
        public string SurveyName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        [Required]
        [StringLength(3)]
        public string DefaultSurvey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
