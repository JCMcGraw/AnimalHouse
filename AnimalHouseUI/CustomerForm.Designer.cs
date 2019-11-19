﻿namespace AnimalHouseUI
{
    partial class CustomerForm
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
            this.button_opret = new System.Windows.Forms.Button();
            this.label_dyr = new System.Windows.Forms.Label();
            this.label_headline = new System.Windows.Forms.Label();
            this.button_soeg = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.label_telefonnummer = new System.Windows.Forms.Label();
            this.button_rediger = new System.Windows.Forms.Button();
            this.button_slet = new System.Windows.Forms.Button();
            this.button_dyr = new System.Windows.Forms.Button();
            this.textBox_navn = new System.Windows.Forms.TextBox();
            this.label_navn = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
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
            this.PanelHeader.Size = new System.Drawing.Size(640, 36);
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
            this.ButtonMinimize.Location = new System.Drawing.Point(544, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(576, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(608, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // button_opret
            // 
            this.button_opret.BackColor = System.Drawing.Color.AliceBlue;
            this.button_opret.FlatAppearance.BorderSize = 0;
            this.button_opret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_opret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_opret.Location = new System.Drawing.Point(73, 351);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(118, 73);
            this.button_opret.TabIndex = 6;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = false;
            this.button_opret.Click += new System.EventHandler(this.button_opret_Click);
            // 
            // label_dyr
            // 
            this.label_dyr.AutoSize = true;
            this.label_dyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dyr.Location = new System.Drawing.Point(321, 109);
            this.label_dyr.Name = "label_dyr";
            this.label_dyr.Size = new System.Drawing.Size(33, 20);
            this.label_dyr.TabIndex = 7;
            this.label_dyr.Text = "Dyr";
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(35, 82);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(284, 47);
            this.label_headline.TabIndex = 8;
            this.label_headline.Text = "Administrer Kunde";
            // 
            // button_soeg
            // 
            this.button_soeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button_soeg.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_search_32px;
            this.button_soeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_soeg.FlatAppearance.BorderSize = 0;
            this.button_soeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_soeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_soeg.Location = new System.Drawing.Point(258, 175);
            this.button_soeg.Name = "button_soeg";
            this.button_soeg.Size = new System.Drawing.Size(45, 36);
            this.button_soeg.TabIndex = 9;
            this.button_soeg.UseVisualStyleBackColor = false;
            this.button_soeg.Click += new System.EventHandler(this.button_soeg_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button3.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_arrow_pointing_left_32px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(563, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 36);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(325, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 368);
            this.listBox1.TabIndex = 11;
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(121, 182);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(131, 20);
            this.textBox_phonenumber.TabIndex = 12;
            // 
            // label_telefonnummer
            // 
            this.label_telefonnummer.AutoSize = true;
            this.label_telefonnummer.Location = new System.Drawing.Point(35, 189);
            this.label_telefonnummer.Name = "label_telefonnummer";
            this.label_telefonnummer.Size = new System.Drawing.Size(80, 13);
            this.label_telefonnummer.TabIndex = 13;
            this.label_telefonnummer.Text = "Telefonnummer";
            // 
            // button_rediger
            // 
            this.button_rediger.BackColor = System.Drawing.Color.AliceBlue;
            this.button_rediger.Enabled = false;
            this.button_rediger.FlatAppearance.BorderSize = 0;
            this.button_rediger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rediger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rediger.Location = new System.Drawing.Point(196, 351);
            this.button_rediger.Name = "button_rediger";
            this.button_rediger.Size = new System.Drawing.Size(118, 73);
            this.button_rediger.TabIndex = 14;
            this.button_rediger.Text = "Rediger";
            this.button_rediger.UseVisualStyleBackColor = false;
            this.button_rediger.Click += new System.EventHandler(this.button_rediger_Click);
            // 
            // button_slet
            // 
            this.button_slet.BackColor = System.Drawing.Color.AliceBlue;
            this.button_slet.Enabled = false;
            this.button_slet.FlatAppearance.BorderSize = 0;
            this.button_slet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_slet.Location = new System.Drawing.Point(73, 430);
            this.button_slet.Name = "button_slet";
            this.button_slet.Size = new System.Drawing.Size(118, 73);
            this.button_slet.TabIndex = 15;
            this.button_slet.Text = "Slet";
            this.button_slet.UseVisualStyleBackColor = false;
            this.button_slet.Click += new System.EventHandler(this.button_slet_Click);
            // 
            // button_dyr
            // 
            this.button_dyr.BackColor = System.Drawing.Color.AliceBlue;
            this.button_dyr.Enabled = false;
            this.button_dyr.FlatAppearance.BorderSize = 0;
            this.button_dyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dyr.Location = new System.Drawing.Point(196, 430);
            this.button_dyr.Name = "button_dyr";
            this.button_dyr.Size = new System.Drawing.Size(118, 73);
            this.button_dyr.TabIndex = 16;
            this.button_dyr.Text = "Tilføj Dyr";
            this.button_dyr.UseVisualStyleBackColor = false;
            // 
            // textBox_navn
            // 
            this.textBox_navn.Location = new System.Drawing.Point(121, 237);
            this.textBox_navn.Name = "textBox_navn";
            this.textBox_navn.Size = new System.Drawing.Size(182, 20);
            this.textBox_navn.TabIndex = 17;
            // 
            // label_navn
            // 
            this.label_navn.AutoSize = true;
            this.label_navn.Location = new System.Drawing.Point(70, 237);
            this.label_navn.Name = "label_navn";
            this.label_navn.Size = new System.Drawing.Size(33, 13);
            this.label_navn.TabIndex = 18;
            this.label_navn.Text = "Navn";
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(70, 263);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(45, 13);
            this.label_adresse.TabIndex = 20;
            this.label_adresse.Text = "Adresse";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(121, 263);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(182, 20);
            this.textBox_adresse.TabIndex = 19;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(70, 289);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(35, 13);
            this.label_email.TabIndex = 22;
            this.label_email.Text = "E-mail";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(121, 289);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(182, 20);
            this.textBox_email.TabIndex = 21;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(640, 542);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.label_navn);
            this.Controls.Add(this.textBox_navn);
            this.Controls.Add(this.button_dyr);
            this.Controls.Add(this.button_slet);
            this.Controls.Add(this.button_rediger);
            this.Controls.Add(this.label_telefonnummer);
            this.Controls.Add(this.textBox_phonenumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_soeg);
            this.Controls.Add(this.label_headline);
            this.Controls.Add(this.label_dyr);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
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
        private System.Windows.Forms.Button button_opret;
        private System.Windows.Forms.Label label_dyr;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Button button_soeg;
        private System.Windows.Forms.Button button3;
        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Label label_telefonnummer;
        private System.Windows.Forms.Button button_rediger;
        private System.Windows.Forms.Button button_slet;
        private System.Windows.Forms.Button button_dyr;
        private System.Windows.Forms.TextBox textBox_navn;
        private System.Windows.Forms.Label label_navn;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
    }
}