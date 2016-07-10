namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("AType")]
    public partial class AType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AType()
        {
            Questions = new HashSet<Question>();
        }

        public int ATypeID { get; set; }

        [Column("AType")]
        [Required]
        [StringLength(50)]
        public string AType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
