using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Course")]
  public partial class Course
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Course()
    {
      ScheduledClasses = new HashSet<ScheduledClass>();
    }

    [Key]
    [StringLength(10)]
    [DisplayName("Course Number")]
    public string CourseNumber { get; set; }

    [StringLength(15)]
    [DisplayName("Official Course Number")]
    public string OfficialCourseNumber { get; set; }

    [Required]
    [StringLength(125)]
    public string Title { get; set; }

    [Column(TypeName = "ntext")]
    public string Description { get; set; }

    [StringLength(4000)]
    [DisplayName("Prerequisites")]
    public string Prereq { get; set; }

    [StringLength(10)]
    public string Duration { get; set; }

    [StringLength(1000)]
    public string Comments { get; set; }

    [StringLength(50)]
    [DisplayName("Instructor Comments")]
    public string Inscomments { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string Overview { get; set; }

    [StringLength(100)]
    public string Courseware { get; set; }

    [StringLength(100)]
    [DisplayName("Courseware vendor")]
    public string Coursewarevendor { get; set; }

    [DisplayName("Courseware Cost")]
    public decimal? Coursewarecost { get; set; }

    [StringLength(4000)]
    [DisplayName("Courseware Notes")]
    public string Coursewarenotes { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Created")]
    public DateTime? Datecreated { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Last Modified")]
    public DateTime? Lastupdate { get; set; }

    [StringLength(4000)]
    [DisplayName("Instructor Notes")]
    public string InstructorNotes { get; set; }

    [StringLength(250)]
    [DisplayName("vendor Website")]
    public string Vendorwebsite { get; set; }

    [DisplayName("Show on Website")]
    public int? Isvisable { get; set; }

    [DisplayName("Show in Flyout")]
    public int? VisibleInFlyout { get; set; }

    [DisplayName("Scheduled Classes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }

    [DisplayName("Brand Categories")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BrandCategory> BrandCategories { get; set; }

    [DisplayName("Topic Categories")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TopicCategory> TopicCategories { get; set; }

  }
}
