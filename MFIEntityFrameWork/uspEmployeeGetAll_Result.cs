//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFIEntityFrameWork
{
    using System;
    
    public partial class uspEmployeeGetAll_Result
    {
        public int EmployeeID { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeRefCode { get; set; }
        public string SurName { get; set; }
        public string TESurName { get; set; }
        public string EmployeeName { get; set; }
        public string TEEmployeeName { get; set; }
        public string Photo { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<int> ClusterID { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<int> EducationQualification { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> Designation { get; set; }
        public Nullable<System.DateTime> DesignationFromDate { get; set; }
        public Nullable<System.DateTime> DesignationToDate { get; set; }
        public Nullable<bool> Disability { get; set; }
        public Nullable<int> BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public Nullable<int> SocialCategory { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string NomineeName { get; set; }
        public Nullable<int> NomineeRelationship { get; set; }
        public string ParentGuardianName { get; set; }
        public Nullable<int> ParentGuardianRelationship { get; set; }
        public Nullable<int> FamilyIncome { get; set; }
        public Nullable<byte> EarningMembersInFamily { get; set; }
        public Nullable<byte> NonEarningMembersInFamily { get; set; }
        public Nullable<decimal> AssetsInNameOfEmployee { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
