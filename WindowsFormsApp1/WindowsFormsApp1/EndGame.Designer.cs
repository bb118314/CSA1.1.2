namespace WindowsFormsApp1
{
    partial class EndGame
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
            this.cBoxDidGetBackOnPlatform = new System.Windows.Forms.CheckBox();
            this.BtnNextScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBoxDidGetBackOnPlatform
            // 
            this.cBoxDidGetBackOnPlatform.Location = new System.Drawing.Point(242, 226);
            this.cBoxDidGetBackOnPlatform.Name = "cBoxDidGetBackOnPlatform";
            this.cBoxDidGetBackOnPlatform.Size = new System.Drawing.Size(96, 93);
            this.cBoxDidGetBackOnPlatform.TabIndex = 0;
            this.cBoxDidGetBackOnPlatform.Text = "Did Robot get back on platform?";
            this.cBoxDidGetBackOnPlatform.UseVisualStyleBackColor = true;
            // 
            // BtnNextScreen
            // 
            this.BtnNextScreen.Location = new System.Drawing.Point(679, 382);
            this.BtnNextScreen.Name = "BtnNextScreen";
            this.BtnNextScreen.Size = new System.Drawing.Size(115, 56);
            this.BtnNextScreen.TabIndex = 1;
            this.BtnNextScreen.Text = "Next Screen";
            this.BtnNextScreen.UseVisualStyleBackColor = true;
            this.BtnNextScreen.Click += new System.EventHandler(this.BtnNextScreen_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FRC_Field;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNextScreen);
            this.Controls.Add(this.cBoxDidGetBackOnPlatform);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxDidGetBackOnPlatform;
        private System.Windows.Forms.Button BtnNextScreen;
    }
}