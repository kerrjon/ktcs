using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("WaitList")]
  public partial class WaitList
  {
    [DisplayName("Wait List Id")]
    public int WaitListId { get; set; }

    [DisplayName("student Id")]
    public int StudentId { get; set; }

    [Required]
    [StringLength(10)]
    [DisplayName("Course Number")]
    public string CourseNumber { get; set; }

    [StringLength(20)]
    [DisplayName("Time Frame")]
    public string TimeFrame { get; set; }

    [Column(TypeName = "ntext")]
    [DisplayName("Comments")]
    public string Comments { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Created")]
    public DateTime DateCreated { get; set; }

    public virtual Student Student { get; set; }
  }
}
