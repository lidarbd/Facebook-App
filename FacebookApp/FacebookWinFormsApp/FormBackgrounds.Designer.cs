namespace FacebookWinFormsApp
{
    public partial class FormBackgrounds
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackgrounds));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "download (1).jpg");
            this.imageList.Images.SetKeyName(1, "download.jpg");
            this.imageList.Images.SetKeyName(2, "fea45a5a8adec5cdb66989a84f52a70c.jpg");
            this.imageList.Images.SetKeyName(3, "feab0953fce10f5f8ca934dd75daa146.jpg");
            this.imageList.Images.SetKeyName(4, "hand-painted-watercolor-nature-background_23-2148941599.jpg");
            this.imageList.Images.SetKeyName(5, "istockphoto-956253048-612x612.jpg");
            this.imageList.Images.SetKeyName(6, "istockphoto-1295094894-612x612.jpg");
            this.imageList.Images.SetKeyName(7, "Purple-Modern-Pattern-Simple-Background-Image.jpg");
            this.imageList.Images.SetKeyName(8, "seamless-background-with-emojis-vector.jpg");
            this.imageList.Images.SetKeyName(9, "vibrant-pink-watercolor-painting-background_53876-58931.jpg");
            this.imageList.Images.SetKeyName(10, "watercolor-autumn-leaves-background_52683-68746.jpg");
            this.imageList.Images.SetKeyName(11, "white-gold-geometric-pattern-background-vector_53876-140726.jpg");
            // 
            // FormBackgrounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(272, 334);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackgrounds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backgrounds";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
    }
}