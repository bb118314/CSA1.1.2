using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRecordLog : Form
    {
        public frmRecordLog()
        {
            InitializeComponent();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            Autonomous form2 = new Autonomous();
            form2.Show();
            this.Visible = false;
        }

        private void chkBox1AllianceID_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtn1AllianceID.Checked==true)
            {
                
            }
        }
    }
}
