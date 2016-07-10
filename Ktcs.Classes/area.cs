namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("area")]
    public partial class area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public area()
        {
            CourseTypes = new HashSet<CourseType>();
        }

        public int AreaID { get; set; }

        [Column("Area")]
        [Required]
        [StringLength(50)]
        public string Area1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseType> CourseTypes { get; set; }
    }
}
