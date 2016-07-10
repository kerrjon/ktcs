namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Location")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
        }

        public int LocationID { get; set; }

        [StringLength(75)]
        public string locaddress { get; set; }

        [Required]
        [StringLength(30)]
        public string loccity { get; set; }

        [Required]
        [StringLength(2)]
        public string locstate { get; set; }

        [StringLength(12)]
        public string loczip { get; set; }

        [StringLength(300)]
        public string locnotes { get; set; }

        [Required]
        [StringLength(75)]
        public string locName { get; set; }

        public int? VendorID { get; set; }

        [StringLength(75)]
        public string locmapLink { get; set; }

        [StringLength(20)]
        public string locphone { get; set; }

        [StringLength(30)]
        public string loccountry { get; set; }

        public virtual vendor vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
