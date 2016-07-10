namespace Ktcs.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [StringLength(25)]
        public string UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(75)]
        public string adminemail { get; set; }

        [Required]
        [StringLength(3)]
        public string AdminInitials { get; set; }

        [Required]
        [StringLength(30)]
        public string AdminFName { get; set; }

        [Required]
        [StringLength(30)]
        public string AdminLName { get; set; }

        [StringLength(20)]
        public string AdminPhone { get; set; }

        [StringLength(75)]
        public string AdminWebsite { get; set; }

        [StringLength(20)]
        public string AdminFax { get; set; }

        [StringLength(75)]
        public string AdminCompany { get; set; }

        [Required]
        [StringLength(3)]
        public string SysAdmin { get; set; }

        public int? CompanyID { get; set; }

        public int ReportDateRange { get; set; }
    }
}
