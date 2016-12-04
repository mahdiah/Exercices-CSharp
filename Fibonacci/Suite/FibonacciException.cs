using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suite
{
    public class FibonacciException : Exception
    {
        public int Number { get; set; }
        public FibonacciException(int pNumber, string pMessage) : base(pMessage)
        {
            Number = pNumber;
        }
    }
}
