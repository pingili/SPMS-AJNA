﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFIS.Web.Areas.Federation.Models
{
    public class AccountHeadModel
    {
        public int AHID { get; set; }
        public int EditAHID { get; set; }
        public int ParentMoveAHID { get; set; }
        public string AHCode { get; set; }
        public string AHName { get; set; }
        public string SubGroupAHCode { get; set; }
        public string SubGroupAHName { get; set; }
        public string SubGroupTEAHName { get; set; }
        public string TE_AHName { get; set; }
        public int AHType { get; set; }
        public int ParentAHID { get; set; }
        public bool IsMemberTransaction { get; set; }
        //IsMemberTransaction
        public bool IsSLAccount { get; set; }
        //IsSLAccount
        public string OpeningBalanceType { get; set; }
        public int AHLevel { get; set; }
        public bool IsFederation { get; set; }
        public int StatusID { get; set; }
        public int UserID { get; set; }
        public string AHIDS { get; set; }
        public decimal CurrentYearBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public decimal OpeningBalance { get; set; }
    }
}