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
    public partial class Autonomous : Form
    {
        int i = 0;
        

        public Autonomous()
        {
            InitializeComponent();
            
        }

        private void BtnNextScreenAutonomous_Click(object sender, EventArgs e)
        {
            gb form3 = new gb();
            this.Close();
            form3.Show();
        }


        private void btnAccumulatedCargo_Click(object sender, EventArgs e)
        {
            const int MIN_NUM_DECUMULATED = 0;
            int CargoAccumulated = 0;
            CargoAccumulated = Convert.ToInt32(lblCargoAccumulated.Text);
            

            if(CargoAccumulated > MIN_NUM_DECUMULATED)
            {
                BtndecumulatedCargo.Enabled = true;
            }
            lblCargoAccumulated.Text = "" + i;
        }

        private void BtndecumulatedCargo_Click(object sender, EventArgs e)
        {
            int i;
            i = 0; 

            int CargoDecumulated;

            const int MIN_NUM_DECUMULATED = 0;
            CargoDecumulated = Convert.ToInt32(lblCargoAccumulated.Text);

            if (CargoDecumulated < MIN_NUM_DECUMULATED)
            {
                BtndecumulatedCargo.Enabled = true;
            }

            lblCargoAccumulated.Text = "" + i;
        }

       

        

        private void Autonomous_Load(object sender, EventArgs e)
        {
            


            btnAccumulatedCargo.Visible = false;//make cargo visible
            BtndecumulatedCargo.Visible = false;
            label1.Visible = false;
            lblCargoAccumulated.Visible = false;

            cLBoxTopLeftCargo.Visible = false;
            cLBoxTopMiddleCargo.Visible = false;
            cLBoxTopRightCargo.Visible = false;
            cLBoxBottomLeftCargo.Visible = false;
            cLBoxBottomMiddleCargo.Visible = false;
            cLBoxBottomRightCargo.Visible = false;

            cBoxCargo_4.Visible = false;
            cBoxCargoMid_5.Visible = false;



            clBoxDidGetHatch_1.Visible = false;//make hatches invisible
            clBoxDidGetHatch_2.Visible = false;
            clBoxDidGetHatch_3.Visible = false;
            clBoxDidGetHatch_4.Visible = false;
            clBoxDidGetHatch_5.Visible = false;
            clBoxDidGetHatch_6.Visible = false;

            BtnAccumulatedHatches.Visible = false;
            BtnDecumulatedHatches.Visible = false;

            lblHatchesAccumulated.Visible = false;
            label3.Visible = false;//got hatches label

            cBoxBay_1.Visible = false;
            cBoxBay_2.Visible = false;
            cBoxBay_3.Visible = false;
            cBoxBay_4.Visible = false;
            cBoxBay_5.Visible = false;
            cBoxBay_6.Visible = false;
            cBoxBay_7.Visible = false;
            cBoxBay_8.Visible = false;

            
        }
        private void cBoxAutonomousPlatform_CheckedChanged(object sender, EventArgs e)
        {
            rBtnGotCargo.Enabled = true;
            rBtnGotHatches.Enabled = true;
        }

        private void rBtnGotCargo_CheckedChanged(object sender, EventArgs e)
        {
            btnAccumulatedCargo.Visible = true;//make cargo visible
            BtndecumulatedCargo.Visible = true;
            label1.Visible = true;
            lblCargoAccumulated.Visible = true;
            cLBoxTopLeftCargo.Visible = true;
            cLBoxTopMiddleCargo.Visible = true;
            cLBoxTopRightCargo.Visible = true;
            cLBoxBottomLeftCargo.Visible = true;
            cLBoxBottomMiddleCargo.Visible = true;
            cLBoxBottomRightCargo.Visible = true;
            cBoxCargo_4.Visible = true;
            cBoxCargoMid_5.Visible = true;

            clBoxDidGetHatch_1.Visible = false;//make hatches invisible
            clBoxDidGetHatch_2.Visible = false;
            clBoxDidGetHatch_3.Visible = false;
            clBoxDidGetHatch_4.Visible = false;
            clBoxDidGetHatch_5.Visible = false;
            clBoxDidGetHatch_6.Visible = false;
            BtnAccumulatedHatches.Visible = false;
            BtnDecumulatedHatches.Visible = false;
            lblHatchesAccumulated.Visible = false;
            label3.Visible = false;//got hatches label
            cBoxBay_1.Visible = false;
            cBoxBay_2.Visible = false;
            cBoxBay_3.Visible = false;
            cBoxBay_4.Visible = false;
            cBoxBay_5.Visible = false;
            cBoxBay_6.Visible = false;
            cBoxBay_7.Visible = false;
            cBoxBay_8.Visible = false;
        }

        private void rBtnGotHatches_CheckedChanged(object sender, EventArgs e)
        {
            btnAccumulatedCargo.Visible = false;
            BtndecumulatedCargo.Visible = false;
            label1.Visible = false;
            lblCargoAccumulated.Visible = false;
            cLBoxTopLeftCargo.Visible = false;
            cLBoxTopMiddleCargo.Visible = false;
            cLBoxTopRightCargo.Visible = false;
            cLBoxBottomLeftCargo.Visible = false;
            cLBoxBottomMiddleCargo.Visible = false;
            cLBoxBottomRightCargo.Visible = false;
            cBoxCargo_4.Visible = false;
            cBoxCargoMid_5.Visible = false;

            clBoxDidGetHatch_1.Visible = true;//make hatches invisible
            clBoxDidGetHatch_2.Visible = true;
            clBoxDidGetHatch_3.Visible = true;
            clBoxDidGetHatch_4.Visible = true;
            clBoxDidGetHatch_5.Visible = true;
            clBoxDidGetHatch_6.Visible = true;
            BtnAccumulatedHatches.Visible = true;
            BtnDecumulatedHatches.Visible = true;
            lblHatchesAccumulated.Visible = true;
            label3.Visible = true;
            cBoxBay_1.Visible = true;
            cBoxBay_2.Visible = true;
            cBoxBay_3.Visible = true;
            cBoxBay_4.Visible = true;
            cBoxBay_5.Visible = true;
            cBoxBay_6.Visible = true;
            cBoxBay_7.Visible = true;
            cBoxBay_8.Visible = true;

        }

        private void BtnDecumulatedHatches_Click(object sender, EventArgs e)
        {
            

            int CargoDecumulated;

            const int MAX_AMOUNT_OF_HATCHES = 1;
            const int MIN_NUM_DECUMULATED = 0;
            CargoDecumulated = Convert.ToInt32(lblHatchesAccumulated.Text);

            if (CargoDecumulated < MIN_NUM_DECUMULATED)
            {
                BtnDecumulatedHatches.Enabled = true;
            }

            lblHatchesAccumulated.Text = "" + i;
        }

        private void BtnAccumulatedHatches_Click(object sender, EventArgs e)
        {
            const int MIN_NUM_DECUMULATED = 0;
            int HatchesAccumulated = 0;
            i = 1;
            HatchesAccumulated = Convert.ToInt32(lblHatchesAccumulated.Text);


            if (HatchesAccumulated > MIN_NUM_DECUMULATED)
            {
                BtnDecumulatedHatches.Enabled = true;
            }
            lblHatchesAccumulated.Text = "" + i;
        }

        private void BtnAmountOfCheckBoxes_Click(object sender, EventArgs e)
        {

            for (i=0; i<cLBoxTopLeftCargo.Items.Count;i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < cLBoxBottomMiddleCargo.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < cLBoxBottomRightCargo.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < clBoxDidGetHatch_1.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < clBoxDidGetHatch_2.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < clBoxDidGetHatch_3.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < clBoxDidGetHatch_4.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < clBoxDidGetHatch_5.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < clBoxDidGetHatch_6.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < cLBoxTopLeftCargo.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < cLBoxTopMiddleCargo.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            for (i = 0; i < cLBoxTopRightCargo.Items.Count; i++)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            if(rBtnGotHatches.Checked==true)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            else if (rBtnGotHatches.Checked==false)
            {
                lblCheckedBoxes.Text = "" + (i);
            }

            if (rBtnGotCargo.Checked == true)
            {
                lblCheckedBoxes.Text = "" + (i );
            }

            else if (rBtnGotCargo.Checked == false)
            {
                lblCheckedBoxes.Text = "" + (i);
            }


            if (cBoxAutonomousPlatform.Checked==true)
            {
                lblCheckedBoxes.Text = "" + (i);
            }
            else if (cBoxAutonomousPlatform.Checked==false)
            {
                lblCheckedBoxes.Text = "" + (i-1);
            }
        }

        /*the amount of cargo that is checked can only be the amount in the accumulator, 
and the amount in the accumulator is the amount you are able to check*/

    }
}

