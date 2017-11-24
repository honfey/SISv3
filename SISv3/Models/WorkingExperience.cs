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
    
    public partial class WorkingExperience
    {
        public int Id { get; set; }
        public int TrainerId { get; set; }
        public string Company { get; set; }
        public Nullable<int> YearId { get; set; }
        public Nullable<int> JoinedMonth { get; set; }
        public string PositionLevel { get; set; }
        public string ExperienceDescription { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Trainer Trainer { get; set; }
        public virtual Year Year { get; set; }
    }
}