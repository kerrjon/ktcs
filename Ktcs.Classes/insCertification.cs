namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("insCertification")]
    public partial class insCertification
    {
        [Key]
        [Column("insCertification")]
        [StringLength(50)]
        public string insCertification1 { get; set; }
    }
}
