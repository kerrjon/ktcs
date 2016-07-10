namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            SurveyQuestions = new HashSet<SurveyQuestion>();
        }

        [Key]
        public int QID { get; set; }

        [Column("Question")]
        [Required]
        [StringLength(255)]
        public string Question1 { get; set; }

        public int ATypeID { get; set; }

        public int SectionID { get; set; }

        public virtual AType AType { get; set; }

        public virtual SectionType SectionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
