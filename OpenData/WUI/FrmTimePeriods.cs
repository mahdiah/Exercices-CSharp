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
    public partial class FrmTimePeriods : Form
    {
        public FrmTimePeriods()
        {
            InitializeComponent();
        }

        private void BtnLoadLanguages_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BLL_Construct<Timeperiod> myBLL = new BLL_Construct<Timeperiod>();
            TxtLanguages.Text = myBLL.DisplayData(NAL.Countries);
            this.Cursor = Cursors.Default;
        }

        private void TxtLanguages_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Timeperiod> myList = new List<Timeperiod>();
            BLL_Construct<Timeperiod> myBLL = new BLL_Construct<Timeperiod>();
            myList = myBLL.FillList(NAL.TimePeriods);
            string s = string.Format("{0,0}\t {1,15} \t {2,15}", "ID", "Code", "Name" + Environment.NewLine);
            TxtLanguages.AppendText(s);
            TxtLanguages.AppendText("\n");
            foreach (Timeperiod tp in myList)
            {
                s = string.Format("{0,0}\t {1,15}  \t {2,15}", tp.ID, tp.Code, tp.Name + Environment.NewLine);
                TxtLanguages.AppendText(s);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnAfficherXML_Click(object sender, EventArgs e)
        {
            List<Timeperiod> myList = new List<Timeperiod>();
            this.Cursor = Cursors.WaitCursor;
            BLL_XML_Library myLibrary = new BLL.BLL_XML_Library();
            myList = myLibrary.FillList(NAL.TimePeriods);
            string s = string.Format("{0,0}\t {1,15} \t {2,15}", "ID", "Code", "Name" + Environment.NewLine);
            TxtLanguages.AppendText(s);
            TxtLanguages.AppendText("\n");
            foreach (Timeperiod tp in myList)
            {
                s = string.Format("{0,0}\t {1,15}  \t {2,15}", tp.ID, tp.Code, tp.Name + Environment.NewLine);
                TxtLanguages.AppendText(s);
            }
            this.Cursor = Cursors.Default;

        }
    }
}
