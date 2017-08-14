﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class JournalLookupDto
    {
        public long AccountMasterID { get; set; }
        public string VoucherNumber { get; set; }
        public string AHName { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public string StatusCode { get; set; }
        public string Status { get; set; }
    }
}
