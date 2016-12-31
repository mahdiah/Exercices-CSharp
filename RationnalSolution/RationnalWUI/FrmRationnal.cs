using RationnalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RationnalWUI
{
    public partial class FrmRationnal : Form
    {
        public FrmRationnal()
        {
            InitializeComponent();
        }

        private void FrmRationnal_Load(object sender, EventArgs e)
        {
            tbResultatNumerateur.Enabled = false;
            tbResultatDenominateur.Enabled = false;
            rbAddition.Checked = true;
            btnCalculez.Enabled = false;
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void activerBtnCalculez(object sender, EventArgs e)
        {
            if (tbNumerateur1.Text != "" && tbDenominateur1.Text != "" && tbNumerateur2.Text != "" && tbDenominateur2.Text != "")
            {
                btnCalculez.Enabled = true;
            }
            else
            {
                btnCalculez.Enabled = false;
            }
        }

        private void btnCalculez_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(tbNumerateur1.Text);
            int denom1 = Int32.Parse(tbDenominateur1.Text);
            int num2 = Int32.Parse(tbNumerateur2.Text);
            int denom2 = Int32.Parse(tbDenominateur2.Text);

            try
            {
                Rationnal r1 = new Rationnal(num1, denom1);
                Rationnal r2 = new Rationnal(num2, denom2);


                Rationnal resultat = this.Calcul(r1,r2);
             

                tbResultatNumerateur.Text = resultat.Numérateur.ToString();
                tbResultatDenominateur.Text = resultat.Dénominateur.ToString();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "Erreur" ,MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private Rationnal Calcul(Rationnal pR1, Rationnal pR2)
        {

            if (rbAddition.Checked)
            {
                return pR1 + pR2;
            }
            else if (rbSoustraction.Checked)
            {
                return pR1 - pR2;
            }
            else if (rbMultiplication.Checked)
            {
                return pR1 * pR2;
            }
            else
            {
                return pR1 / pR2;
            }
        }
    }
}
