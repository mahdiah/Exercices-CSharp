using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Bank
{
    public class Log
    {
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }

        public Log(decimal pAmount)
        {
            this.Date = DateTime.UtcNow;
            this.Amount = pAmount;
        }
    }
}
