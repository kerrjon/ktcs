namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

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
