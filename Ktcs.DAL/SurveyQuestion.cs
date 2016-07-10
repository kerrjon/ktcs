namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SurveyQuestion")]
    public partial class SurveyQuestion
    {
        [Key]
        public int SQID { get; set; }

        public int QID { get; set; }

        public int SurveyID { get; set; }

        public virtual Question Question { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
