using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{

  [Table("BrandCategory")]
  public partial class BrandCategory
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BrandCategory()
    {
      Courses = new HashSet<Course>();
    }

    [Column("brandCategory")]
    [StringLength(200)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [DisplayName("Brand Category Id")]
    public int BrandCategoryId { get; set; }

    [DisplayName("Brand Id")]
    public int? BrandId { get; set; }

    public virtual Brand Brand { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Course> Courses { get; set; }
  }
}
