using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace WindowsEratostene
{
    public partial class EratosteneForm : Form
    {
        private int nombreLimite;
        public Eratostene era;
        public EratosteneForm()
        {
            InitializeComponent();
            era = new Eratostene();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreLimite = Convert.ToInt32(textBox1.Text);
            bool[] nombresPremiers = null;
            listBox1.Items.Clear();
            listBox1.MultiColumn = true;
            Eratostene era = new Eratostene(nombreLimite);
            try
            {
                nombresPremiers = era.crible();
                for (int x = 1; x <= nombreLimite; x++)
                {
                    listBox1.Items.Add((nombresPremiers[x] == true) ? x.ToString() : "X");
                    if (nombresPremiers[x] == true)
                    {
                        listBox1.SetSelected(x - 1, true);
                    }
                }
            }
            catch (Exception ex)
            {

                listBox1.Items.Add(ex.Message);
                
            }



         
         
           

        }

        private void btnJumeaux_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Eratostene era = new Eratostene(nombreLimite);
            List<Jumeaux> listeJumeaux = era.getJumeaux();
            foreach (Jumeaux j in listeJumeaux)
            {
                listBox1.Items.Add(j.ToString());
                listBox1.Items.Add("\n");
            }
        }
    }
}
