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
    public partial class FrmHonorific : Form
    {
        public FrmHonorific()
        {
            InitializeComponent();
        }

        private void BtnLoadLanguages_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BLL_Construct<Honorific> myBLL = new BLL_Construct<Honorific>();
            TxtLanguages.Text = myBLL.DisplayData(NAL.Honorifics);
            this.Cursor = Cursors.Default;
        }

        private void TxtLanguages_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Honorific> myList = new List<Honorific>();
            BLL_Construct<Honorific> myBLL = new BLL_Construct<Honorific>();
            myList = myBLL.FillList(NAL.Honorifics);
            string s = string.Format("{0,0}\t {1} \t{2,10}\t {3,10}\t {4,10}", "ID", "Code", "Dimi.", "Pays", "Long nom" + Environment.NewLine);           
            TxtLanguages.AppendText(s);
            foreach (Honorific Cntry in myList)
            {
                s = string.Format("{0,0}\t {1}\t {2,10}\t {3,10}", Cntry.ID, Cntry.Code, Cntry.Name, Cntry.LongName + Environment.NewLine);
                TxtLanguages.AppendText(s);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
