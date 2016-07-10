namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ComContactNote")]
    public partial class ComContactNote
    {
        [Key]
        public int NoteID { get; set; }

        public int ComContactID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NoteDate { get; set; }

        [Required]
        [StringLength(4000)]
        public string Notes { get; set; }

        public int NoteTypeID { get; set; }

        [StringLength(3)]
        public string AdminInitials { get; set; }

        [StringLength(4000)]
        public string FollowUp { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FollowUpDate { get; set; }

        [StringLength(10)]
        public string Priority { get; set; }

        [StringLength(60)]
        public string toDoFor { get; set; }
    }
}
