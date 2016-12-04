using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suite
{
    public class SuiteFibo
    {
        public List<long>Suite(int number)
        {
            if (number < 0)
            {
                throw new FibonacciException(number, "Nombre négatif, impossible de continuer");
            }
            if (number < 2)
            {
                throw new FibonacciException(number, "Impossible de produire une suite ayant si peu de nombres");
            }
            List<long> suite = new List<long>();
            suite.Capacity = number;
            suite.Add(0);
            suite.Add(1);
            for (int position = 2;  position < number; position++)
            {
                suite.Add(suite[position - 1] + suite[position - 2]);
            }
            return suite;
        }
        public double GoldNumber(int number)
        {
            if (number<3)
            {
                throw new FibonacciException(number, "Il est impossible de calculer un nombre d'Or avec si peu d'élements");
            }
            List<long> fibo = new List<long>();
            fibo = Suite(number);
            double goldNumber = (fibo[number - 1]*1.0) / (fibo[number - 2]*1.0);
            return goldNumber;
        } 
    }
}
