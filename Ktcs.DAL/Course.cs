namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
            BrandCategories = new HashSet<BrandCategory>();
            TopicCategories = new HashSet<TopicCategory>();
        }

        [Key]
        [StringLength(10)]
        public string courseNumber { get; set; }

        [Required]
        [StringLength(125)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [StringLength(4000)]
        public string Prereq { get; set; }

        [StringLength(10)]
        public string Duration { get; set; }

        [StringLength(1000)]
        public string comments { get; set; }

        [StringLength(50)]
        public string inscomments { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string overview { get; set; }

        [StringLength(100)]
        public string courseware { get; set; }

        [StringLength(100)]
        public string coursewarevendor { get; set; }

        public decimal? coursewarecost { get; set; }

        [StringLength(4000)]
        public string coursewarenotes { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? datecreated { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? lastupdate { get; set; }

        [StringLength(4000)]
        public string instructorNotes { get; set; }

        [StringLength(250)]
        public string vendorwebsite { get; set; }

        public int? isvisable { get; set; }

        public int? visibleInFlyout { get; set; }

        public int? deliveryFormatId { get; set; }

        public bool? guaranteedToRun { get; set; }

        public virtual DeliveryFormat DeliveryFormat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrandCategory> BrandCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TopicCategory> TopicCategories { get; set; }
    }
}
