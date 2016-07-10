namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("insSkill")]
    public partial class insSkill
    {
        [Key]
        [Column("insSkill")]
        [StringLength(50)]
        public string insSkill1 { get; set; }
    }
}
