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
using Model;
using BLL;

namespace WUI
{
    public partial class FrmLanguage : Form
    {
        public FrmLanguage()
        {
            InitializeComponent();
        }

        private void BtnLoadLanguages_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BLL_Construct<Language> myBLL = new BLL_Construct<Language>();
            TxtLanguages.Text = myBLL.DisplayData(NAL.Languages);
            this.Cursor = Cursors.Default;
        }

        private void TxtLanguages_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Language> myList = new List<Language>();
            BLL_Construct<Language> myBLL = new BLL_Construct<Language>();
            myList = myBLL.FillList(NAL.Languages);
            string s = string.Format("{0,0}\t {1} \t{2,5}", "ID", "Code", "Langue" + Environment.NewLine);           
            TxtLanguages.AppendText(s);
            foreach (Language Lng in myList)
            {
                s = string.Format("{0,0}\t {1}\t {2,5}", Lng.ID, Lng.Code, Lng.OriginalName + Environment.NewLine);
                TxtLanguages.AppendText(s);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
