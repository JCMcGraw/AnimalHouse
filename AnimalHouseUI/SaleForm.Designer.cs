namespace AnimalHouseUI
{
    partial class SaleForm
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.TelefonLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.SearchPhoneButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FakturaButton = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaleListBox = new System.Windows.Forms.ListBox();
            this.SearchMedicalButton = new System.Windows.Forms.Button();
            this.MedicalTextBox = new System.Windows.Forms.TextBox();
            this.MedicalListBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MomsLabel = new System.Windows.Forms.Label();
            this.TotalInkMomsLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.UpdateMedecinLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
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
            this.PanelHeader.Size = new System.Drawing.Size(873, 36);
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
            this.LabelTitle.Location = new System.Drawing.Point(309, 3);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(162, 29);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Animal House";
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
            this.ButtonMinimize.Location = new System.Drawing.Point(777, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(809, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(841, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // EndButton
            // 
            this.EndButton.BackColor = System.Drawing.Color.AliceBlue;
            this.EndButton.FlatAppearance.BorderSize = 0;
            this.EndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndButton.Location = new System.Drawing.Point(363, 540);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(92, 48);
            this.EndButton.TabIndex = 6;
            this.EndButton.Text = "Afslut";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // TelefonLabel
            // 
            this.TelefonLabel.AutoSize = true;
            this.TelefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonLabel.Location = new System.Drawing.Point(38, 135);
            this.TelefonLabel.Name = "TelefonLabel";
            this.TelefonLabel.Size = new System.Drawing.Size(63, 20);
            this.TelefonLabel.TabIndex = 7;
            this.TelefonLabel.Text = "Sample";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(35, 82);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(308, 47);
            this.CustomerNameLabel.TabIndex = 8;
            this.CustomerNameLabel.Text = "Sample Kunde Name";
            // 
            // SearchPhoneButton
            // 
            this.SearchPhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.SearchPhoneButton.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_search_32px;
            this.SearchPhoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchPhoneButton.FlatAppearance.BorderSize = 0;
            this.SearchPhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPhoneButton.Location = new System.Drawing.Point(172, 185);
            this.SearchPhoneButton.Name = "SearchPhoneButton";
            this.SearchPhoneButton.Size = new System.Drawing.Size(31, 28);
            this.SearchPhoneButton.TabIndex = 9;
            this.SearchPhoneButton.UseVisualStyleBackColor = false;
            this.SearchPhoneButton.Click += new System.EventHandler(this.SearchPhoneButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button3.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_arrow_pointing_left_32px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 561);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 36);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FakturaButton
            // 
            this.FakturaButton.BackColor = System.Drawing.Color.AliceBlue;
            this.FakturaButton.FlatAppearance.BorderSize = 0;
            this.FakturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FakturaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturaButton.Location = new System.Drawing.Point(486, 540);
            this.FakturaButton.Name = "FakturaButton";
            this.FakturaButton.Size = new System.Drawing.Size(92, 48);
            this.FakturaButton.TabIndex = 11;
            this.FakturaButton.Text = "Faktura";
            this.FakturaButton.UseVisualStyleBackColor = false;
            this.FakturaButton.Click += new System.EventHandler(this.FakturaButton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(43, 193);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(123, 20);
            this.PhoneTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(42, 244);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(124, 20);
            this.NameTextBox.TabIndex = 14;
            // 
            // SaleListBox
            // 
            this.SaleListBox.FormattingEnabled = true;
            this.SaleListBox.Location = new System.Drawing.Point(363, 123);
            this.SaleListBox.Name = "SaleListBox";
            this.SaleListBox.Size = new System.Drawing.Size(215, 316);
            this.SaleListBox.TabIndex = 15;
            // 
            // SearchMedicalButton
            // 
            this.SearchMedicalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.SearchMedicalButton.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_search_32px;
            this.SearchMedicalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchMedicalButton.FlatAppearance.BorderSize = 0;
            this.SearchMedicalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchMedicalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMedicalButton.Location = new System.Drawing.Point(798, 82);
            this.SearchMedicalButton.Name = "SearchMedicalButton";
            this.SearchMedicalButton.Size = new System.Drawing.Size(29, 30);
            this.SearchMedicalButton.TabIndex = 19;
            this.SearchMedicalButton.UseVisualStyleBackColor = false;
            this.SearchMedicalButton.Click += new System.EventHandler(this.SearchMedicalButton_Click);
            // 
            // MedicalTextBox
            // 
            this.MedicalTextBox.Location = new System.Drawing.Point(636, 92);
            this.MedicalTextBox.Name = "MedicalTextBox";
            this.MedicalTextBox.Size = new System.Drawing.Size(156, 20);
            this.MedicalTextBox.TabIndex = 20;
            // 
            // MedicalListBox
            // 
            this.MedicalListBox.FormattingEnabled = true;
            this.MedicalListBox.Location = new System.Drawing.Point(636, 123);
            this.MedicalListBox.Name = "MedicalListBox";
            this.MedicalListBox.Size = new System.Drawing.Size(200, 316);
            this.MedicalListBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Telefon";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Navn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total";
            // 
            // MomsLabel
            // 
            this.MomsLabel.AutoSize = true;
            this.MomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MomsLabel.Location = new System.Drawing.Point(522, 484);
            this.MomsLabel.Name = "MomsLabel";
            this.MomsLabel.Size = new System.Drawing.Size(24, 13);
            this.MomsLabel.TabIndex = 33;
            this.MomsLabel.Text = "Pris";
            // 
            // TotalInkMomsLabel
            // 
            this.TotalInkMomsLabel.AutoSize = true;
            this.TotalInkMomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInkMomsLabel.Location = new System.Drawing.Point(522, 511);
            this.TotalInkMomsLabel.Name = "TotalInkMomsLabel";
            this.TotalInkMomsLabel.Size = new System.Drawing.Size(24, 13);
            this.TotalInkMomsLabel.TabIndex = 34;
            this.TotalInkMomsLabel.Text = "Pris";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(371, 511);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Total Inkl Moms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(371, 484);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Moms";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(522, 460);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(24, 13);
            this.TotalPriceLabel.TabIndex = 37;
            this.TotalPriceLabel.Text = "Pris";
            // 
            // UpdateMedecinLabel
            // 
            this.UpdateMedecinLabel.AutoSize = true;
            this.UpdateMedecinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMedecinLabel.Location = new System.Drawing.Point(633, 460);
            this.UpdateMedecinLabel.Name = "UpdateMedecinLabel";
            this.UpdateMedecinLabel.Size = new System.Drawing.Size(194, 13);
            this.UpdateMedecinLabel.TabIndex = 38;
            this.UpdateMedecinLabel.Text = "Dato for sidste opdateret mececin priser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Vare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Antal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Pris";
            // 
            // SaleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(873, 609);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateMedecinLabel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TotalInkMomsLabel);
            this.Controls.Add(this.MomsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MedicalListBox);
            this.Controls.Add(this.MedicalTextBox);
            this.Controls.Add(this.SearchMedicalButton);
            this.Controls.Add(this.SaleListBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.FakturaButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchPhoneButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.TelefonLabel);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleUI";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.SaleUI_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonMaximize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label TelefonLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button SearchPhoneButton;
        private System.Windows.Forms.Button button3;
        #endregion

        private System.Windows.Forms.Button FakturaButton;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox SaleListBox;
        private System.Windows.Forms.Button SearchMedicalButton;
        private System.Windows.Forms.TextBox MedicalTextBox;
        private System.Windows.Forms.ListBox MedicalListBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MomsLabel;
        private System.Windows.Forms.Label TotalInkMomsLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label UpdateMedecinLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }

}
