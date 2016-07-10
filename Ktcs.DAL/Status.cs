namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Status()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusID { get; set; }

        [Column("Status")]
        [Required]
        [StringLength(30)]
        public string Status1 { get; set; }

        [StringLength(6)]
        public string BgColor { get; set; }

        [StringLength(6)]
        public string FtColor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
