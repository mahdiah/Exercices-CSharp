using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public struct Jumeaux
    {
       
        private readonly int one;
        private readonly int two;

        public Jumeaux(int a, int b)
        {
            this.one = a;
            this.two = b;
        }

        public int One
        {
            get { return one; }  
        }
        public int Two
        {
            get { return two; }
        }


        public override string ToString()
        {
            return $"{one.ToString()} {two.ToString()}"; 
        }
    }
}
