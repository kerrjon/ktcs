namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CaseStudy")]
    public partial class CaseStudy
    {
        public int CaseStudyID { get; set; }

        [Required]
        [StringLength(60)]
        public string CaseStudyTitle { get; set; }

        [Required]
        [StringLength(7000)]
        public string CaseStudyText { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CaseStudyDate { get; set; }

        [Required]
        [StringLength(3)]
        public string visible { get; set; }

        [Required]
        [StringLength(150)]
        public string CaseSummary { get; set; }
    }
}
