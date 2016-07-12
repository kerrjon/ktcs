using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  [Table("Brand")]
  public partial class Brand
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Brand()
    {
      BrandCategories = new HashSet<BrandCategory>();
    }

    [Column("brand")]
    [StringLength(200)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [DisplayName("Brand Id")]
    public int BrandId { get; set; }

    [DisplayName("Brand Categories")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BrandCategory> BrandCategories { get; set; }
  }

}
