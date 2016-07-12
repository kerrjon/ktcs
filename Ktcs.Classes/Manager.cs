using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Manager")]
  public partial class Manager
  {
    [DisplayName("Manager Id")]
    public int ManagerId { get; set; }

    [StringLength(30)]
    [DisplayName("First Name")]
    public string MgrFName { get; set; }

    [Required]
    [StringLength(35)]
    [DisplayName("Last Name")]
    public string MgrLName { get; set; }

    [StringLength(20)]
    [DisplayName("Phone")]
    public string MgrPhone { get; set; }

    [StringLength(60)]
    [DisplayName("Email")]
    public string MgrEmail { get; set; }

    [StringLength(20)]
    [DisplayName("Fax")]
    public string MgrFax { get; set; }
  }
}
