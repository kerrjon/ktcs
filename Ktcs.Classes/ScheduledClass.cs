using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("ScheduledClass")]
  public partial class ScheduledClass
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ScheduledClass()
    {
      Enrollments = new HashSet<Enrollment>();
    }
    [DisplayName("Scheduled Class Id")]
    public int ScheduledClassId { get; set; }

    [Required]
    [StringLength(10)]
    [DisplayName("Course Number")]
    public string CourseNumber { get; set; }

    [DisplayName("Start Date")]
    public DateTime? StartDate { get; set; }

    [DisplayName("End Date")]
    public DateTime? EndDate { get; set; }

    [StringLength(50)]
    [DisplayName("Start Time")]
    public string StartTime { get; set; }

    [StringLength(50)]
    [DisplayName("End Time")]
    public string EndTime { get; set; }

    [Column(TypeName = "smallmoney")]
    [DisplayName("Price")]
    public decimal? Price { get; set; }

    [Column(TypeName = "smallmoney")]
    [DisplayName("Market Rate")]
    public decimal? MarketRate { get; set; }

    [Required]
    [StringLength(3)]
    [DisplayName("Is Public Class")]
    public string Ispublic { get; set; }

    [Column(TypeName = "smallmoney")]
    [DisplayName("KTCS Rate")]
    public decimal? KtcsRate { get; set; }

    [StringLength(3)]
    [DisplayName("KTCS Course")]
    public string KtcScourse { get; set; }

    [StringLength(3)]
    [DisplayName("Start Date is Confirmed")]
    public string StartDateconfirmed { get; set; }

    [StringLength(3)]
    [DisplayName("Book Order is Made")]
    public string BookOrderMade { get; set; }

    [StringLength(3)]
    [DisplayName("Survey Reminder Sent")]
    public string InsTestReminder { get; set; }

    [StringLength(3)]
    [DisplayName("Book Order Received")]
    public string BookOrderRecieved { get; set; }

    [StringLength(3)]
    [DisplayName("Instructor is Confirmed")]
    public string Insconfirmed { get; set; }

    [StringLength(3)]
    [DisplayName("Location is Confirmed")]
    public string Locconfirmed { get; set; }

    [DisplayName("Maximium Students")]
    public short? MaxStudents { get; set; }

    [DisplayName("Location Id")]
    public int LocationId { get; set; }

    [StringLength(10)]
    [DisplayName("Instructor Id")]
    public string InstructorId { get; set; }

    [DisplayName("Company Id")]
    public int CompanyId { get; set; }

    [DisplayName("Survey Id")]
    public int SurveyId { get; set; }

    [StringLength(50)]
    [DisplayName("Mirrored")]
    public string Mirrored { get; set; }

    [StringLength(100)]
    [DisplayName("Mirrored Website")]
    public string MirroredWebsite { get; set; }

    public virtual Course Course { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Enrollment> Enrollments { get; set; }

    public virtual Instructor Instructor { get; set; }

    public virtual Location Location { get; set; }

    public virtual Survey Survey { get; set; }
  }
}
