using System.ComponentModel;

namespace Ktcs.Classes
{
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;

  [Table("Instructor")]
  public partial class Instructor
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Instructor()
    {
      ScheduledClasses = new HashSet<ScheduledClass>();
    }

    [StringLength(10)]
    [DisplayName("Instructor Id")]
    public string InstructorId { get; set; }

    [StringLength(30)]
    [DisplayName("First Name")]
    public string Insfname { get; set; }

    [Required]
    [StringLength(35)]
    [DisplayName("Last Name")]
    public string Inslname { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string Insaddress { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string Inscity { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string Insstate { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string Inszip { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string Insphone { get; set; }

    [StringLength(20)]
    [DisplayName("Phone2")]
    public string Insphone2 { get; set; }

    [StringLength(60)]
    [DisplayName("Email")]
    public string Insemail { get; set; }

    [StringLength(60)]
    [DisplayName("Email 2")]
    public string Insemail2 { get; set; }

    [StringLength(20)]
    [DisplayName("Fax")]
    public string Insfax { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string Inscountry { get; set; }

    [DisplayName("vendor Id")]
    public int VendorId { get; set; }

    [StringLength(10)]
    public string Password { get; set; }

    [StringLength(50)]
    [DisplayName("Is Independent")]
    public string InsIndependent { get; set; }

    [StringLength(50)]
    [DisplayName("Referred By")]
    public string InsReferredBy { get; set; }

    [StringLength(200)]
    public string Keywords { get; set; }

    [StringLength(7000)]
    [DisplayName("Resume Text")]
    public string ResumeText { get; set; }

    [StringLength(50)]
    [DisplayName("Skill 1")]
    public string Skill1 { get; set; }

    [StringLength(50)]
    [DisplayName("Skill 2")]
    public string Skill2 { get; set; }

    [StringLength(50)]
    [DisplayName("Skill 3")]
    public string Skill3 { get; set; }

    [StringLength(50)]
    [DisplayName("Skill 4")]
    public string Skill4 { get; set; }

    [StringLength(50)]
    [DisplayName("Skill 5")]
    public string Skill5 { get; set; }

    [StringLength(50)]
    [DisplayName("Category 1")]
    public string Category1 { get; set; }

    [StringLength(50)]
    [DisplayName("Category 2")]
    public string Category2 { get; set; }

    [StringLength(50)]
    [DisplayName("Category 3")]
    public string Category3 { get; set; }

    [StringLength(2000)]
    public string Notes { get; set; }

    [StringLength(2000)]
    [DisplayName("Courseware Notes")]
    public string CoursewareNotes { get; set; }

    [DisplayName("Scheduled Classes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
  }
}
