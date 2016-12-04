using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace VigenereConsole
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string texteClair = null;
            string key = null;
            string texteChiffre = null;

            Console.WriteLine("Quelle phrase voulez-vous encoder :");
            texteClair = Console.ReadLine();
            Console.WriteLine("Entrez votre clef :");
            key = Console.ReadLine();

            Vigenere vigenere = new Vigenere();
            texteChiffre = vigenere.Encrypt(texteClair, key);
           
            Console.WriteLine("\nTexte en claire : " + texteClair);
            Console.WriteLine("Cléf : "+key + "  " )    ;
            Console.WriteLine("Texte chiffré : " + texteChiffre);

            texteClair = vigenere.Decrypt(texteChiffre, key);

            Console.WriteLine("\nTexte chiffré : " + texteChiffre);
            Console.WriteLine("Cléf : " + key + "  ");
            Console.WriteLine("Texte claire : " + texteClair);

            Console.Read();
        }

       
    }
}
 