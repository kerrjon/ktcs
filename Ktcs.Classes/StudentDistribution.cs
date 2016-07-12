using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("StudentDistribution")]
  public partial class StudentDistribution
  {
    [DisplayName("student Distribution Id")]
    public int StudentDistributionId { get; set; }

    [DisplayName("student Id")]
    public int StudentId { get; set; }

    [DisplayName("Distribution Id")]
    public int DistributionId { get; set; }

    [Required]
    [StringLength(20)]
    [DisplayName("Exam Status")]
    public string ExamStatus { get; set; }

    [DisplayName("Start Time")]
    public DateTime? StartTime { get; set; }

    [DisplayName("End Time")]
    public DateTime? EndTime { get; set; }
  }
}
