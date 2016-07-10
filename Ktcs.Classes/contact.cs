namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("contact")]
    public partial class contact
    {
        public int contactID { get; set; }

        public int vendorid { get; set; }

        [StringLength(75)]
        public string contitle { get; set; }

        [StringLength(30)]
        public string conFName { get; set; }

        [Required]
        [StringLength(35)]
        public string conLName { get; set; }

        [StringLength(75)]
        public string conaddress { get; set; }

        [StringLength(30)]
        public string concity { get; set; }

        [StringLength(2)]
        public string constate { get; set; }

        [StringLength(12)]
        public string conzip { get; set; }

        [StringLength(20)]
        public string conphone { get; set; }

        [StringLength(20)]
        public string conphone2 { get; set; }

        [StringLength(60)]
        public string conemail { get; set; }

        [StringLength(60)]
        public string conemail2 { get; set; }

        [StringLength(20)]
        public string confax { get; set; }

        [StringLength(30)]
        public string concountry { get; set; }

        [StringLength(15)]
        public string conext1 { get; set; }

        [StringLength(15)]
        public string conext2 { get; set; }
    }
}
