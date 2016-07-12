using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("ComContactNote")]
  public partial class ComContactNote
  {
    [Key]
    [DisplayName("Note Id")]
    public int NoteId { get; set; }

    [DisplayName("contact Id")]
    public int ComContactId { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Note Date")]
    public DateTime NoteDate { get; set; }

    [Required]
    [StringLength(4000)]
    [DisplayName("Notes")]
    public string Notes { get; set; }

    [DisplayName("Note Type Id")]
    public int NoteTypeId { get; set; }

    [StringLength(3)]
    [DisplayName("Admin Initials")]
    public string AdminInitials { get; set; }

    [StringLength(4000)]
    [DisplayName("Follow Up")]
    public string FollowUp { get; set; }

    [Column(TypeName = "smalldatetime")]
    [DisplayName("Follow Up Date")]
    public DateTime? FollowUpDate { get; set; }

    [StringLength(10)]
    [DisplayName("Priority")]
    public string Priority { get; set; }

    [StringLength(60)]
    [DisplayName("To Do For")]
    public string ToDoFor { get; set; }
  }
}
