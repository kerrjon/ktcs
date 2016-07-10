namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insSkill")]
    public partial class insSkill
    {
        [Key]
        [Column("insSkill")]
        [StringLength(50)]
        public string insSkill1 { get; set; }
    }
}
