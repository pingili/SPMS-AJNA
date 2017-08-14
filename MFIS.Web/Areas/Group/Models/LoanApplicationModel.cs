﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFIS.Web.Areas.Group.Models
{
    public class LoanApplicationModel
    {

        public int LoanMasterId { get; set; }
        public string LoanCode { get; set; }
        public string LoanType { get; set; }
        public int MemberID { get; set; }
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string VillageCode { get; set; }
        public string VillageName { get; set; }
        public string ClusterCode { get; set; }
        public string ClusterName { get; set; }
        public DateTime LoanApplicationDate { get; set; }
        public int LoanPurpose { get; set; }
        public decimal LoanAmountApplied { get; set; }
        public byte NoofInstallmentsProposed { get; set; }
        public int Mode { get; set; }
        public int UserID { get; set; }
    }
}