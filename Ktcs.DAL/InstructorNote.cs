namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstructorNote")]
    public partial class InstructorNote
    {
        [Key]
        public int NoteID { get; set; }

        [Required]
        [StringLength(50)]
        public string InstructorID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NoteDate { get; set; }

        [Required]
        [StringLength(7000)]
        public string Notes { get; set; }

        public int NoteTypeID { get; set; }

        [StringLength(3)]
        public string AdminInitials { get; set; }

        [StringLength(7000)]
        public string FollowUp { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FollowUpDate { get; set; }

        [StringLength(10)]
        public string Priority { get; set; }

        [StringLength(60)]
        public string toDoFor { get; set; }
    }
}
