using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public string brand1 { get; set; }

    public int brandId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BrandCategory> BrandCategories { get; set; }
  }

}
