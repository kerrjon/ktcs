namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("StudentNote")]
    public partial class StudentNote
    {
        [Key]
        public int NoteID { get; set; }

        public int StudentID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NoteDate { get; set; }

        [StringLength(4000)]
        public string Notes { get; set; }

        public int NoteTypeID { get; set; }

        [StringLength(4000)]
        public string followup { get; set; }

        [StringLength(3)]
        public string AdminInitials { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FollowUpDate { get; set; }

        [StringLength(60)]
        public string ToDoFor { get; set; }

        [StringLength(10)]
        public string Priority { get; set; }
    }
}
