namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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
