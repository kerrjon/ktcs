namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int NewsID { get; set; }

        [Required]
        [StringLength(120)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Body { get; set; }

        [Required]
        [StringLength(3)]
        public string Visible { get; set; }

        [StringLength(75)]
        public string Source { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NewsDate { get; set; }
    }
}
