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
    
    public partial class uspGroupMeetingLookup_Result
    {
        public int GroupMeetingID { get; set; }
        public System.DateTime MeetingDate { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Reason { get; set; }
        public bool IsConducted { get; set; }
        public bool IsSplMeeting { get; set; }
        public Nullable<int> MembersCount { get; set; }
        public string StatusCode { get; set; }
        public string Status { get; set; }
    }
}
