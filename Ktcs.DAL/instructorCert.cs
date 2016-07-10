namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("instructorCert")]
    public partial class instructorCert
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string insCertification { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string instructorID { get; set; }
    }
}
