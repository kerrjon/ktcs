namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryFormat")]
    public partial class DeliveryFormat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryFormat()
        {
            Courses = new HashSet<Course>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeliveryFormatId { get; set; }

        [Column("DeliveryFormat")]
        [StringLength(50)]
        public string DeliveryFormat1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
