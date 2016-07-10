namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Course_CourseTypeDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string coursenumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int coursetypedetailid { get; set; }
    }
}
