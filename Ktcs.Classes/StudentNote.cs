using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("StudentNote")]
  public partial class StudentNote
  {
    [Key]
    [DisplayName("Note Id")]
    public int NoteId { get; set; }

    [DisplayName("student Id")]
    public int StudentId { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Note Date")]
    public DateTime NoteDate { get; set; }

    [StringLength(4000)]
    public string Notes { get; set; }

    [DisplayName("Note Type Id")]
    public int NoteTypeId { get; set; }

    [StringLength(4000)]
    [DisplayName("Follow Up")]
    public string Followup { get; set; }

    [StringLength(3)]
    [DisplayName("Admin Initials")]
    public string AdminInitials { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Follow Up Date")]
    public DateTime? FollowUpDate { get; set; }

    [StringLength(60)]
    [DisplayName("To Do For")]
    public string ToDoFor { get; set; }

    [StringLength(10)]
    public string Priority { get; set; }
  }
}
