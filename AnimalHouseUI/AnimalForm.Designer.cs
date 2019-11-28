namespace AnimalHouseUI
{
    partial class AnimalForm
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
            this.AnimalName_Label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.animal_name = new System.Windows.Forms.TextBox();
            this.label_telefonnummer = new System.Windows.Forms.Label();
            this.button_rediger = new System.Windows.Forms.Button();
            this.button_slet = new System.Windows.Forms.Button();
            this.label_navn = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.animal_weight = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animalAge_label = new System.Windows.Forms.Label();
            this.owner_label = new System.Windows.Forms.Label();
            this.animal_species = new System.Windows.Forms.ComboBox();
            this.animal_employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.animal_gender = new System.Windows.Forms.ComboBox();
            this.animal_bdate = new System.Windows.Forms.DateTimePicker();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PanelHeader.Size = new System.Drawing.Size(730, 36);
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
            this.LabelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
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
            this.ButtonMinimize.Location = new System.Drawing.Point(634, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(666, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(698, 2);
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
            this.button_opret.Location = new System.Drawing.Point(167, 420);
            this.button_opret.Name = "button_opret";
            this.button_opret.Size = new System.Drawing.Size(118, 73);
            this.button_opret.TabIndex = 6;
            this.button_opret.Text = "Opret";
            this.button_opret.UseVisualStyleBackColor = false;
            this.button_opret.Click += new System.EventHandler(this.Button_opret_Click_1);
            // 
            // label_dyr
            // 
            this.label_dyr.AutoSize = true;
            this.label_dyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dyr.Location = new System.Drawing.Point(431, 59);
            this.label_dyr.Name = "label_dyr";
            this.label_dyr.Size = new System.Drawing.Size(61, 20);
            this.label_dyr.TabIndex = 7;
            this.label_dyr.Text = "Journal";
            // 
            // AnimalName_Label
            // 
            this.AnimalName_Label.AutoSize = true;
            this.AnimalName_Label.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalName_Label.Location = new System.Drawing.Point(36, 67);
            this.AnimalName_Label.Name = "AnimalName_Label";
            this.AnimalName_Label.Size = new System.Drawing.Size(91, 47);
            this.AnimalName_Label.TabIndex = 8;
            this.AnimalName_Label.Text = "Navn";
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
            this.listBox1.Location = new System.Drawing.Point(435, 372);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 121);
            this.listBox1.TabIndex = 11;
            // 
            // animal_name
            // 
            this.animal_name.Location = new System.Drawing.Point(44, 268);
            this.animal_name.Name = "animal_name";
            this.animal_name.Size = new System.Drawing.Size(99, 20);
            this.animal_name.TabIndex = 12;
            // 
            // label_telefonnummer
            // 
            this.label_telefonnummer.AutoSize = true;
            this.label_telefonnummer.Location = new System.Drawing.Point(46, 343);
            this.label_telefonnummer.Name = "label_telefonnummer";
            this.label_telefonnummer.Size = new System.Drawing.Size(20, 13);
            this.label_telefonnummer.TabIndex = 13;
            this.label_telefonnummer.Text = "Art";
            // 
            // button_rediger
            // 
            this.button_rediger.BackColor = System.Drawing.Color.AliceBlue;
            this.button_rediger.Enabled = false;
            this.button_rediger.FlatAppearance.BorderSize = 0;
            this.button_rediger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rediger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rediger.Location = new System.Drawing.Point(291, 420);
            this.button_rediger.Name = "button_rediger";
            this.button_rediger.Size = new System.Drawing.Size(118, 73);
            this.button_rediger.TabIndex = 14;
            this.button_rediger.Text = "Rediger";
            this.button_rediger.UseVisualStyleBackColor = false;
            this.button_rediger.Click += new System.EventHandler(this.Button_rediger_Click);
            // 
            // button_slet
            // 
            this.button_slet.BackColor = System.Drawing.Color.AliceBlue;
            this.button_slet.Enabled = false;
            this.button_slet.FlatAppearance.BorderSize = 0;
            this.button_slet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_slet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_slet.Location = new System.Drawing.Point(43, 420);
            this.button_slet.Name = "button_slet";
            this.button_slet.Size = new System.Drawing.Size(118, 73);
            this.button_slet.TabIndex = 15;
            this.button_slet.Text = "Slet";
            this.button_slet.UseVisualStyleBackColor = false;
            this.button_slet.Click += new System.EventHandler(this.Button_slet_Click);
            // 
            // label_navn
            // 
            this.label_navn.AutoSize = true;
            this.label_navn.Location = new System.Drawing.Point(165, 299);
            this.label_navn.Name = "label_navn";
            this.label_navn.Size = new System.Drawing.Size(33, 13);
            this.label_navn.TabIndex = 18;
            this.label_navn.Text = "Vægt";
            // 
            // label_adresse
            // 
            this.label_adresse.AutoSize = true;
            this.label_adresse.Location = new System.Drawing.Point(164, 252);
            this.label_adresse.Name = "label_adresse";
            this.label_adresse.Size = new System.Drawing.Size(61, 13);
            this.label_adresse.TabIndex = 20;
            this.label_adresse.Text = "Fødselsdag";
            // 
            // animal_weight
            // 
            this.animal_weight.Location = new System.Drawing.Point(167, 315);
            this.animal_weight.Name = "animal_weight";
            this.animal_weight.Size = new System.Drawing.Size(99, 20);
            this.animal_weight.TabIndex = 19;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(46, 298);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(26, 13);
            this.label_email.TabIndex = 22;
            this.label_email.Text = "Køn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(79, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Art,";
            // 
            // animalAge_label
            // 
            this.animalAge_label.AutoSize = true;
            this.animalAge_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.animalAge_label.Location = new System.Drawing.Point(41, 109);
            this.animalAge_label.Name = "animalAge_label";
            this.animalAge_label.Size = new System.Drawing.Size(41, 17);
            this.animalAge_label.TabIndex = 28;
            this.animalAge_label.Text = "Alder";
            // 
            // owner_label
            // 
            this.owner_label.AutoSize = true;
            this.owner_label.Location = new System.Drawing.Point(41, 135);
            this.owner_label.Name = "owner_label";
            this.owner_label.Size = new System.Drawing.Size(25, 13);
            this.owner_label.TabIndex = 29;
            this.owner_label.Text = "Ejer";
            // 
            // animal_species
            // 
            this.animal_species.FormattingEnabled = true;
            this.animal_species.Items.AddRange(new object[] {
            "Hund",
            "Kat",
            "Kanin",
            "Marsvin",
            "Hamster",
            "Kanariefugl",
            "Papegøje",
            "Slange",
            "Skildpadde"});
            this.animal_species.Location = new System.Drawing.Point(44, 361);
            this.animal_species.Name = "animal_species";
            this.animal_species.Size = new System.Drawing.Size(99, 21);
            this.animal_species.TabIndex = 30;
            this.animal_species.SelectedIndexChanged += new System.EventHandler(this.Animal_species_SelectedIndexChanged);
            // 
            // animal_employee
            // 
            this.animal_employee.FormattingEnabled = true;
            this.animal_employee.Items.AddRange(new object[] {
            "Hund",
            "Kat",
            "Kanin",
            "Marsvin",
            "Hamster",
            "Kanariefugl",
            "Papegøje",
            "Slange",
            "Skildpadde"});
            this.animal_employee.Location = new System.Drawing.Point(169, 361);
            this.animal_employee.Name = "animal_employee";
            this.animal_employee.Size = new System.Drawing.Size(99, 21);
            this.animal_employee.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Behandler";
            // 
            // animal_gender
            // 
            this.animal_gender.FormattingEnabled = true;
            this.animal_gender.Items.AddRange(new object[] {
            "han",
            "hun"});
            this.animal_gender.Location = new System.Drawing.Point(44, 315);
            this.animal_gender.Name = "animal_gender";
            this.animal_gender.Size = new System.Drawing.Size(99, 21);
            this.animal_gender.TabIndex = 33;
            this.animal_gender.SelectedIndexChanged += new System.EventHandler(this.Animal_gender_SelectedIndexChanged);
            // 
            // animal_bdate
            // 
            this.animal_bdate.Location = new System.Drawing.Point(169, 268);
            this.animal_bdate.Name = "animal_bdate";
            this.animal_bdate.Size = new System.Drawing.Size(98, 20);
            this.animal_bdate.TabIndex = 34;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(435, 82);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(283, 264);
            this.listBox2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Recepter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 121);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(730, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.animal_bdate);
            this.Controls.Add(this.animal_gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.animal_employee);
            this.Controls.Add(this.animal_species);
            this.Controls.Add(this.owner_label);
            this.Controls.Add(this.animalAge_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.animal_weight);
            this.Controls.Add(this.label_navn);
            this.Controls.Add(this.button_slet);
            this.Controls.Add(this.button_rediger);
            this.Controls.Add(this.label_telefonnummer);
            this.Controls.Add(this.animal_name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AnimalName_Label);
            this.Controls.Add(this.label_dyr);
            this.Controls.Add(this.button_opret);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimalForm";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label AnimalName_Label;
        private System.Windows.Forms.Button button3;
        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox animal_name;
        private System.Windows.Forms.Label label_telefonnummer;
        private System.Windows.Forms.Button button_rediger;
        private System.Windows.Forms.Button button_slet;
        private System.Windows.Forms.Label label_navn;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.TextBox animal_weight;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label animalAge_label;
        private System.Windows.Forms.Label owner_label;
        private System.Windows.Forms.ComboBox animal_species;
        private System.Windows.Forms.ComboBox animal_employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox animal_gender;
        private System.Windows.Forms.DateTimePicker animal_bdate;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion
}
