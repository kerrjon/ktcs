namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IncomeType")]
    public partial class IncomeType
    {
        public int IncomeTypeID { get; set; }

        [Column("IncomeType")]
        [Required]
        [StringLength(50)]
        public string IncomeType1 { get; set; }
    }
}
