namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BrandCategory")]
    public partial class BrandCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrandCategory()
        {
            Courses = new HashSet<Course>();
        }

        [Column("brandCategory")]
        [StringLength(200)]
        public string brandCategory1 { get; set; }

        public int BrandCategoryID { get; set; }

        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
