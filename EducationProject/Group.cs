//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public int GroupId { get; set; }
        public int PackageId { get; set; }
        public int TeacherId { get; set; }
        public int MentorId { get; set; }
        public int GroupCategoryId { get; set; }
        public Nullable<System.DateTime> GroupStartDate { get; set; }
        public string GroupName { get; set; }
        public string GroupEmail { get; set; }
    }
}
