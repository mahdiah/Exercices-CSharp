using System;
using System.Windows.Forms;
using BLL;

namespace WUI
{
    public partial class Form1 : Form
    {
        const int TAILLEPIED = 3;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            
            listBox1.Items.Clear();

            int tailleSapin =Convert.ToInt32( numericUpDown1.Value);
            string[] mySapin = new string[tailleSapin+3];

            Sapin sapin = new Sapin(mySapin);


            mySapin = sapin.generer();

            foreach (string ligne in mySapin)
            {
                listBox1.Items.Add(ligne);
            }

            /// LA GENERATION DU SAPIN SE FAISAIT ICI.. 
            
            //for (int ligne = 0; ligne < tailleSapin; ligne++)
            //{
            //    string ligneSapin = "";
            //    for (int nbreEspace = tailleSapin; nbreEspace > ligne; nbreEspace--)
            //    {
            //        ligneSapin += " ";
            //    }
            //    for (int nbreEtoiles = 0; nbreEtoiles <= ligne*2; nbreEtoiles++)
            //    {
            //        if(ligne % 2 == 0 && (nbreEtoiles == 0 || nbreEtoiles == ligne*2)) { ligneSapin += "i"; }
            //        else { ligneSapin += "*"; }
                    
            //    }
            //    listBox1.Items.Add(ligneSapin);
            //}
           

            //for (int ligne = 0; ligne < TAILLEPIED; ligne++)
            //{
            //    string piedSapin = "";
            //    for (int nbreEspaces = 0; nbreEspaces < tailleSapin - 1; nbreEspaces++)
            //    {
            //       // Console.Write(" ");
            //        piedSapin += " ";
            //    }
            //    for (int nbreEtoiles = 0; nbreEtoiles < TAILLEPIED; nbreEtoiles++)
            //    {
            //        //Console.Write("*");
            //        piedSapin += "*";
            //    }
            //    listBox1.Items.Add(piedSapin);
            //}
        }

    }
}
