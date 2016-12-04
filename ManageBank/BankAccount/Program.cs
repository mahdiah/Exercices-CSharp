using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Bank;
namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myTime = DateTime.Now;
            ulong uTime = Convert.ToUInt64(myTime.Ticks);

            Console.WriteLine("Time en ULONG :" + uTime); ;

            Account mahdi = new Account("mahdi");
            mahdi.Deposit(1000);
            mahdi.Deposit(300);
            mahdi.Withdraw(700);

            Account dany = new Account("dany");
            dany.Deposit(100);
            dany.Deposit(300);
            dany.Withdraw(200);


            Console.WriteLine($"{mahdi.Number} - {mahdi.Owner}\t{mahdi.Type}\t{mahdi.Balance}");
            Console.WriteLine($"{dany.Number} - {dany.Owner}\t {dany.Type}\t{dany.Balance}");

            Console.Read();
        }
    }
}
