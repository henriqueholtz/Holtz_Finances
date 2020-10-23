using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Finances.Entities
{
    public class Bank
    {
        public int BankCode { get; set; }
        public int BankName { get; set; }
        public int BankCodeId { get; set; } //Codigo identificação exemplo Banco do Brasil = 001
    }
}
