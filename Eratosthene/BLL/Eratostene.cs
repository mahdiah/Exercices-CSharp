using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class Eratostene
    {
        public int taille { get; private set; }
        private bool[] nombresPremier;


        public Eratostene():this(10)
        {

        }
        public Eratostene(int taille)
        {
            this.taille = taille;
            nombresPremier = new bool[taille + 1];
        }

        public  bool[] crible( )
        {
            if(taille < 0)
            {
                throw new Exception("Nous n'acceptons pas de nombre négative pour la taille");
            }

           // bool[] nombresPremier = new bool[taille + 1];
            int racine = Convert.ToInt32(Math.Truncate(Math.Sqrt(taille)));

            //Initialisation du tableau 

            for (int i = 2; i < nombresPremier.Length; i++)
            {
                nombresPremier[i] = true;
            }

            for (int j = 2; j <= racine; j++)
            {
                if (nombresPremier[j])
                {
                    for (int k = j + j; k < nombresPremier.Length; k += j)
                    {
                        nombresPremier[k] = false;
                    }
                }
            }
            return this.nombresPremier;
        }

        public List<Jumeaux> getJumeaux()
        {
            List<Jumeaux> listeJumeaux = new List<Jumeaux>();
            for (int i = 2; i < nombresPremier.Length - 1; i++)
            {
                if(nombresPremier[i] && nombresPremier[i+1] )
                {
                    listeJumeaux.Add(new Jumeaux(i, i + 1));
                }
            }

            return listeJumeaux;
        }
    }
}
