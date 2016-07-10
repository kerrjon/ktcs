namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Category")]
    public partial class Category
    {
        public int CategoryID { get; set; }

        [Column("Category")]
        [Required]
        [StringLength(100)]
        public string Category1 { get; set; }
    }
}
