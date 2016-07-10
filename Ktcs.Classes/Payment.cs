namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Payment")]
    public partial class Payment
    {
        public int PaymentID { get; set; }

        [Column(TypeName = "money")]
        public decimal PayAmount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PayDate { get; set; }

        public int ConfirmationNum { get; set; }
    }
}
