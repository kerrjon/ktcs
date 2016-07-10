namespace Ktcs.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("student")]
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            Enrollments = new HashSet<Enrollment>();
            WaitLists = new HashSet<WaitList>();
        }

        public int StudentID { get; set; }

        [Required]
        [StringLength(35)]
        public string stuLName { get; set; }

        [StringLength(30)]
        public string stuFName { get; set; }

        [StringLength(75)]
        public string stuEmail { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [StringLength(20)]
        public string stuHomePhone { get; set; }

        [StringLength(2)]
        public string stuInternationalCode { get; set; }

        [StringLength(70)]
        public string stuProductArea { get; set; }

        public int ManagerID { get; set; }

        public int CompanyID { get; set; }

        [StringLength(10)]
        public string stupassword { get; set; }

        public int authorityID { get; set; }

        [StringLength(20)]
        public string stuWorkPhone { get; set; }

        [StringLength(30)]
        public string stuCountry { get; set; }

        [StringLength(70)]
        public string stuJobTitle { get; set; }

        [StringLength(30)]
        public string stuCity { get; set; }

        [StringLength(2)]
        public string stustate { get; set; }

        [StringLength(75)]
        public string stuaddress { get; set; }

        [StringLength(75)]
        public string stuaddress2 { get; set; }

        [StringLength(12)]
        public string stuzip { get; set; }

        public int? ReferredByID { get; set; }

        [StringLength(20)]
        public string stufax { get; set; }

        [StringLength(15)]
        public string CostCenter { get; set; }

        [StringLength(75)]
        public string BillName { get; set; }

        [StringLength(75)]
        public string BillAddress { get; set; }

        [StringLength(75)]
        public string BillAddress2 { get; set; }

        [StringLength(30)]
        public string BillCity { get; set; }

        [StringLength(2)]
        public string BillState { get; set; }

        [StringLength(12)]
        public string BillZip { get; set; }

        [StringLength(30)]
        public string BillCountry { get; set; }

        [StringLength(20)]
        public string BillPhone { get; set; }

        [StringLength(20)]
        public string BillFax { get; set; }

        [StringLength(75)]
        public string BillEmail { get; set; }

        [StringLength(2)]
        public string BillInternationalCode { get; set; }

        [StringLength(60)]
        public string OtherCompany { get; set; }

        [StringLength(60)]
        public string OtherReferredBy { get; set; }

        [StringLength(60)]
        public string OtherManager { get; set; }

        [StringLength(20)]
        public string OtherManagerPhone { get; set; }

        [StringLength(3)]
        public string mailList { get; set; }

        [StringLength(10)]
        public string UserID { get; set; }

        public byte? ClassesTaken { get; set; }

        [StringLength(3)]
        public string blockReminder { get; set; }

        [StringLength(75)]
        public string other { get; set; }

        [StringLength(3)]
        public string stuarchived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WaitList> WaitLists { get; set; }
    }
}
