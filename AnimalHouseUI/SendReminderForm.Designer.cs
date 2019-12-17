namespace AnimalHouseUI
{
    partial class SendReminderForm
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

        #region Copy this
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendReminderForm));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.GetRemindersToSend = new System.Windows.Forms.Button();
            this.RemindersDataGridView = new System.Windows.Forms.DataGridView();
            this.SendToChosenButton = new System.Windows.Forms.Button();
            this.SendToAllButton = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatestVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemindersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.LightSlateGray;
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.Controls.Add(this.PictureBoxLogo);
            this.PanelHeader.Controls.Add(this.ButtonMinimize);
            this.PanelHeader.Controls.Add(this.ButtonMaximize);
            this.PanelHeader.Controls.Add(this.ButtonClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.PanelHeader.Size = new System.Drawing.Size(801, 36);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(272, 2);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(210, 29);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Send påmindelser";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.LabelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            this.LabelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseUp);
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxLogo.Image = global::AnimalHouseUI.Properties.Resources.dog_sit_64px;
            this.PictureBoxLogo.Location = new System.Drawing.Point(0, 2);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(50, 32);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 1;
            this.PictureBoxLogo.TabStop = false;
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMinimize.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_minimize_window_32px;
            this.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinimize.Location = new System.Drawing.Point(705, 2);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(32, 32);
            this.ButtonMinimize.TabIndex = 3;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonMaximize
            // 
            this.ButtonMaximize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMaximize.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_maximize_button_32px;
            this.ButtonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMaximize.FlatAppearance.BorderSize = 0;
            this.ButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMaximize.Location = new System.Drawing.Point(737, 2);
            this.ButtonMaximize.Name = "ButtonMaximize";
            this.ButtonMaximize.Size = new System.Drawing.Size(32, 32);
            this.ButtonMaximize.TabIndex = 2;
            this.ButtonMaximize.UseVisualStyleBackColor = true;
            this.ButtonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonClose.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_close_window_32px;
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.Location = new System.Drawing.Point(769, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // GetRemindersToSend
            // 
            this.GetRemindersToSend.BackColor = System.Drawing.Color.AliceBlue;
            this.GetRemindersToSend.FlatAppearance.BorderSize = 0;
            this.GetRemindersToSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetRemindersToSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRemindersToSend.Location = new System.Drawing.Point(639, 86);
            this.GetRemindersToSend.Name = "GetRemindersToSend";
            this.GetRemindersToSend.Size = new System.Drawing.Size(118, 73);
            this.GetRemindersToSend.TabIndex = 6;
            this.GetRemindersToSend.Text = "Hent kunder til påmindelse";
            this.GetRemindersToSend.UseVisualStyleBackColor = false;
            this.GetRemindersToSend.Click += new System.EventHandler(this.GetRemindersToSend_Click);
            // 
            // RemindersDataGridView
            // 
            this.RemindersDataGridView.AllowUserToAddRows = false;
            this.RemindersDataGridView.AllowUserToDeleteRows = false;
            this.RemindersDataGridView.AllowUserToResizeRows = false;
            this.RemindersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RemindersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemindersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.Email,
            this.Animal,
            this.Species,
            this.LatestVisit});
            this.RemindersDataGridView.Location = new System.Drawing.Point(41, 65);
            this.RemindersDataGridView.Name = "RemindersDataGridView";
            this.RemindersDataGridView.ReadOnly = true;
            this.RemindersDataGridView.RowHeadersVisible = false;
            this.RemindersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RemindersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RemindersDataGridView.Size = new System.Drawing.Size(556, 380);
            this.RemindersDataGridView.TabIndex = 7;
            // 
            // SendToChosenButton
            // 
            this.SendToChosenButton.BackColor = System.Drawing.Color.AliceBlue;
            this.SendToChosenButton.FlatAppearance.BorderSize = 0;
            this.SendToChosenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendToChosenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToChosenButton.Location = new System.Drawing.Point(639, 271);
            this.SendToChosenButton.Name = "SendToChosenButton";
            this.SendToChosenButton.Size = new System.Drawing.Size(118, 73);
            this.SendToChosenButton.TabIndex = 8;
            this.SendToChosenButton.Text = "Send til valgte";
            this.SendToChosenButton.UseVisualStyleBackColor = false;
            this.SendToChosenButton.Click += new System.EventHandler(this.SendToChosenButton_Click);
            // 
            // SendToAllButton
            // 
            this.SendToAllButton.BackColor = System.Drawing.Color.AliceBlue;
            this.SendToAllButton.FlatAppearance.BorderSize = 0;
            this.SendToAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendToAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToAllButton.Location = new System.Drawing.Point(639, 178);
            this.SendToAllButton.Name = "SendToAllButton";
            this.SendToAllButton.Size = new System.Drawing.Size(118, 73);
            this.SendToAllButton.TabIndex = 9;
            this.SendToAllButton.Text = "Send til alle";
            this.SendToAllButton.UseVisualStyleBackColor = false;
            this.SendToAllButton.Click += new System.EventHandler(this.SendToAllButton_Click);
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Kunde";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Animal
            // 
            this.Animal.HeaderText = "Dyr";
            this.Animal.Name = "Animal";
            this.Animal.ReadOnly = true;
            // 
            // Species
            // 
            this.Species.HeaderText = "Dyreart";
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            // 
            // LatestVisit
            // 
            this.LatestVisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LatestVisit.HeaderText = "Sidste behandling";
            this.LatestVisit.Name = "LatestVisit";
            this.LatestVisit.ReadOnly = true;
            // 
            // SendReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(801, 521);
            this.Controls.Add(this.SendToAllButton);
            this.Controls.Add(this.SendToChosenButton);
            this.Controls.Add(this.RemindersDataGridView);
            this.Controls.Add(this.GetRemindersToSend);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendReminderForm";
            this.Text = "Send påmindelser";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemindersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonMaximize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button GetRemindersToSend;
        #endregion

        private System.Windows.Forms.DataGridView RemindersDataGridView;
        private System.Windows.Forms.Button SendToChosenButton;
        private System.Windows.Forms.Button SendToAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Species;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatestVisit;
    }
}