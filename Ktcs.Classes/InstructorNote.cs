using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("InstructorNote")]
  public partial class InstructorNote
  {
    [Key]
    [DisplayName("Note Id")]
    public int NoteId { get; set; }

    [Required]
    [StringLength(50)]
    [DisplayName("Instructor Id")]
    public string InstructorId { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Note Date")]
    public DateTime NoteDate { get; set; }

    [Required]
    [StringLength(7000)]
    public string Notes { get; set; }

    [DisplayName("Note Type Id")]
    public int NoteTypeId { get; set; }

    [StringLength(3)]
    [DisplayName("Admin Initials")]
    public string AdminInitials { get; set; }

    [StringLength(7000)]
    [DisplayName("Follow Up")]
    public string FollowUp { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Follow Up Date")]
    public DateTime? FollowUpDate { get; set; }

    [StringLength(10)]
    public string Priority { get; set; }

    [StringLength(60)]
    [DisplayName("To Do For")]
    public string ToDoFor { get; set; }
  }
}
