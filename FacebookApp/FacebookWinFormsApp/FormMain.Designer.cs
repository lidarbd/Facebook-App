namespace FacebookWinFormsApp
{
    public partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonTopThreePhotos = new System.Windows.Forms.Button();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.pictureBoxTopProfilePictures = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.pictureBoxPosts = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopProfilePictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonLogout.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(13, 492);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 34);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostStatus.Location = new System.Drawing.Point(10, 296);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(90, 19);
            this.labelPostStatus.TabIndex = 54;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(100, 296);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(343, 22);
            this.textBoxStatus.TabIndex = 55;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetStatus.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStatus.Location = new System.Drawing.Point(449, 294);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(70, 27);
            this.buttonSetStatus.TabIndex = 56;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlbums.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbums.Location = new System.Drawing.Point(548, 254);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(177, 32);
            this.buttonAlbums.TabIndex = 60;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLikedPages.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLikedPages.Location = new System.Drawing.Point(548, 367);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(177, 32);
            this.buttonLikedPages.TabIndex = 62;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvents.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.Location = new System.Drawing.Point(548, 329);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(177, 32);
            this.buttonEvents.TabIndex = 63;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGroups.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.Location = new System.Drawing.Point(548, 404);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(177, 31);
            this.buttonGroups.TabIndex = 64;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFavoriteTeams.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(548, 441);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(177, 31);
            this.buttonFavoriteTeams.TabIndex = 65;
            this.buttonFavoriteTeams.Text = "Favorite Teams";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFriends.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriends.Location = new System.Drawing.Point(548, 292);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(177, 31);
            this.buttonFriends.TabIndex = 69;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonTopThreePhotos
            // 
            this.buttonTopThreePhotos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTopThreePhotos.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopThreePhotos.Location = new System.Drawing.Point(548, 478);
            this.buttonTopThreePhotos.Name = "buttonTopThreePhotos";
            this.buttonTopThreePhotos.Size = new System.Drawing.Size(177, 48);
            this.buttonTopThreePhotos.TabIndex = 71;
            this.buttonTopThreePhotos.Text = "Top 3 Profile\r\n Pictures";
            this.buttonTopThreePhotos.UseVisualStyleBackColor = true;
            this.buttonTopThreePhotos.Click += new System.EventHandler(this.buttonTopThreePhotos_Click);
            // 
            // buttonPosts
            // 
            this.buttonPosts.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonPosts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPosts.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosts.Location = new System.Drawing.Point(548, 216);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(177, 32);
            this.buttonPosts.TabIndex = 72;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = false;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelLogin.Location = new System.Drawing.Point(13, 13);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(67, 27);
            this.labelLogin.TabIndex = 74;
            this.labelLogin.Text = "label1";
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackground.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackground.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackground.Location = new System.Drawing.Point(12, 335);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(225, 32);
            this.buttonBackground.TabIndex = 83;
            this.buttonBackground.Text = "Change Background";
            this.buttonBackground.UseVisualStyleBackColor = false;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // pictureBoxTopProfilePictures
            // 
            this.pictureBoxTopProfilePictures.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.podium;
            this.pictureBoxTopProfilePictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTopProfilePictures.Location = new System.Drawing.Point(556, 492);
            this.pictureBoxTopProfilePictures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTopProfilePictures.Name = "pictureBoxTopProfilePictures";
            this.pictureBoxTopProfilePictures.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxTopProfilePictures.TabIndex = 82;
            this.pictureBoxTopProfilePictures.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.partnership;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(556, 446);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 20);
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.group;
            this.pictureBoxGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGroups.Location = new System.Drawing.Point(556, 410);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxGroups.TabIndex = 80;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.like;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(556, 375);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 20);
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.event_note;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(555, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.collaboration;
            this.pictureBoxFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriends.Location = new System.Drawing.Point(556, 299);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxFriends.TabIndex = 77;
            this.pictureBoxFriends.TabStop = false;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.album;
            this.pictureBoxAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlbums.Location = new System.Drawing.Point(556, 261);
            this.pictureBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxAlbums.TabIndex = 76;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // pictureBoxPosts
            // 
            this.pictureBoxPosts.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPosts.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.message;
            this.pictureBoxPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPosts.Location = new System.Drawing.Point(556, 222);
            this.pictureBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPosts.Name = "pictureBoxPosts";
            this.pictureBoxPosts.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxPosts.TabIndex = 75;
            this.pictureBoxPosts.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.Location = new System.Drawing.Point(13, 50);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(505, 236);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 73;
            this.pictureBoxCover.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(548, 50);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(177, 157);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(18, 339);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 84;
            this.pictureBox4.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 536);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.pictureBoxTopProfilePictures);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxGroups);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.pictureBoxAlbums);
            this.Controls.Add(this.pictureBoxPosts);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.buttonPosts);
            this.Controls.Add(this.buttonTopThreePhotos);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonFavoriteTeams);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonAlbums);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopProfilePictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonTopThreePhotos;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxTopProfilePictures;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}