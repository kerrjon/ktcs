namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("subCategory")]
    public partial class subCategory
    {
        public int subCategoryID { get; set; }

        [Column("subCategory")]
        [Required]
        [StringLength(100)]
        public string subCategory1 { get; set; }

        public int CategoryID { get; set; }
    }
}
