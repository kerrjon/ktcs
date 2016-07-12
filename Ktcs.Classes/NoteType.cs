using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ktcs.Classes
{
  [Table("NoteType")]
  public partial class NoteType
  {
    public int NoteTypeId { get; set; }

    [Column("NoteType")]
    [Required]
    [StringLength(30)]
    [DisplayName("Note Type")]
    public string NoteType1 { get; set; }
  }
}
