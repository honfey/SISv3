//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISv3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enrollment()
        {
            this.Result = new HashSet<Result>();
        }
    
        public int Id { get; set; }
        public Nullable<int> StudentId { get; set; }
        public string MatrixNo { get; set; }
        public string MatrixStatus { get; set; }
        public Nullable<int> PackageId { get; set; }
        public Nullable<System.DateTime> DateEnrollment { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EstimateEndDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Package Package { get; set; }
        public virtual Student Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Result { get; set; }
    }
}
