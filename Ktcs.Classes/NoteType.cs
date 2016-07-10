namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NoteType")]
    public partial class NoteType
    {
        public int NoteTypeID { get; set; }

        [Column("NoteType")]
        [Required]
        [StringLength(30)]
        public string NoteType1 { get; set; }
    }
}
