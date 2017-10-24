//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTL.Models
{
    using System;
    
    public partial class GetUserInfo_Result
    {
        public System.Guid UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public System.DateTime LastLockoutDate { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public System.DateTime LastPasswordChangedDate { get; set; }
        public Nullable<bool> LoginChangePassword { get; set; }
        public string TemporaryPIN { get; set; }
        public Nullable<int> SecurityQuestionID { get; set; }
        public Nullable<bool> PowerUser { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> NewApproved { get; set; }
        public Nullable<bool> SiteApproved { get; set; }
        public Nullable<bool> Confidentiality { get; set; }
        public Nullable<System.DateTime> DateConfidentiality { get; set; }
        public string SiteAccess { get; set; }
        public string ProgramAccess { get; set; }
    }
}