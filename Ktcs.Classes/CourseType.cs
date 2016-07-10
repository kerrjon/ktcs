namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CourseType")]
    public partial class CourseType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseType()
        {
            CourseTypeDetails = new HashSet<CourseTypeDetail>();
        }

        public int courseTypeID { get; set; }

        [Column("courseType")]
        [Required]
        [StringLength(60)]
        public string courseType1 { get; set; }

        public int AreaID { get; set; }

        [StringLength(500)]
        public string pageNotes { get; set; }

        public int? visibleInFlyout { get; set; }

        [StringLength(50)]
        public string flyoutText { get; set; }

        public virtual area area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTypeDetail> CourseTypeDetails { get; set; }
    }
}
