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
    public partial class FrmCountrie : Form
    {
        public FrmCountrie()
        {
            InitializeComponent();
        }

        private void BtnLoadLanguages_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BLL_Construct<Country> myBLL = new BLL_Construct<Country>();
            TxtLanguages.Text = myBLL.DisplayData(NAL.Countries);
            this.Cursor = Cursors.Default;
        }

        private void TxtLanguages_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Country> myList = new List<Country>();
            BLL_Construct<Country> myBLL = new BLL_Construct<Country>();
            myList = myBLL.FillList(NAL.Countries);
            string s = string.Format("{0,0}\t {1} \t{2,10}\t {3,10}\t {4,10}", "ID", "Code", "ISO", "Pays", "Long nom" + Environment.NewLine);           
            TxtLanguages.AppendText(s);
            foreach (Country Cntry in myList)
            {
                s = string.Format("{0,0}\t {1}\t {2,10}\t {3,10}\t {4,10}", Cntry.ID, Cntry.Code, Cntry.ISO, Cntry.Name, Cntry.LongName + Environment.NewLine);
                TxtLanguages.AppendText(s);
            }
            this.Cursor = Cursors.Default;
        }
    }
}
