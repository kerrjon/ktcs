//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace Ktcs.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TopicCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicCategory()
        {
            this.Courses = new HashSet<Course>();
        }

        [DisplayName("Topic Category")]
        public string topicCategory1 { get; set; }
        public int topicCategoryID { get; set; }
        public Nullable<int> topicId { get; set; }
    
        public virtual Topic Topic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}