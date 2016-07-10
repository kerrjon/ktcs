namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("company")]
    public partial class company
    {
        public int CompanyID { get; set; }

        [Required]
        [StringLength(75)]
        public string comName { get; set; }

        [StringLength(75)]
        public string comAddress { get; set; }

        [StringLength(75)]
        public string comAddress2 { get; set; }

        [StringLength(30)]
        public string comCity { get; set; }

        [StringLength(2)]
        public string comState { get; set; }

        [StringLength(12)]
        public string comZip { get; set; }

        [StringLength(30)]
        public string comcountry { get; set; }

        [StringLength(20)]
        public string comphone { get; set; }

        [StringLength(20)]
        public string comfax { get; set; }

        [StringLength(75)]
        public string comMapLink { get; set; }

        [StringLength(50)]
        public string billname { get; set; }

        [StringLength(75)]
        public string billaddress { get; set; }

        [StringLength(75)]
        public string billaddress2 { get; set; }

        [StringLength(30)]
        public string billcity { get; set; }

        [StringLength(2)]
        public string billstate { get; set; }

        [StringLength(12)]
        public string billzip { get; set; }

        [StringLength(20)]
        public string billphone { get; set; }

        [StringLength(20)]
        public string billfax { get; set; }

        [StringLength(50)]
        public string billcountry { get; set; }

        [StringLength(75)]
        public string logo { get; set; }

        [StringLength(75)]
        public string billemail { get; set; }
    }
}
