namespace FacebookWinFormsApp
{
    public partial class FormBirthdayInAWeek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirthdayInAWeek));
            this.linkLabelBuyMe = new System.Windows.Forms.LinkLabel();
            this.textBoxBirthdayInAWeek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabelBuyMe
            // 
            this.linkLabelBuyMe.AutoSize = true;
            this.linkLabelBuyMe.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBuyMe.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabelBuyMe.Location = new System.Drawing.Point(40, 226);
            this.linkLabelBuyMe.Name = "linkLabelBuyMe";
            this.linkLabelBuyMe.Size = new System.Drawing.Size(255, 25);
            this.linkLabelBuyMe.TabIndex = 1;
            this.linkLabelBuyMe.TabStop = true;
            this.linkLabelBuyMe.Text = "Press Here To Buy A Present";
            this.linkLabelBuyMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuyMe_LinkClicked);
            // 
            // textBoxBirthdayInAWeek
            // 
            this.textBoxBirthdayInAWeek.BackColor = System.Drawing.Color.Linen;
            this.textBoxBirthdayInAWeek.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthdayInAWeek.Location = new System.Drawing.Point(43, 74);
            this.textBoxBirthdayInAWeek.Multiline = true;
            this.textBoxBirthdayInAWeek.Name = "textBoxBirthdayInAWeek";
            this.textBoxBirthdayInAWeek.ReadOnly = true;
            this.textBoxBirthdayInAWeek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBirthdayInAWeek.Size = new System.Drawing.Size(266, 135);
            this.textBoxBirthdayInAWeek.TabIndex = 2;
            // 
            // FormBirthdayInAWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.balloons;
            this.ClientSize = new System.Drawing.Size(359, 260);
            this.Controls.Add(this.textBoxBirthdayInAWeek);
            this.Controls.Add(this.linkLabelBuyMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBirthdayInAWeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAPPY BIRTHDAY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelBuyMe;
        private System.Windows.Forms.TextBox textBoxBirthdayInAWeek;
    }
}