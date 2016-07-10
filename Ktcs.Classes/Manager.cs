namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Manager")]
    public partial class Manager
    {
        public int ManagerID { get; set; }

        [StringLength(30)]
        public string mgrFName { get; set; }

        [Required]
        [StringLength(35)]
        public string mgrLName { get; set; }

        [StringLength(20)]
        public string mgrPhone { get; set; }

        [StringLength(60)]
        public string mgrEmail { get; set; }

        [StringLength(20)]
        public string mgrFax { get; set; }
    }
}
