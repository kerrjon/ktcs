namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("WaitList")]
    public partial class WaitList
    {
        public int WaitListID { get; set; }

        public int StudentID { get; set; }

        [Required]
        [StringLength(10)]
        public string CourseNumber { get; set; }

        [StringLength(20)]
        public string TimeFrame { get; set; }

        [Column(TypeName = "ntext")]
        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }

        public virtual student student { get; set; }
    }
}
