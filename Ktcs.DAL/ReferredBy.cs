namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReferredBy")]
    public partial class ReferredBy
    {
        public int ReferredByID { get; set; }

        [Column("ReferredBy")]
        [Required]
        [StringLength(50)]
        public string ReferredBy1 { get; set; }
    }
}
