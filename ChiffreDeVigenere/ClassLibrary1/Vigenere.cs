using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class Vigenere
    {
        //Variables
        const string alphabet = "abcdefghijklmnopqrstuvwxyzàéèç";


        public  string Encrypt(string texte, string key)
        { 
            
            string texteChiffre = null;
            short indexDuCaractereClef, indexDuCaractereTexte;
            int offset = 0;

            texte = texte.ToLower().Trim();
            key = key.Trim();

            for (int i = 0; i < texte.Length; i++)
            {
                char caractereChiffre = texte[i];
                if (alphabet.Contains(texte[i]))
                {
                    char caractereDuTexte = texte[i];
                    char caractereDuClef = key[(i - offset) % key.Length];
                    indexDuCaractereTexte = (short)alphabet.IndexOf(caractereDuTexte);
                    indexDuCaractereClef = (short)alphabet.IndexOf(caractereDuClef);
                    if (indexDuCaractereClef + indexDuCaractereTexte >= 30)
                    {
                        caractereChiffre = alphabet[indexDuCaractereClef + indexDuCaractereTexte - 30];
                    }
                    else
                    {
                        caractereChiffre = alphabet[indexDuCaractereClef + indexDuCaractereTexte];
                    }

                }
                else
                {
                    offset++;
                }

                texteChiffre += caractereChiffre;
            }

            return texteChiffre;

        }


        public  string Decrypt(string texteChiffre, string key)
        {
            
            string texteClaire = null;
            short indexDuCaractereClef, indexDuCaractereTexte;
            int offset = 0;

            texteChiffre = texteChiffre.ToLower().Trim();
            key = key.Trim();

            for (int i = 0; i < texteChiffre.Length; i++)
            {
                char caractereChiffre = texteChiffre[i];
                if (alphabet.Contains(texteChiffre[i]))
                {
                    char caractereDuTexte = texteChiffre[i];
                    char caractereDuClef = key[(i - offset) % key.Length];
                    indexDuCaractereTexte = (short)alphabet.IndexOf(caractereDuTexte);
                    indexDuCaractereClef = (short)alphabet.IndexOf(caractereDuClef);
                    if ( indexDuCaractereTexte - indexDuCaractereClef < 0)
                    {
                        caractereChiffre = alphabet[ indexDuCaractereTexte - indexDuCaractereClef + 30];
                    }
                    else
                    {
                        caractereChiffre = alphabet[indexDuCaractereTexte - indexDuCaractereClef];
                    }

                }
                else
                {
                    offset++;
                }

                texteClaire += caractereChiffre;
            }

            return texteClaire;
        }
    }
}
