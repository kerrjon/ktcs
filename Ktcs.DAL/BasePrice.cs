namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BasePrice")]
    public partial class BasePrice
    {
        public int BasePriceID { get; set; }

        [Column("BasePrice", TypeName = "smallmoney")]
        public decimal BasePrice1 { get; set; }

        [StringLength(75)]
        public string BaseDescription { get; set; }

        [Required]
        [StringLength(100)]
        public string membership { get; set; }
    }
}
