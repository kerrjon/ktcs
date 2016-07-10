namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Expense")]
    public partial class Expense
    {
        public int ExpenseID { get; set; }

        public int VendorID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Cost { get; set; }

        public int? Qty { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public int? ExpenseTypeID { get; set; }

        public int? ScheduledClassID { get; set; }

        [StringLength(10)]
        public string VenInvoiceNum { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VenInvoiceDate { get; set; }

        [StringLength(3)]
        public string VenInvoicePaid { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Tax { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Shipping { get; set; }

        public virtual ExpenseType ExpenseType { get; set; }
    }
}
