namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authority")]
    public partial class Authority
    {
        [Key]
        [Column(Order = 0)]
        public int AuthorityID { get; set; }

        [Key]
        [Column("Authority", Order = 1)]
        [StringLength(30)]
        public string Authority1 { get; set; }
    }
}
