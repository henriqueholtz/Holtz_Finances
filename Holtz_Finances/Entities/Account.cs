using Holtz_Finances.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Finances.Entities
{
    public class Account
    {
        public int AccountCode { get; set; }
        public DateTime AccountCreatedDate { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime AccountLastMove { get; set; }
        public Status_ActiveInactive AccountStatus { get; set; }
    }
}
