namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Income")]
    public partial class Income
    {
        public int IncomeID { get; set; }

        public int CompanyID { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Cost { get; set; }

        public int? Qty { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public int? IncomeTypeID { get; set; }

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
    }
}
