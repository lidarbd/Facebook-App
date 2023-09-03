namespace FacebookWinFormsApp
{
    public partial class FormEvents
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
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label nameLabel4;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label descriptionLabel2;
            System.Windows.Forms.Label endTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvents));
            this.labelEvent = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            locationLabel = new System.Windows.Forms.Label();
            nameLabel4 = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(15, 113);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(66, 17);
            locationLabel.TabIndex = 61;
            locationLabel.Text = "Location:";
            // 
            // nameLabel4
            // 
            nameLabel4.AutoSize = true;
            nameLabel4.Location = new System.Drawing.Point(15, 12);
            nameLabel4.Name = "nameLabel4";
            nameLabel4.Size = new System.Drawing.Size(49, 17);
            nameLabel4.TabIndex = 63;
            nameLabel4.Text = "Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(15, 148);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(77, 17);
            startTimeLabel.TabIndex = 65;
            startTimeLabel.Text = "Start Time:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Location = new System.Drawing.Point(15, 46);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(83, 17);
            descriptionLabel2.TabIndex = 66;
            descriptionLabel2.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(15, 184);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(72, 17);
            endTimeLabel.TabIndex = 70;
            endTimeLabel.Text = "End Time:";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvent.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelEvent.Location = new System.Drawing.Point(376, 9);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(138, 45);
            this.labelEvent.TabIndex = 51;
            this.labelEvent.Text = "Events \r\n";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 18;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 66);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(422, 220);
            this.listBoxEvents.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(endTimeLabel);
            this.panel1.Controls.Add(this.endTimeDateTimePicker);
            this.panel1.Controls.Add(descriptionLabel2);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.labelLocation);
            this.panel1.Controls.Add(nameLabel4);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(startTimeLabel);
            this.panel1.Controls.Add(this.startTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(450, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 221);
            this.panel1.TabIndex = 55;
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Enabled = false;
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(151, 179);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(219, 22);
            this.endTimeDateTimePicker.TabIndex = 71;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(151, 43);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(146, 59);
            this.descriptionTextBox.TabIndex = 67;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(323, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(96, 88);
            this.imageNormalPictureBox.TabIndex = 60;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // labelLocation
            // 
            this.labelLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.labelLocation.Location = new System.Drawing.Point(151, 113);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(97, 23);
            this.labelLocation.TabIndex = 62;
            this.labelLocation.Text = "labelLocation";
            // 
            // nameLabel
            // 
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel.Location = new System.Drawing.Point(151, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 23);
            this.nameLabel.TabIndex = 64;
            this.nameLabel.Text = "labelName";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Enabled = false;
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(151, 144);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(219, 22);
            this.startTimeDateTimePicker.TabIndex = 66;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvents";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
    }
}