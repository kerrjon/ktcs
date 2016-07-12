using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("SectionType")]
  public partial class SectionType
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SectionType()
    {
      Questions = new HashSet<Question>();
    }

    [Key]
    [DisplayName("Section Id")]
    public int SectionId { get; set; }

    [Required]
    [StringLength(50)]
    [DisplayName("Section Name")]
    public string SectionName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Question> Questions { get; set; }
  }
}
