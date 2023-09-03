namespace FacebookWinFormsApp
{
    public partial class FormTopThreePhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopThreePhotos));
            this.labelMostLikesAmount = new System.Windows.Forms.Label();
            this.labelMiddleLikesAmount = new System.Windows.Forms.Label();
            this.labelLessLikesAmount = new System.Windows.Forms.Label();
            this.pictureBoxThirdPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirstPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxSecondPlace = new System.Windows.Forms.PictureBox();
            this.pictureBoxSecond = new System.Windows.Forms.PictureBox();
            this.pictureBoxThird = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirst = new System.Windows.Forms.PictureBox();
            this.labelMaleFriend = new System.Windows.Forms.Label();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.labelFemaleFriend = new System.Windows.Forms.Label();
            this.labelMaleFriendName = new System.Windows.Forms.Label();
            this.labelFemaleFriendName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThirdPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMostLikesAmount
            // 
            this.labelMostLikesAmount.AutoSize = true;
            this.labelMostLikesAmount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikesAmount.Location = new System.Drawing.Point(65, 305);
            this.labelMostLikesAmount.Name = "labelMostLikesAmount";
            this.labelMostLikesAmount.Size = new System.Drawing.Size(100, 20);
            this.labelMostLikesAmount.TabIndex = 3;
            this.labelMostLikesAmount.Text = "00 Comments\r\n";
            // 
            // labelMiddleLikesAmount
            // 
            this.labelMiddleLikesAmount.AutoSize = true;
            this.labelMiddleLikesAmount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiddleLikesAmount.Location = new System.Drawing.Point(288, 305);
            this.labelMiddleLikesAmount.Name = "labelMiddleLikesAmount";
            this.labelMiddleLikesAmount.Size = new System.Drawing.Size(100, 20);
            this.labelMiddleLikesAmount.TabIndex = 4;
            this.labelMiddleLikesAmount.Text = "00 Comments\r\n";
            // 
            // labelLessLikesAmount
            // 
            this.labelLessLikesAmount.AutoSize = true;
            this.labelLessLikesAmount.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLessLikesAmount.Location = new System.Drawing.Point(509, 307);
            this.labelLessLikesAmount.Name = "labelLessLikesAmount";
            this.labelLessLikesAmount.Size = new System.Drawing.Size(100, 20);
            this.labelLessLikesAmount.TabIndex = 5;
            this.labelLessLikesAmount.Text = "00 Comments\r\n";
            // 
            // pictureBoxThirdPlace
            // 
            this.pictureBoxThirdPlace.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.third_place_medal;
            this.pictureBoxThirdPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxThirdPlace.Location = new System.Drawing.Point(462, 296);
            this.pictureBoxThirdPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxThirdPlace.Name = "pictureBoxThirdPlace";
            this.pictureBoxThirdPlace.Size = new System.Drawing.Size(43, 30);
            this.pictureBoxThirdPlace.TabIndex = 9;
            this.pictureBoxThirdPlace.TabStop = false;
            // 
            // pictureBoxFirstPlace
            // 
            this.pictureBoxFirstPlace.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.first_place_medal;
            this.pictureBoxFirstPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFirstPlace.Location = new System.Drawing.Point(17, 296);
            this.pictureBoxFirstPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFirstPlace.Name = "pictureBoxFirstPlace";
            this.pictureBoxFirstPlace.Size = new System.Drawing.Size(43, 30);
            this.pictureBoxFirstPlace.TabIndex = 8;
            this.pictureBoxFirstPlace.TabStop = false;
            // 
            // pictureBoxSecondPlace
            // 
            this.pictureBoxSecondPlace.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.second_place_medal;
            this.pictureBoxSecondPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSecondPlace.Location = new System.Drawing.Point(238, 296);
            this.pictureBoxSecondPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSecondPlace.Name = "pictureBoxSecondPlace";
            this.pictureBoxSecondPlace.Size = new System.Drawing.Size(43, 30);
            this.pictureBoxSecondPlace.TabIndex = 7;
            this.pictureBoxSecondPlace.TabStop = false;
            // 
            // pictureBoxSecond
            // 
            this.pictureBoxSecond.Location = new System.Drawing.Point(233, 122);
            this.pictureBoxSecond.Name = "pictureBoxSecond";
            this.pictureBoxSecond.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSecond.TabIndex = 6;
            this.pictureBoxSecond.TabStop = false;
            this.pictureBoxSecond.Click += new System.EventHandler(this.pictureBoxSecond_Click);
            // 
            // pictureBoxThird
            // 
            this.pictureBoxThird.Location = new System.Drawing.Point(455, 121);
            this.pictureBoxThird.Name = "pictureBoxThird";
            this.pictureBoxThird.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThird.TabIndex = 2;
            this.pictureBoxThird.TabStop = false;
            this.pictureBoxThird.Click += new System.EventHandler(this.pictureBoxThird_Click);
            // 
            // pictureBoxFirst
            // 
            this.pictureBoxFirst.Location = new System.Drawing.Point(12, 122);
            this.pictureBoxFirst.Name = "pictureBoxFirst";
            this.pictureBoxFirst.Size = new System.Drawing.Size(166, 166);
            this.pictureBoxFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirst.TabIndex = 0;
            this.pictureBoxFirst.TabStop = false;
            this.pictureBoxFirst.Click += new System.EventHandler(this.pictureBoxFirst_Click);
            // 
            // labelMaleFriend
            // 
            this.labelMaleFriend.AutoSize = true;
            this.labelMaleFriend.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaleFriend.Location = new System.Drawing.Point(14, 9);
            this.labelMaleFriend.Name = "labelMaleFriend";
            this.labelMaleFriend.Size = new System.Drawing.Size(242, 20);
            this.labelMaleFriend.TabIndex = 10;
            this.labelMaleFriend.Text = "The Most Responsive Male Friend:";
            // 
            // listBoxComments
            // 
            this.listBoxComments.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 20;
            this.listBoxComments.Location = new System.Drawing.Point(157, 346);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(319, 144);
            this.listBoxComments.TabIndex = 11;
            // 
            // labelFemaleFriend
            // 
            this.labelFemaleFriend.AutoSize = true;
            this.labelFemaleFriend.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemaleFriend.Location = new System.Drawing.Point(364, 9);
            this.labelFemaleFriend.Name = "labelFemaleFriend";
            this.labelFemaleFriend.Size = new System.Drawing.Size(257, 20);
            this.labelFemaleFriend.TabIndex = 12;
            this.labelFemaleFriend.Text = "The Most Responsive Female Friend:";
            // 
            // labelMaleFriendName
            // 
            this.labelMaleFriendName.AutoSize = true;
            this.labelMaleFriendName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaleFriendName.Location = new System.Drawing.Point(14, 50);
            this.labelMaleFriendName.Name = "labelMaleFriendName";
            this.labelMaleFriendName.Size = new System.Drawing.Size(97, 20);
            this.labelMaleFriendName.TabIndex = 13;
            this.labelMaleFriendName.Text = "[Male Name]";
            // 
            // labelFemaleFriendName
            // 
            this.labelFemaleFriendName.AutoSize = true;
            this.labelFemaleFriendName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemaleFriendName.Location = new System.Drawing.Point(364, 50);
            this.labelFemaleFriendName.Name = "labelFemaleFriendName";
            this.labelFemaleFriendName.Size = new System.Drawing.Size(112, 20);
            this.labelFemaleFriendName.TabIndex = 14;
            this.labelFemaleFriendName.Text = "[Female Name]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "(Click on picture to see it\'s comments)";
            // 
            // FormTopThreePhotos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFemaleFriendName);
            this.Controls.Add(this.labelMaleFriendName);
            this.Controls.Add(this.labelFemaleFriend);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.labelMaleFriend);
            this.Controls.Add(this.pictureBoxThirdPlace);
            this.Controls.Add(this.pictureBoxFirstPlace);
            this.Controls.Add(this.pictureBoxSecondPlace);
            this.Controls.Add(this.pictureBoxSecond);
            this.Controls.Add(this.labelLessLikesAmount);
            this.Controls.Add(this.labelMiddleLikesAmount);
            this.Controls.Add(this.labelMostLikesAmount);
            this.Controls.Add(this.pictureBoxThird);
            this.Controls.Add(this.pictureBoxFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTopThreePhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Top Three Photos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThirdPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecondPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFirst;
        private System.Windows.Forms.PictureBox pictureBoxThird;
        private System.Windows.Forms.Label labelMostLikesAmount;
        private System.Windows.Forms.Label labelMiddleLikesAmount;
        private System.Windows.Forms.Label labelLessLikesAmount;
        private System.Windows.Forms.PictureBox pictureBoxSecond;
        private System.Windows.Forms.PictureBox pictureBoxSecondPlace;
        private System.Windows.Forms.PictureBox pictureBoxFirstPlace;
        private System.Windows.Forms.PictureBox pictureBoxThirdPlace;
        private System.Windows.Forms.Label labelMaleFriend;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label labelFemaleFriend;
        private System.Windows.Forms.Label labelMaleFriendName;
        private System.Windows.Forms.Label labelFemaleFriendName;
        private System.Windows.Forms.Label label1;
    }
}