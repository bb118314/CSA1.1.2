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
    public partial class FRC_Statistics : Form
    {
        public FRC_Statistics()
        {
            InitializeComponent();
            int totalHatches = 0;
            int totalHatches2 = 0;


            if (WindowsFormsApp1.gb.valuesDC.sideALowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAMedS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAHighS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBLowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBMedS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBHighS == true)
            {
                totalHatches = totalHatches + 1;
            }

            if (WindowsFormsApp1.gb.valuesDC.sideALowS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAMedS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAHighS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBLowS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBMedS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBHighS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }

            int totalCargoMissed = WindowsFormsApp1.gb.valuesDC.cargoHigh + WindowsFormsApp1.gb.valuesDC.cargoMed + WindowsFormsApp1.gb.valuesDC.cargoLow;
            int totalCargoMissed2 = WindowsFormsApp1.gb.valuesDC.cargoHigh2 + WindowsFormsApp1.gb.valuesDC.cargoMed2 + WindowsFormsApp1.gb.valuesDC.cargoLow2;
            int totalHatchesMissed = WindowsFormsApp1.gb.valuesDC.sideALow + WindowsFormsApp1.gb.valuesDC.sideAMed + WindowsFormsApp1.gb.valuesDC.sideAHigh + WindowsFormsApp1.gb.valuesDC.sideBLow + WindowsFormsApp1.gb.valuesDC.sideBMed + WindowsFormsApp1.gb.valuesDC.sideBHigh;
            int totalHatchesMissed2 = 0;
            int totalCargo = WindowsFormsApp1.gb.valuesDC.cargoHighS + WindowsFormsApp1.gb.valuesDC.cargoMedS + WindowsFormsApp1.gb.valuesDC.cargoLowS;
            int totalCargo2 = WindowsFormsApp1.gb.valuesDC.cargoHighS2 + WindowsFormsApp1.gb.valuesDC.cargoMedS2 + WindowsFormsApp1.gb.valuesDC.cargoLowS2;

            lblCargoTotal.Text = "Cargo: " + totalCargo + "       Misses: " + totalCargoMissed;
            lblHatchesTotal.Text = "Hatches: " + totalHatches + "       Misses: " + totalHatchesMissed;
            lblCargoTotal2.Text = "Cargo: " + totalCargo2 + "       Misses: " + totalCargoMissed2;
            lblHatchesTotal2.Text = "Hatches: " + totalHatches2;

            
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            frmRecordLog form1 = new frmRecordLog();
            this.Close();
            form1.Visible=true;
        }

        private void FRC_Statistics_Load(object sender, EventArgs e)
        {

        }

        private void lblCargoHigh_Click(object sender, EventArgs e)
        {

        }

        private void lblHatchesTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
