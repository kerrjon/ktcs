using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("Topic")]
  public partial class Topic
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Topic()
    {
      TopicCategories = new HashSet<TopicCategory>();
    }

    [Column("topic")]
    [StringLength(200)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [DisplayName("Topic Id")]
    public int TopicId { get; set; }

    [DisplayName("Topic Categories")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TopicCategory> TopicCategories { get; set; }
  }
}
