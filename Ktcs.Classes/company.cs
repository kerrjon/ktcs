using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Company")]
  public partial class Company
  {
    [DisplayName("Company Id")]
    public int CompanyId { get; set; }

    [Required]
    [StringLength(75)]
    [DisplayName("Company Name")]
    public string ComName { get; set; }

    [StringLength(75)]
    [DisplayName("Address")]
    public string ComAddress { get; set; }

    [StringLength(75)]
    [DisplayName("Address 2")]
    public string ComAddress2 { get; set; }

    [StringLength(30)]
    [DisplayName("City")]
    public string ComCity { get; set; }

    [StringLength(2)]
    [DisplayName("State")]
    public string ComState { get; set; }

    [StringLength(12)]
    [DisplayName("Zip")]
    public string ComZip { get; set; }

    [StringLength(30)]
    [DisplayName("Country")]
    public string Comcountry { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string Comphone { get; set; }

    [StringLength(20)]
    [DisplayName("Fax")]
    public string Comfax { get; set; }

    [StringLength(75)]
    [DisplayName("Map Link")]
    public string ComMapLink { get; set; }

    [StringLength(50)]
    [DisplayName("Billing Name")]
    public string Billname { get; set; }

    [StringLength(75)]
    [DisplayName("Billing Address")]
    public string Billaddress { get; set; }

    [StringLength(75)]
    [DisplayName("Billing Address 2")]
    public string Billaddress2 { get; set; }

    [StringLength(30)]
    [DisplayName("Billing City")]
    public string Billcity { get; set; }

    [StringLength(2)]
    [DisplayName("Billing State")]
    public string Billstate { get; set; }

    [StringLength(12)]
    [DisplayName("Billing Zip")]
    public string Billzip { get; set; }

    [StringLength(20)]
    [DisplayName("Billing Phone")]
    public string Billphone { get; set; }

    [StringLength(20)]
    [DisplayName("Billing Fax")]
    public string Billfax { get; set; }

    [StringLength(50)]
    [DisplayName("Billing Country")]
    public string Billcountry { get; set; }

    [StringLength(75)]
    [DisplayName("Billing Email")]
    public string Billemail { get; set; }

    [StringLength(75)]
    [DisplayName("Logo")]
    public string Logo { get; set; }
  }
}
