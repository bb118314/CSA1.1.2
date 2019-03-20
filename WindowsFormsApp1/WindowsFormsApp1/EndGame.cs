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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void BtnNextScreen_Click(object sender, EventArgs e)
        {
            FRC_Statistics form5 = new FRC_Statistics();
            this.Close();
            form5.Show();
        }
    }
}
