using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suite;

namespace WUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de nombres voulez-vous dans la suite de Fibonacci?");
            int number = Convert.ToInt32(Console.ReadLine());
            try
            {
                SuiteFibo sFibo = new SuiteFibo();
                List<long> fibo = sFibo.Suite(number);
                StringBuilder sbFibo = new StringBuilder();
                foreach (var item in fibo)
                {
                    sbFibo.Append("" + item);
                }
                Console.WriteLine("La Suite de Fibonacci est la suivante : " + sbFibo.ToString());
                double goldNumber = sFibo.GoldNumber(number);
                Console.WriteLine("Le nombre d'Or est évalué à  " + goldNumber.ToString());
            }
            catch (FibonacciException fibEx)
            {
                Console.WriteLine(fibEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur inconnue");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
