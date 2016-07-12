using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("student")]
  public partial class Student
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Student()
    {
      Enrollments = new HashSet<Enrollment>();
      WaitLists = new HashSet<WaitList>();
    }
    [DisplayName("student Id")]
    public int StudentId { get; set; }

    [Required]
    [StringLength(35)]
    [DisplayName("Last Name")]
    public string StuLName { get; set; }

    [StringLength(30)]
    [DisplayName("First Name")]
    public string StuFName { get; set; }

    [StringLength(75)]
    [DisplayName("Email")]
    public string StuEmail { get; set; }

    [StringLength(70)]
    [DisplayName("Job Title")]
    public string StuJobTitle { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string Stuaddress { get; set; }

    [StringLength(75)]
    [DisplayName("Address Line 2")]
    public string Stuaddress2 { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string StuCity { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string Stustate { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string Stuzip { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string StuCountry { get; set; }

    [StringLength(20)]
    [DisplayName("Home Phone")]
    public string StuHomePhone { get; set; }

    [StringLength(2)]
    [DisplayName("International Code")]
    public string StuInternationalCode { get; set; }

    [StringLength(20)]
    [DisplayName("Work Phone")]
    public string StuWorkPhone { get; set; }

    [DisplayName("Fax")]
    [StringLength(20)]
    public string Stufax { get; set; }

    [StringLength(70)]
    [DisplayName("Product Area")]
    public string StuProductArea { get; set; }

    [DisplayName("Manager Id")]
    public int ManagerId { get; set; }

    [DisplayName("Company Id")]
    public int CompanyId { get; set; }

    [StringLength(10)]
    [DisplayName("Password")]
    public string Password { get; set; }

    [DisplayName("student Password")]
    [StringLength(10)]
    public string Stupassword { get; set; }

    [DisplayName("Referred By Id")]
    public int? ReferredById { get; set; }

    [StringLength(15)]
    [DisplayName("Cost Center")]
    public string CostCenter { get; set; }

    [StringLength(75)]
    [DisplayName("Billing Name")]
    public string BillName { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string BillAddress { get; set; }

    [StringLength(75)]
    [DisplayName("Address 2")]
    public string BillAddress2 { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string BillCity { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string BillState { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string BillZip { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string BillCountry { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string BillPhone { get; set; }

    [StringLength(20)]
    [DisplayName("Fax")]
    public string BillFax { get; set; }

    [StringLength(75)]
    [DisplayName("Email")]
    public string BillEmail { get; set; }

    [StringLength(2)]
    [DisplayName("International Code")]
    public string BillInternationalCode { get; set; }

    [StringLength(60)]
    [DisplayName("Other Company")]
    public string OtherCompany { get; set; }

    [StringLength(60)]
    [DisplayName("Other Referred By")]
    public string OtherReferredBy { get; set; }

    [StringLength(60)]
    [DisplayName("Other Manager")]
    public string OtherManager { get; set; }

    [StringLength(20)]
    [DisplayName("Other Manager Phone")]
    public string OtherManagerPhone { get; set; }

    [StringLength(3)]
    [DisplayName("Mail List")]
    public string MailList { get; set; }

    [StringLength(10)]
    [DisplayName("User Id")]
    public string UserId { get; set; }

    [DisplayName("Classes Taken")]
    public byte? ClassesTaken { get; set; }

    [StringLength(3)]
    [DisplayName("Block Reminder Email")]
    public string BlockReminder { get; set; }

    [StringLength(75)]
    [DisplayName("Other")]
    public string Other { get; set; }

    [StringLength(3)]
    [DisplayName("Is Archived")]
    public string Stuarchived { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Enrollment> Enrollments { get; set; }

    [DisplayName("Wait Lists")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<WaitList> WaitLists { get; set; }
  }
}
