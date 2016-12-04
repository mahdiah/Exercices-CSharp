using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Cette classe s'occupe de tout ce qui concerne le sapin
    /// </summary>
    public class Sapin
    {
        const int TAILLEPIED = 3;
        public string[] mySapin;
       

        public Sapin(string[] sapin)
        {
            mySapin = sapin;
        }

        /// <summary>
        /// Cette methode genere un sapain
        /// </summary>
        /// <returns>Tableau de string contenant le sapin  généré..</returns>
        public string[] generer()
        {
            genererCorps(mySapin.Length - 3);

            int indexCourant = mySapin.Length - 3;
            genererPied(indexCourant);

            return mySapin;
        }

        private void genererPied(int indexCourant)
        {
            for (int ligne = 0; ligne < TAILLEPIED; ligne++)
            {
                string piedSapin = "";
                for (int nbreEspaces = 0; nbreEspaces < mySapin.Length - 5; nbreEspaces++)
                {
                    // Console.Write(" ");
                    piedSapin += " ";
                }
                for (int nbreEtoiles = 0; nbreEtoiles < TAILLEPIED; nbreEtoiles++)
                {
                    //Console.Write("*");
                    piedSapin += "*";
                }
                mySapin[indexCourant] = piedSapin;
                indexCourant++;
            }

           
        }

        private void genererCorps(int tailleSapin)
        {
            for (int ligne = 0; ligne < tailleSapin; ligne++)
            {
                string ligneSapin = "";
                for (int nbreEspace = tailleSapin - 1 ; nbreEspace > ligne; nbreEspace--)
                {
                    ligneSapin += " ";
                }
                for (int nbreEtoiles = 0; nbreEtoiles <= ligne * 2; nbreEtoiles++)
                {
                    if (ligne % 2 == 0 && (nbreEtoiles == 0 || nbreEtoiles == ligne * 2)) { ligneSapin += "i"; }
                    else { ligneSapin += "*"; }

                }
                mySapin[ligne] = ligneSapin;
            }
        }
    }
}
