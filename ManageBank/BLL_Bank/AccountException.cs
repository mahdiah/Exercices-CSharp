using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Bank
{
    public class AccountException : Exception
    {
        public decimal Amount { get; set; }

        public AccountException(decimal pAmount,string pMessage):base(pMessage)
        {
            this.Amount = pAmount;
        }
    }
}
