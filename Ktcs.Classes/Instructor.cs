namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Instructor")]
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            ScheduledClasses = new HashSet<ScheduledClass>();
        }

        [StringLength(10)]
        public string InstructorID { get; set; }

        [StringLength(30)]
        public string insfname { get; set; }

        [Required]
        [StringLength(35)]
        public string inslname { get; set; }

        [StringLength(75)]
        public string insaddress { get; set; }

        [StringLength(30)]
        public string inscity { get; set; }

        [StringLength(2)]
        public string insstate { get; set; }

        [StringLength(12)]
        public string inszip { get; set; }

        [StringLength(20)]
        public string insphone { get; set; }

        [StringLength(20)]
        public string insphone2 { get; set; }

        [StringLength(60)]
        public string insemail { get; set; }

        [StringLength(60)]
        public string insemail2 { get; set; }

        [StringLength(20)]
        public string insfax { get; set; }

        [StringLength(30)]
        public string inscountry { get; set; }

        public int VendorID { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [StringLength(50)]
        public string insIndependent { get; set; }

        [StringLength(50)]
        public string insReferredBy { get; set; }

        [StringLength(200)]
        public string Keywords { get; set; }

        [StringLength(7000)]
        public string resumeText { get; set; }

        [StringLength(50)]
        public string Skill1 { get; set; }

        [StringLength(50)]
        public string Skill2 { get; set; }

        [StringLength(50)]
        public string Skill3 { get; set; }

        [StringLength(50)]
        public string Skill4 { get; set; }

        [StringLength(50)]
        public string Skill5 { get; set; }

        [StringLength(50)]
        public string Category1 { get; set; }

        [StringLength(50)]
        public string Category2 { get; set; }

        [StringLength(50)]
        public string Category3 { get; set; }

        [StringLength(2000)]
        public string notes { get; set; }

        [StringLength(2000)]
        public string coursewareNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}
