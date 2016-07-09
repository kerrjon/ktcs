//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ktcs.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            this.ScheduledClasses = new HashSet<ScheduledClass>();
        }
    
        public string InstructorID { get; set; }
        public string insfname { get; set; }
        public string inslname { get; set; }
        public string insaddress { get; set; }
        public string inscity { get; set; }
        public string insstate { get; set; }
        public string inszip { get; set; }
        public string insphone { get; set; }
        public string insphone2 { get; set; }
        public string insemail { get; set; }
        public string insemail2 { get; set; }
        public string insfax { get; set; }
        public string inscountry { get; set; }
        public int VendorID { get; set; }
        public string password { get; set; }
        public string insIndependent { get; set; }
        public string insReferredBy { get; set; }
        public string Keywords { get; set; }
        public string resumeText { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public string Skill5 { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string notes { get; set; }
        public string coursewareNotes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledClass> ScheduledClasses { get; set; }
    }
}