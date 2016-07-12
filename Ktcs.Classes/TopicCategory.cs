using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("TopicCategory")]
  public partial class TopicCategory
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TopicCategory()
    {
      Courses = new HashSet<Course>();
    }

    [Column("topicCategory")]
    [StringLength(200)]
    [DisplayName("Name")]
    public string Name { get; set; }

    [DisplayName("Topic Category Id")]
    public int TopicCategoryId { get; set; }

    [DisplayName("Topic Id")]
    public int? TopicId { get; set; }

    public virtual Topic Topic { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Course> Courses { get; set; }
  }
}
