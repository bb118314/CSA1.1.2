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
    public partial class gb : Form
    {
       
        public gb()
        {
            InitializeComponent();
          
        }
        // values Driver Controlled
        public class valuesDC
        {
            // All ints below are for the rocket misses
            public static int sideALow = 0;
            public static int sideAMed = 0;
            public static int sideAHigh = 0;
            public static int sideBLow = 0;
            public static int sideBMed = 0;
            public static int sideBHigh = 0;
            public static int cargoHigh = 0;
            public static int cargoMed = 0;
            public static int cargoLow = 0;

            public static int sideALow2 = 0;
            public static int sideAMed2 = 0;
            public static int sideAHigh2 = 0;
            public static int sideBLow2 = 0;
            public static int sideBMed2 = 0;
            public static int sideBHigh2 = 0;
            public static int cargoHigh2 = 0;
            public static int cargoMed2 = 0;
            public static int cargoLow2 = 0;

            // Below are for rocket successes
            public static Boolean sideALowS = false;
            public static Boolean sideAMedS = false;
            public static Boolean sideAHighS = false;
            public static Boolean sideBLowS = false;
            public static Boolean sideBMedS = false;
            public static Boolean sideBHighS = false;
            public static int cargoHighS = 0;
            public static int cargoMedS = 0;
            public static int cargoLowS = 0;

            public static Boolean sideALowS2 = false;
            public static Boolean sideAMedS2 = false;
            public static Boolean sideAHighS2 = false;
            public static Boolean sideBLowS2 = false;
            public static Boolean sideBMedS2 = false;
            public static Boolean sideBHighS2 = false;
            public static int cargoHighS2 = 0;
            public static int cargoMedS2 = 0;
            public static int cargoLowS2 = 0;
        }

        private void DriverControlled_Load(object sender, EventArgs e)
        {

        }

        private void BtnAttempted_1_Click(object sender, EventArgs e)
        {
                if (rBtnLow.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideALow;
                valuesDC.sideALow = valuesDC.sideALow + 1;
                }
                else if (rBtnMedium.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideAMed;
                valuesDC.sideAMed = valuesDC.sideAMed + 1;
                }
                else if (rBtnHigh.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideAHigh;
                valuesDC.sideAHigh = valuesDC.sideAHigh + 1;
                }
            
        }
        
        private void lblAttempted_Click(object sender, EventArgs e)
        {

        }

        private void rBtnLow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + valuesDC.sideALow;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                lblAttempted.Text = "";
                if (rBtnLow.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideALow;
                }
                else if (rBtnMedium.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideAMed;
                }
                else if (rBtnHigh.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideAHigh;
                }
            }

        private void BtnNextScreenDriverStation_Click(object sender, EventArgs e)
        {
            EndGame form4 = new EndGame();
            this.Close();
            form4.Show();
        }

        private void BtnMinus_1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowTop.Checked == true)
                {
                    valuesDC.cargoLow = valuesDC.cargoLow - 1;
                    lblAttempted.Text = "" + valuesDC.cargoLow;
                }
                else if (rBtnMediumTop.Checked == true)
                {
                    valuesDC.cargoMed = valuesDC.cargoMed - 1;
                    lblAttempted.Text = "" + valuesDC.cargoMed;
                }
                else if (rBtnHighTop.Checked == true)
                {
                    valuesDC.cargoHigh = valuesDC.cargoHigh - 1;
                    lblAttempted.Text = "" + valuesDC.cargoHigh;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        valuesDC.sideALow = valuesDC.sideALow - 1;
                        lblAttempted.Text = "" + valuesDC.sideALow;

                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        valuesDC.sideAMed = valuesDC.sideAMed - 1;
                        lblAttempted.Text = "" + valuesDC.sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesDC.sideAHigh = valuesDC.sideAHigh - 1;
                        lblAttempted.Text = "" + valuesDC.sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        valuesDC.sideBLow = valuesDC.sideBLow - 1;
                        lblAttempted.Text = "" + valuesDC.sideBLow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        valuesDC.sideBMed = valuesDC.sideBMed - 1;
                        lblAttempted.Text = "" + valuesDC.sideBMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesDC.sideBHigh = valuesDC.sideBHigh - 1;
                        lblAttempted.Text = "" + valuesDC.sideBHigh;

                    }
                }
            }
        }

        private void rBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + valuesDC.sideAMed;
        }

        private void rBtnHigh_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + valuesDC.sideAHigh;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowTop.Checked == true)
                {
                    valuesDC.cargoLow = valuesDC.cargoLow + 1;
                    lblAttempted.Text = "" + valuesDC.cargoLow;
                }
                else if (rBtnMediumTop.Checked == true)
                {
                    valuesDC.cargoMed = valuesDC.cargoMed + 1;
                    lblAttempted.Text = "" + valuesDC.cargoMed;
                }
                else if (rBtnHighTop.Checked == true)
                {
                    valuesDC.cargoHigh = valuesDC.cargoHigh + 1;
                    lblAttempted.Text = "" + valuesDC.cargoHigh;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        valuesDC.sideALow = valuesDC.sideALow + 1;
                        lblAttempted.Text = "" + valuesDC.sideALow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {

                        valuesDC.sideAMed = valuesDC.sideAMed + 1;
                        lblAttempted.Text = "" + valuesDC.sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesDC.sideAHigh = valuesDC.sideAHigh + 1;
                        lblAttempted.Text = "" + valuesDC.sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        valuesDC.sideBLow = valuesDC.sideBLow + 1;
                        lblAttempted.Text = "" + valuesDC.sideBLow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        valuesDC.sideBMed = valuesDC.sideBMed + 1;
                        lblAttempted.Text = "" + valuesDC.sideBMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesDC.sideBHigh = valuesDC.sideBHigh + 1;
                        lblAttempted.Text = "" + valuesDC.sideBHigh;
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            rBtnHighTop.Checked = false;
            rBtnMediumTop.Checked = false;
            rBtnLowTop.Checked = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rBtnRocket.Checked == true)
            {
                gbSideTop.Visible = true;
                groupBox4.Visible = true;
                groupBox2.Visible = true;
                gbHeightTop.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                lblAttempted.Visible = true;
                lblAttempted2.Visible = true;
                BtnMinus1.Visible = true;
                btnMinus2.Visible = true;
                btnAdd1.Visible = true;
                btnAdd2.Visible = true;
                gbS.Visible = false;
                gbS2.Visible = true;
                gbS3.Visible = false;
                gbS4.Visible = true;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;
                
            }
            else if (rBtnShuttle.Checked == true)
            {
                cBoxShuttle1.Visible = true;
                cBoxShuttle2.Visible = true;
                cBoxShuttle3.Visible = true;
                cBoxShuttle4.Visible = true;
                cBoxShuttle5.Visible = true;
                cBoxShuttle6.Visible = true;
                cBoxShuttle7.Visible = true;
                cBoxShuttle8.Visible = true;
            }
        }

     

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRocket.Checked == true)
            {
                gbSideTop.Visible = false;
                groupBox4.Visible = false;
                gbHeightTop.Visible = true;
                groupBox2.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                lblAttempted.Visible = true;
                lblAttempted2.Visible = true;
                BtnMinus1.Visible = true;
                btnMinus2.Visible = true;
                btnAdd1.Visible = true;
                btnAdd2.Visible = true;
                gbS.Visible = true;
                gbS2.Visible = false;
                gbS3.Visible = true;
                gbS4.Visible = false;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                lblAttempted2.Text = "";
                lblAttempted.Text = "";
                cBoxShuttle1.Visible = false;
                cBoxShuttle2.Visible = false;
                cBoxShuttle3.Visible = false;
                cBoxShuttle4.Visible = false;
                cBoxShuttle5.Visible = false;
                cBoxShuttle6.Visible = false;
                cBoxShuttle7.Visible = false;
                cBoxShuttle8.Visible = false;
                rBtnHighTop.Checked = false;
                rBtnMediumTop.Checked = false;
                rBtnLowTop.Checked = false;
                rBtnHighLow.Checked = false;
                rBtnMediumLow.Checked = false;
                rBtnLowLow.Checked = false;
            }

            else if (rBtnShuttle.Checked == true)
            {
                cBoxShuttle1.Visible = false;
                cBoxShuttle2.Visible = false;
                cBoxShuttle3.Visible = false;
                cBoxShuttle4.Visible = false;
                cBoxShuttle5.Visible = false;
                cBoxShuttle6.Visible = false;
                cBoxShuttle7.Visible = false;
                cBoxShuttle8.Visible = false;
            }
        }

        private void rBtnLowTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + valuesDC.cargoLow;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideALow;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideBLow;
                }
            }
        }

        private void rBtnMediumTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + valuesDC.cargoMed;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideAMed;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideBMed;
                }
            }
        }

        private void rBtnHighTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + valuesDC.cargoHigh;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideAHigh;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesDC.sideBHigh;
                }
            }
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowLow.Checked == true)
                {
                    valuesDC.cargoLow2 = valuesDC.cargoLow2 + 1;
                    lblAttempted2.Text = "" + valuesDC.cargoLow2;
                }
                else if (rBtnMediumLow.Checked == true)
                {
                    valuesDC.cargoMed2 = valuesDC.cargoMed2 + 1;
                    lblAttempted2.Text = "" + valuesDC.cargoMed2;
                }
                else if (rBtnHighLow.Checked == true)
                {
                    valuesDC.cargoHigh2 = valuesDC.cargoHigh2 + 1;
                    lblAttempted2.Text = "" + valuesDC.cargoHigh2;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {

                        valuesDC.sideALow2 = valuesDC.sideALow2 + 1;
                        lblAttempted2.Text = "" + valuesDC.sideALow2;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {

                        valuesDC.sideAMed2 = valuesDC.sideAMed2 + 1;
                        lblAttempted2.Text = "" + valuesDC.sideAMed2;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {

                        valuesDC.sideAHigh2 = valuesDC.sideAHigh2 + 1;
                        lblAttempted2.Text = "" + valuesDC.sideAHigh2;
                    }
                }
                else if (btnBLow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {
                        valuesDC.sideBLow2 = valuesDC.sideBLow2 + 1;
                        lblAttempted2.Text = "" + valuesDC.sideBLow2;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        valuesDC.sideBMed2 = valuesDC.sideBMed2 + 1;
                        lblAttempted2.Text = "" + valuesDC.sideBMed2;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        valuesDC.sideBHigh2 = valuesDC.sideBHigh2 + 1;
                        lblAttempted2.Text = "" + valuesDC.sideBHigh2;
                    }
                }
            }
        }

        private void btnBTop_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            rBtnHighTop.Checked = false;
            rBtnMediumTop.Checked = false;
            rBtnLowTop.Checked = false;
        }

        private void btnALow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted2.Text = "";
            rBtnHighLow.Checked = false;
            rBtnMediumLow.Checked = false;
            rBtnLowLow.Checked = false;
        }

        private void btnBLow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted2.Text = "";
            rBtnHighLow.Checked = false;
            rBtnMediumLow.Checked = false;
            rBtnLowLow.Checked = false;
        }

        private void rBtnLowLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + valuesDC.cargoLow2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesDC.sideALow2;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesDC.sideBLow2;
                }
            }
        }

        private void rBtnMediumLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + valuesDC.cargoMed2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesDC.sideAMed2;
                }
                if (btnBLow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesDC.sideBMed2;
                }
            }
        }

        private void rBtnHighLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + valuesDC.cargoHigh2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesDC.sideAHigh2;
                }
                if (btnBLow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesDC.sideBHigh2;
                }
            }
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowLow.Checked == true)
                {
                    valuesDC.cargoLow2 = valuesDC.cargoLow2 - 1;
                    lblAttempted2.Text = "" + valuesDC.cargoLow2;
                    
                }
                else if (rBtnMediumLow.Checked == true)
                {
                    valuesDC.cargoMed2 = valuesDC.cargoMed2 - 1;
                    lblAttempted2.Text = "" + valuesDC.cargoMed2;
                    
                }
                else if (rBtnHighLow.Checked == true)
                {
                    valuesDC.cargoHigh2 = valuesDC.cargoHigh2 - 1;
                    lblAttempted2.Text = "" + valuesDC.cargoHigh2;
                    
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {

                        valuesDC.sideALow2 = valuesDC.sideALow2 - 1;
                        lblAttempted2.Text = "" + valuesDC.sideALow2;
                        

                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        valuesDC.sideAMed2 = valuesDC.sideAMed2 - 1;
                        lblAttempted2.Text = "" + valuesDC.sideAMed2;
                        
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        valuesDC.sideAHigh2 = valuesDC.sideAHigh2 - 1;
                        lblAttempted.Text = "" + valuesDC.sideAHigh2;
                        
                    }
                }
                else if (btnBLow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {
                        valuesDC.sideBLow2 = valuesDC.sideBLow2 - 1;
                        lblAttempted2.Text = "" + valuesDC.sideBLow2;
                        
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        valuesDC.sideBMed2 = valuesDC.sideBMed2 - 1;
                        lblAttempted2.Text = "" + valuesDC.sideBMed2;
                        
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        valuesDC.sideBHigh2 = valuesDC.sideBHigh2 - 1;
                        lblAttempted2.Text = "" + valuesDC.sideBHigh2;
                        
                    }
                }
            }
        }

        private void rBtnRocket_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cBoxShuttle1.Visible = false;
            cBoxShuttle2.Visible = false;
            cBoxShuttle3.Visible = false;
            cBoxShuttle4.Visible = false;
            cBoxShuttle5.Visible = false;
            cBoxShuttle6.Visible = false;
            cBoxShuttle7.Visible = false;
            cBoxShuttle8.Visible = false;
        }

        private void rBtnShuttle_CheckedChanged(object sender, EventArgs e)
        {
            gbSideTop.Visible = false;
            groupBox4.Visible = false;
            gbHeightTop.Visible = false;
            groupBox2.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            lblAttempted.Visible = false;
            lblAttempted2.Visible = false;
            BtnMinus1.Visible = false;
            btnMinus2.Visible = false;
            btnAdd1.Visible = false;
            btnAdd2.Visible = false;
            lblAttempted2.Text = "";
            lblAttempted.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            gbS.Visible = false;
            gbS2.Visible = false;
            gbS3.Visible = false;
            gbS4.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            label11.Visible = false;
        }

        private void cBoxHatch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        valuesDC.sideALow = valuesDC.sideALow + 1;
                        lblAttempted.Text = "" + valuesDC.sideALow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {

                        valuesDC.sideAMed = valuesDC.sideAMed + 1;
                        lblAttempted.Text = "" + valuesDC.sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {

                        valuesDC.sideAHigh = valuesDC.sideAHigh + 1;
                        lblAttempted.Text = "" + valuesDC.sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        lblAttempted.Text = "" + valuesDC.sideBLow;
                        valuesDC.sideBLow = valuesDC.sideBLow + 1;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        lblAttempted.Text = "" + valuesDC.sideBMed;
                        valuesDC.sideBMed = valuesDC.sideBMed + 1;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        lblAttempted.Text = "" + valuesDC.sideBHigh;
                        valuesDC.sideBHigh = valuesDC.sideBHigh + 1;
                    }
                }
            }
        }

        private void cBoxSuccessfulCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rBtnLow1S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow1S.Checked == true)
            {
                valuesDC.cargoLowS = 1;
            }

        }

        private void rBtnLow2S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow2S.Checked == true)
            {
                valuesDC.cargoLowS = 2;
            }
        }

        private void rBtnMed1S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed1S.Checked == true)
            {
                valuesDC.cargoMedS = 1;
            }
        }

        private void rBtnMed2S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed2S.Checked == true)
            {
                valuesDC.cargoMedS = 2;
            }
        }

        private void rBtnHigh1S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh1S.Checked == true)
            {
                valuesDC.cargoHighS = 1;
            }
        }

        private void rBtnHigh2S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh2S.Checked == true)
            {
                valuesDC.cargoHighS = 2;
            }
        }

        private void rBtnHighHatchA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxMedHatchA_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchA.Checked == true)
            {
                valuesDC.sideAMedS = true;
            }
            else if (cBoxMedHatchA.Checked == false)
            {
                valuesDC.sideAMedS = false;
            }
        }

        private void cBoxHighHatchA_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchA.Checked == true)
            {
                valuesDC.sideAHighS = true;
            }
            else if (cBoxHighHatchA.Checked == false)
            {
                valuesDC.sideAHighS = false;
            }
        }

        private void cBoxLowHatchB_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchB.Checked == true)
            {
                valuesDC.sideBLowS = true;
            }
            else if (cBoxLowHatchB.Checked == false)
            {
                valuesDC.sideBLowS = false;
            }
        }

        private void cBoxMedHatchB_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchB.Checked == true)
            {
                valuesDC.sideBMedS = true;
            }
            else if (cBoxMedHatchB.Checked == false)
            {
                valuesDC.sideBMedS = false;
            }
        }

        private void cBoxHighHatchB_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchB.Checked == true)
            {
                valuesDC.sideBHighS = true;
            }
            else if (cBoxHighHatchB.Checked == false)
            {
                valuesDC.sideBHighS = false;
            }
        }

        private void cBoxLowHatchA_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchA.Checked == true)
            {
                valuesDC.sideALowS = true;
            }
            else if (cBoxLowHatchA.Checked == false)
            {
                valuesDC.sideALowS = false;
            }
        }

        private void rBtnLow1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow1S2.Checked == true)
            {
                valuesDC.cargoLowS2 = 1;
            }
        }

        private void rBtnLow2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow2S2.Checked == true)
            {
                valuesDC.cargoLowS2 = 2;
            }
        }

        private void rBtnMed1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed1S2.Checked == true)
            {
                valuesDC.cargoMedS2 = 1;
            }
        }

        private void rBtnMed2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed2S2.Checked == true)
            {
                valuesDC.cargoMedS2 = 2;
            }
        }

        private void rBtnHigh1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh1S2.Checked == true)
            {
                valuesDC.cargoHighS2 = 1;
            }
        }

        private void rBtnHigh2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh2S2.Checked == true)
            {
                valuesDC.cargoHighS2 = 2;
            }
        }

        private void cBoxLowHatchA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchA2.Checked == true)
            {
                valuesDC.sideALowS2 = true;
            }
            else if (cBoxLowHatchA2.Checked == false)
            {
                valuesDC.sideALowS2 = false;
            }
        }

        private void cBoxMedHatchA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchA2.Checked == true)
            {
                valuesDC.sideAMedS2 = true;
            }
            else if (cBoxMedHatchA2.Checked == false)
            {
                valuesDC.sideAMedS2 = false;
            }
        }

        private void cBoxHighHatchA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchA2.Checked == true)
            {
                valuesDC.sideAHighS2 = true;
            }
            else if (cBoxHighHatchA2.Checked == false)
            {
                valuesDC.sideAHighS2 = false;
            }
        }

        private void cBoxHighHatchB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchB2.Checked == true)
            {
                valuesDC.sideBHighS2 = true;
            }
            else if (cBoxHighHatchB2.Checked == false)
            {
                valuesDC.sideBHighS2 = false;
            }
        }

        private void cBoxMedHatchB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchB2.Checked == true)
            {
                valuesDC.sideBMedS2 = true;
            }
            else if (cBoxMedHatchB2.Checked == false)
            {
                valuesDC.sideBMedS2 = false;
            }
        }

        private void cBoxLowHatchB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchB2.Checked == true)
            {
                valuesDC.sideBLowS2 = true;
            }
            else if (cBoxLowHatchB2.Checked == false)
            {
                valuesDC.sideBLowS2 = false;
            }
        }

        private void gbS2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
