namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class StudentCertification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        public int CertificationID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ExpireDate { get; set; }
    }
}
