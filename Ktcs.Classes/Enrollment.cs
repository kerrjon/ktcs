namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Enrollment
    {
        [Key]
        public int ConfirmationNum { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Enrolled { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Confirmation { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Reminder { get; set; }

        [Column(TypeName = "money")]
        public decimal? Paid { get; set; }

        [StringLength(10)]
        public string invoice { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MTSfee { get; set; }

        public int statusID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amountdue { get; set; }

        public int StudentID { get; set; }

        public int ScheduledClassID { get; set; }

        [StringLength(10)]
        public string cancellationNum { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? cancellationDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dateDue { get; set; }

        [StringLength(3)]
        public string mgrConfirmation { get; set; }

        [StringLength(3)]
        public string conarchived { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountDollars { get; set; }

        public virtual ScheduledClass ScheduledClass { get; set; }

        public virtual Status Status { get; set; }

        public virtual student student { get; set; }
    }
}
