namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ComContact")]
    public partial class ComContact
    {
        public int ComContactID { get; set; }

        public int CompanyID { get; set; }

        [StringLength(75)]
        public string ComConTitle { get; set; }

        [StringLength(30)]
        public string ComConFName { get; set; }

        [Required]
        [StringLength(35)]
        public string ComConLName { get; set; }

        [StringLength(75)]
        public string ComConAddress { get; set; }

        [StringLength(75)]
        public string ComConAddress2 { get; set; }

        [StringLength(30)]
        public string ComConCity { get; set; }

        [StringLength(2)]
        public string ComConState { get; set; }

        [StringLength(12)]
        public string ComConZip { get; set; }

        [StringLength(20)]
        public string ComConPhone { get; set; }

        [StringLength(20)]
        public string ComConPhone2 { get; set; }

        [StringLength(60)]
        public string ComConEmail { get; set; }

        [StringLength(60)]
        public string ComConEmail2 { get; set; }

        [StringLength(20)]
        public string ComConFax { get; set; }

        [StringLength(30)]
        public string ComConCountry { get; set; }
    }
}
