namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ScheduledClass")]
    public partial class ScheduledClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScheduledClass()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int ScheduledClassID { get; set; }

        [Required]
        [StringLength(10)]
        public string courseNumber { get; set; }

        public DateTime? startDate { get; set; }

        public DateTime? endDate { get; set; }

        [StringLength(50)]
        public string startTime { get; set; }

        [StringLength(50)]
        public string endTime { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Price { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? MarketRate { get; set; }

        [Required]
        [StringLength(3)]
        public string ispublic { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? KTCSRate { get; set; }

        [StringLength(3)]
        public string KTCScourse { get; set; }

        [StringLength(3)]
        public string startDateconfirmed { get; set; }

        [StringLength(3)]
        public string bookOrderMade { get; set; }

        [StringLength(3)]
        public string insTestReminder { get; set; }

        [StringLength(3)]
        public string bookOrderRecieved { get; set; }

        [StringLength(3)]
        public string insconfirmed { get; set; }

        [StringLength(3)]
        public string locconfirmed { get; set; }

        public short? MaxStudents { get; set; }

        public int locationID { get; set; }

        [StringLength(10)]
        public string InstructorID { get; set; }

        public int CompanyID { get; set; }

        public int SurveyID { get; set; }

        [StringLength(50)]
        public string Mirrored { get; set; }

        [StringLength(100)]
        public string MirroredWebsite { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual Location Location { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
