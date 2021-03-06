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
    using System.Collections.Generic;
    
    public partial class AccountMaster
    {
        public AccountMaster()
        {
            this.AccountTransactions = new HashSet<AccountTransaction>();
        }
    
        public long AccountMasterID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public long CodeSno { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherRefNumber { get; set; }
        public string PartyName { get; set; }
        public int EmployeeID { get; set; }
        public int AHID { get; set; }
        public Nullable<int> SubHeadID { get; set; }
        public int TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string TransactionMode { get; set; }
        public string ChequeNumber { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public Nullable<int> BankAccount { get; set; }
        public string Narration { get; set; }
        public int StatusID { get; set; }
        public bool IsGroup { get; set; }
        public Nullable<int> GroupID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> LoanRepaymentID { get; set; }
        public Nullable<bool> IsPairedRecord { get; set; }
        public Nullable<int> LoanMasterID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> DepositId { get; set; }
    
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; }
        public virtual RefValueMaster RefValueMaster { get; set; }
        public virtual AccountHead AccountHead { get; set; }
        public virtual AccountHead AccountHead1 { get; set; }
    }
}
