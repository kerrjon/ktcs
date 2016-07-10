namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Answer")]
    public partial class Answer
    {
        public int AnswerID { get; set; }

        [Column(TypeName = "ntext")]
        public string AnswerTxt { get; set; }

        public decimal? AnswerNum { get; set; }

        public int SQID { get; set; }

        public int? StudentID { get; set; }

        public int? ScheduledClassID { get; set; }
    }
}
