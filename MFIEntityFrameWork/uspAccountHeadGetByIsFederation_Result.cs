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
    
    public partial class uspAccountHeadGetByIsFederation_Result
    {
        public int AHID { get; set; }
        public string AHCode { get; set; }
        public string AHName { get; set; }
        public string TE_AHName { get; set; }
        public int AHType { get; set; }
        public Nullable<int> ParentAHID { get; set; }
        public bool IsMemberTransaction { get; set; }
        public bool IsSLAccount { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public string OpeningBalanceType { get; set; }
        public int AHLevel { get; set; }
        public bool IsFederation { get; set; }
        public int StatusID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
