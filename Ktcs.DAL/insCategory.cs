namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insCategory")]
    public partial class insCategory
    {
        [Key]
        [Column("insCategory")]
        [StringLength(50)]
        public string insCategory1 { get; set; }
    }
}
