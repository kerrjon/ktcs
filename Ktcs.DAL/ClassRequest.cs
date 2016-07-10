namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassRequest")]
    public partial class ClassRequest
    {
        [Key]
        public int RequestID { get; set; }

        public int StudentID { get; set; }

        public int ScheduledClassID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApprovalSent { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApprovalReceived { get; set; }

        [StringLength(3)]
        public string Denied { get; set; }

        [StringLength(3)]
        public string Withdrew { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Enrolled { get; set; }

        [StringLength(255)]
        public string WithdrawReason { get; set; }
    }
}
