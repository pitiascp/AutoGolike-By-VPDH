//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class FBAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FBAccount()
        {
            this.Jobs = new HashSet<Job>();
        }
    
        public long fbID { get; set; }
        public long fbUid { get; set; }
        public string fbPass { get; set; }
        public string C2fa { get; set; }
        public string status { get; set; }
        public string tinhTrang { get; set; }
        public string ghiChu { get; set; }
        public long glID { get; set; }
    
        public virtual GLAccount GLAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
