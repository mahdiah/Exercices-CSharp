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
namespace WUIVigenere
{
    public partial class VigenereApp : Form
    {
        public VigenereApp()
        {
            InitializeComponent();
        }

        private void chiffrerBtn_Click(object sender, EventArgs e)
        {
 
            if(textBox1.TextLength != 0 || textBox2.TextLength != 0)
            {
                Vigenere vigenere = new Vigenere();
                textBox3.Text = vigenere.Encrypt((textBox1.Text), textBox2.Text);
                chiffrerBtn.Enabled = false;
            }

        }

        private void dechiffreBtn_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength != 0 || textBox3.TextLength != 0)
            {
                Vigenere vigenere = new Vigenere();
                textBox1.Text = vigenere.Decrypt(textBox3.Text, textBox2.Text);
                chiffrerBtn.Enabled = true;
                dechiffreBtn.Enabled = false;
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            chiffrerBtn.Enabled = true;
            dechiffreBtn.Enabled = true;
        }
    }
}
