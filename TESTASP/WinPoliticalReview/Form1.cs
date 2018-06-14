using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace WinPoliticalReview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHelper dH = new DataHelper();
            cboPoliticians.DataSource = dH.getPoliticians();
        }

        private void cboPoliticians_SelectedIndexChanged(object sender, EventArgs e)
        {
            Politician j = (Politician) cboPoliticians.SelectedItem;

            txtJob.Text = j.JobTitle;
            txtYOF.Text = j.YearsInOffice.ToString();

            //if(j.isLiberal)
            //{
            //    chkLiberal.Checked = true;
            //}
            //else
            //{
            //    chkLiberal.Checked = false;
            //}

            chkLiberal.Checked = j.isLiberal;
        }
    }
}
