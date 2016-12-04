using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] nombresPremiers = null;
          
          
            Console.Write("Nombres premiers jusqu' à  combien : \n");
            int taille = Convert.ToInt32(Console.ReadLine());
           // nombresPremiers = new bool[taille+1];
            Eratostene era = new Eratostene(taille);
            try
            {
                nombresPremiers = era.crible();
                Console.WriteLine("Les nombres premiers inférieurs ou égales à {0} sont :", taille);
                for (int j = 0; j < nombresPremiers.Length; j++)
                {
                    Console.Write((nombresPremiers[j] == true) ? j + "\t" : "");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); 
                
            }

           

            Console.Read();

        }


       
    }

   

}
