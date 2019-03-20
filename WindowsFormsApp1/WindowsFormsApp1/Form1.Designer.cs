namespace WindowsFormsApp1
{
    partial class frmRecordLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.tbMatchNum = new System.Windows.Forms.TextBox();
            this.tbTeamNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.rBtn1AllianceID = new System.Windows.Forms.RadioButton();
            this.rBtn2AllianceID = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbEvent
            // 
            this.tbEvent.Location = new System.Drawing.Point(122, 106);
            this.tbEvent.Multiline = true;
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(100, 20);
            this.tbEvent.TabIndex = 1;
            // 
            // tbMatchNum
            // 
            this.tbMatchNum.Location = new System.Drawing.Point(270, 107);
            this.tbMatchNum.Multiline = true;
            this.tbMatchNum.Name = "tbMatchNum";
            this.tbMatchNum.Size = new System.Drawing.Size(100, 20);
            this.tbMatchNum.TabIndex = 2;
            // 
            // tbTeamNum
            // 
            this.tbTeamNum.Location = new System.Drawing.Point(440, 107);
            this.tbTeamNum.Multiline = true;
            this.tbTeamNum.Name = "tbTeamNum";
            this.tbTeamNum.Size = new System.Drawing.Size(100, 20);
            this.tbTeamNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Team ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alliance ID";
            // 
            // BtnContinue
            // 
            this.BtnContinue.Location = new System.Drawing.Point(725, 402);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(107, 38);
            this.BtnContinue.TabIndex = 10;
            this.BtnContinue.Text = "Next Screen";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // rBtn1AllianceID
            // 
            this.rBtn1AllianceID.AutoSize = true;
            this.rBtn1AllianceID.Location = new System.Drawing.Point(617, 109);
            this.rBtn1AllianceID.Name = "rBtn1AllianceID";
            this.rBtn1AllianceID.Size = new System.Drawing.Size(46, 17);
            this.rBtn1AllianceID.TabIndex = 11;
            this.rBtn1AllianceID.TabStop = true;
            this.rBtn1AllianceID.Text = "Blue";
            this.rBtn1AllianceID.UseVisualStyleBackColor = true;
            // 
            // rBtn2AllianceID
            // 
            this.rBtn2AllianceID.AutoSize = true;
            this.rBtn2AllianceID.Location = new System.Drawing.Point(617, 132);
            this.rBtn2AllianceID.Name = "rBtn2AllianceID";
            this.rBtn2AllianceID.Size = new System.Drawing.Size(45, 17);
            this.rBtn2AllianceID.TabIndex = 12;
            this.rBtn2AllianceID.TabStop = true;
            this.rBtn2AllianceID.Text = "Red";
            this.rBtn2AllianceID.UseVisualStyleBackColor = true;
            // 
            // frmRecordLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 584);
            this.Controls.Add(this.rBtn2AllianceID);
            this.Controls.Add(this.rBtn1AllianceID);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTeamNum);
            this.Controls.Add(this.tbMatchNum);
            this.Controls.Add(this.tbEvent);
            this.Name = "frmRecordLog";
            this.Text = "Information Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEvent;
        private System.Windows.Forms.TextBox tbMatchNum;
        private System.Windows.Forms.TextBox tbTeamNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.RadioButton rBtn1AllianceID;
        private System.Windows.Forms.RadioButton rBtn2AllianceID;
    }
}

