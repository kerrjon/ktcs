namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("StudentDistribution")]
    public partial class StudentDistribution
    {
        public int StudentDistributionID { get; set; }

        public int StudentID { get; set; }

        public int DistributionID { get; set; }

        [Required]
        [StringLength(20)]
        public string ExamStatus { get; set; }

        public DateTime? startTime { get; set; }

        public DateTime? EndTime { get; set; }
    }
}
