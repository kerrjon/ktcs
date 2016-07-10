namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Promo")]
    public partial class Promo
    {
        [Key]
        public int promotionID { get; set; }

        [Required]
        [StringLength(30)]
        public string promoTitle { get; set; }

        [Required]
        [StringLength(7000)]
        public string promoText { get; set; }

        [Required]
        [StringLength(2000)]
        public string promorules { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime startDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime endDate { get; set; }

        [Required]
        [StringLength(3)]
        public string MajorPromo { get; set; }
    }
}
