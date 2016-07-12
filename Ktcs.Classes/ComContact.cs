using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  [Table("ComContact")]
  public partial class ComContact
  {
    [DisplayName("contact Id")]
    public int ComContactId { get; set; }

    [DisplayName("Company Id")]
    public int CompanyId { get; set; }

    [StringLength(75)]
    [DisplayName("Title")]
    public string ComConTitle { get; set; }

    [StringLength(30)]
    [DisplayName("First Name")]
    public string ComConFName { get; set; }

    [Required]
    [StringLength(35)]
    [DisplayName("Last Name")]
    public string ComConLName { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string ComConAddress { get; set; }

    [StringLength(75)]
    [DisplayName("Address Line 2")]
    public string ComConAddress2 { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string ComConCity { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string ComConState { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string ComConZip { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string ComConCountry { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string ComConPhone { get; set; }

    [StringLength(20)]
    [DisplayName("Phone 2")]
    public string ComConPhone2 { get; set; }

    [StringLength(60)]
    [DisplayName("Email")]
    public string ComConEmail { get; set; }

    [StringLength(60)]
    [DisplayName("Email 2")]
    public string ComConEmail2 { get; set; }

    [StringLength(20)]
    [DisplayName("Fax")]
    public string ComConFax { get; set; }

    
  }
}
