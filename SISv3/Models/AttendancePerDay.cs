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
    
    public partial class AttendancePerDay
    {
        public int Id { get; set; }
        public Nullable<int> TimetablePerDayId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<System.TimeSpan> M_IN { get; set; }
        public Nullable<System.TimeSpan> M_OUT { get; set; }
        public string M_Status { get; set; }
        public Nullable<System.TimeSpan> A_IN { get; set; }
        public Nullable<System.TimeSpan> A_OUT { get; set; }
        public string A_Status { get; set; }
        public Nullable<int> Total_Marks { get; set; }
        public string Total_Status { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual TimetablePerDay TimetablePerDay { get; set; }
    }
}
