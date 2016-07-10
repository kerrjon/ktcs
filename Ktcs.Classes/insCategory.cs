namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("insCategory")]
    public partial class insCategory
    {
        [Key]
        [Column("insCategory")]
        [StringLength(50)]
        public string insCategory1 { get; set; }
    }
}
