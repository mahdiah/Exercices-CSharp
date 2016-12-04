using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Bank
{
    public class Account
    {
        private static long actualNumber = 123;
        public decimal Balance { get; private set; }
        public long Number { get; private set; }
        public string Owner { get; private set; }
        public AccountType Type { get; private set; }
        public Queue<Log> History { get; set; }

        //public Log this[int index]
        //{
        //    get
        //    {

        //    }

        //}

        public Account(string pOwner)
        {
            this.Balance = 0m;
            this.Number = Account.actualNumber++;
            this.Owner = pOwner;
            this.Type = AccountType.Current;
        }

        

        public decimal Deposit(decimal pAmount)
        {
            NegativeGuardTest(pAmount);
            Balance += pAmount;
            Archive(pAmount);
            return Balance;
        }


        public bool Withdraw(decimal pAmount)
        {
            NegativeGuardTest(pAmount);
            bool result = pAmount <= this.Balance;
            if (result)
            {
                Balance -= pAmount;
                Archive(-pAmount);
            }

            return result;
        }

        private static void NegativeGuardTest(decimal pAmount)
        {
            if (pAmount < 0)
            {
                throw new AccountException(pAmount, "Pas de montant négatif SVP !");
            }
        }

        private void Archive(decimal pAmount)
        {
            this.History.Enqueue(new Log(pAmount));
        }
    }
}
