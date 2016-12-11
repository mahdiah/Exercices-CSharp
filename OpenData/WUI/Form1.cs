using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace WUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadLanguages_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                this.Cursor = Cursors.WaitCursor;
                string html = GetData.GetListe();
                TxtLanguages.Text = html.ToString();
                
                //TxtLanguages.Text = html;
                this.Cursor = Cursors.Default;
            }
            catch ( Exception er)
 
            {

                TxtLanguages.Text = "Problème server :" + er.Message;
            }

            
        }
    }
}
