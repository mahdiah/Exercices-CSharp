using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationnalLibrary
{
    public class Rationnal
    {
        //= PARTIE STATIQUE
        static public int CalculerPGCD(int pNombre1, int pNombre2)
        {
            int nombre1 = Math.Abs(pNombre1);
            int nombre2 = Math.Abs(pNombre2);
            if (nombre1 == 0 && nombre2 == 0)
                throw new ArgumentOutOfRangeException
                          ("nombre1 et nombre2",
                           "Les deux nombres ne peuvent pas être nuls");
            if (nombre1 * nombre2 == 0)
                nombre1 = Math.Max(nombre1, nombre2);
            else
                while (nombre1 != nombre2)
                    if (nombre1 > nombre2)
                        nombre1 -= nombre2;
                    else
                        nombre2 -= nombre1;
            return nombre1;
        }

        static public Rationnal operator +(Rationnal rat1, Rationnal rat2)
        {
            return new Rationnal(rat1.numérateur * rat2.dénominateur
                               + rat1.dénominateur * rat2.numérateur,
                                  rat1.dénominateur * rat2.dénominateur);
        }

        static public Rationnal operator -(Rationnal rat)
        {
            return new Rationnal(-rat.numérateur, rat.dénominateur);
        }

        static public Rationnal operator -(Rationnal rat1, Rationnal rat2)
        {
            return rat1 + (-rat2);
        }

        static public Rationnal operator *(Rationnal rat1, Rationnal rat2)
        {
            return new Rationnal(rat1.numérateur * rat2.numérateur,
                                 rat1.dénominateur * rat2.dénominateur);
        }

        static public Rationnal operator /(Rationnal rat1, Rationnal rat2)
        {
            return new Rationnal(rat1.numérateur * rat2.dénominateur,
                                 rat1.dénominateur * rat2.numérateur);
        }


        //= PARTIE  NON STATIQUE
        private int numérateur;

        private int dénominateur;

        public int Numérateur
        {
            get { return numérateur; }
            set
            {
                numérateur = value;
                this.Normalise();
            }
        }

        public int Dénominateur
        {   
            get { return dénominateur; }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("Dénominateur null interdit");
                this.dénominateur = value;
                this.Normalise();
            }
        }

        private void Normalise()
        {
            if (this.dénominateur < 0)
            {
                this.numérateur *= -1;
                this.dénominateur *= -1;
            }
            int pgcd = Rationnal.CalculerPGCD(this.numérateur,
                                              this.dénominateur);
            this.numérateur /= pgcd;
            this.dénominateur /= pgcd;
        }

        public Rationnal(int pNumérateur):this(pNumérateur,1)
        {  }

        public Rationnal(int pNumérateur, int pDénominateur)
        {
            if (pDénominateur == 0)
                throw new DivideByZeroException
                              ("Dénominateur nul interdit");
            this.numérateur = pNumérateur;
            this.dénominateur = pDénominateur;
            this.Normalise();
        }

        public override string ToString()
        {
            return (this.dénominateur != 1) ? this.numérateur.ToString() + "/" + this.dénominateur.ToString() : this.numérateur.ToString();
        }
    }
}
