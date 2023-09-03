namespace FacebookWinFormsApp
{
    public partial class FormPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.labelCommentsOfChosenPosts = new System.Windows.Forms.Label();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.labelPosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(12, 65);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(419, 346);
            this.listBoxPosts.TabIndex = 70;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // labelCommentsOfChosenPosts
            // 
            this.labelCommentsOfChosenPosts.AutoSize = true;
            this.labelCommentsOfChosenPosts.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentsOfChosenPosts.Location = new System.Drawing.Point(472, 137);
            this.labelCommentsOfChosenPosts.Name = "labelCommentsOfChosenPosts";
            this.labelCommentsOfChosenPosts.Size = new System.Drawing.Size(187, 20);
            this.labelCommentsOfChosenPosts.TabIndex = 74;
            this.labelCommentsOfChosenPosts.Text = "Comments of chosen post:";
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.BackColor = System.Drawing.Color.LemonChiffon;
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 16;
            this.listBoxPostComments.Location = new System.Drawing.Point(448, 160);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(234, 260);
            this.listBoxPostComments.TabIndex = 73;
            this.listBoxPostComments.SelectedIndexChanged += new System.EventHandler(this.listBoxPostComments_DoubleClick);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelPosts.Location = new System.Drawing.Point(287, 9);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(106, 48);
            this.labelPosts.TabIndex = 75;
            this.labelPosts.Text = "Posts";
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 436);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.labelCommentsOfChosenPosts);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelCommentsOfChosenPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.Label labelPosts;
    }
}