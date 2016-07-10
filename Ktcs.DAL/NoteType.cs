namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
