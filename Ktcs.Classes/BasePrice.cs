namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("BasePrice")]
    public partial class BasePrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BasePrice()
        {
            Courses = new HashSet<Course>();
        }

        public int BasePriceID { get; set; }

        [Column("BasePrice", TypeName = "smallmoney")]
        public decimal BasePrice1 { get; set; }

        [StringLength(75)]
        public string BaseDescription { get; set; }

        [Required]
        [StringLength(100)]
        public string membership { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
