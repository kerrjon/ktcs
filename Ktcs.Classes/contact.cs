using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("contact")]
  public partial class Contact
  {
    [DisplayName("contact Id")]
    public int ContactId { get; set; }

    [DisplayName("vendor Id")]
    public int Vendorid { get; set; }

    [StringLength(75)]
    [DisplayName("Title")]
    public string Contitle { get; set; }

    [StringLength(30)]
    [DisplayName("First Name")]
    public string ConFName { get; set; }

    [Required]
    [StringLength(35)]
    [DisplayName("Last Name")]
    public string ConLName { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string Conaddress { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string Concity { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string Constate { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string Conzip { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string Concountry { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string Conphone { get; set; }

    [StringLength(15)]
    [DisplayName("Ext. 1")]
    public string Conext1 { get; set; }

    [StringLength(20)]
    [DisplayName("Phone2")]
    public string Conphone2 { get; set; }

    [StringLength(15)]
    [DisplayName("Ext. 2")]
    public string Conext2 { get; set; }

    [StringLength(60)]
    [DisplayName("Email")]
    public string Conemail { get; set; }

    [StringLength(60)]
    [DisplayName("Email 2")]
    public string Conemail2 { get; set; }

    [StringLength(20)]
    [DisplayName("Fax")]
    public string Confax { get; set; }
  }
}
