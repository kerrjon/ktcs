namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CourseTypeDetail")]
    public partial class CourseTypeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseTypeDetail()
        {
            Courses = new HashSet<Course>();
        }

        public int CourseTypeDetailID { get; set; }

        public int CourseTypeID { get; set; }

        [Column("CourseTypeDetail")]
        [Required]
        [StringLength(60)]
        public string CourseTypeDetail1 { get; set; }

        [StringLength(500)]
        public string pagenotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }

        public virtual CourseType CourseType { get; set; }
    }
}
