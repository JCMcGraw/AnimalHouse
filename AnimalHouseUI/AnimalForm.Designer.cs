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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.label_dyr = new System.Windows.Forms.Label();
            this.AnimalName_Label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.animal_name = new System.Windows.Forms.TextBox();
            this.label_telefonnummer = new System.Windows.Forms.Label();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_navn = new System.Windows.Forms.Label();
            this.label_adresse = new System.Windows.Forms.Label();
            this.animal_weight = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.animalSpecies_label = new System.Windows.Forms.Label();
            this.animal_owner = new System.Windows.Forms.Label();
            this.animal_species = new System.Windows.Forms.ComboBox();
            this.animal_employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.animal_gender = new System.Windows.Forms.ComboBox();
            this.animal_bdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.animal_prescription = new System.Windows.Forms.DataGridView();
            this.animal_medicalRecords = new System.Windows.Forms.DataGridView();
            this.button_help = new System.Windows.Forms.Button();
            this.label_hjaelp = new System.Windows.Forms.Label();
            this.MR_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_prescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_medicalRecords)).BeginInit();
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
            this.PanelHeader.Size = new System.Drawing.Size(800, 36);
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
            this.ButtonMinimize.Location = new System.Drawing.Point(704, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(736, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(768, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.AliceBlue;
            this.button_create.FlatAppearance.BorderSize = 0;
            this.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_create.Location = new System.Drawing.Point(167, 420);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(118, 73);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Opret";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.Button_opret_Click_1);
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
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.AliceBlue;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(291, 420);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(118, 73);
            this.button_edit.TabIndex = 14;
            this.button_edit.Text = "Rediger";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.Button_rediger_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.AliceBlue;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(43, 420);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(118, 73);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "Slet";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_slet_Click);
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
            // animalSpecies_label
            // 
            this.animalSpecies_label.AutoSize = true;
            this.animalSpecies_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.animalSpecies_label.Location = new System.Drawing.Point(41, 114);
            this.animalSpecies_label.Name = "animalSpecies_label";
            this.animalSpecies_label.Size = new System.Drawing.Size(30, 17);
            this.animalSpecies_label.TabIndex = 27;
            this.animalSpecies_label.Text = "Art,";
            // 
            // animal_owner
            // 
            this.animal_owner.AutoSize = true;
            this.animal_owner.Location = new System.Drawing.Point(41, 131);
            this.animal_owner.Name = "animal_owner";
            this.animal_owner.Size = new System.Drawing.Size(25, 13);
            this.animal_owner.TabIndex = 29;
            this.animal_owner.Text = "Ejer";
            // 
            // animal_species
            // 
            this.animal_species.FormattingEnabled = true;
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
            this.animal_employee.SelectedIndexChanged += new System.EventHandler(this.Animal_employee_SelectedIndexChanged);
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
            // animal_prescription
            // 
            this.animal_prescription.AllowUserToAddRows = false;
            this.animal_prescription.AllowUserToDeleteRows = false;
            this.animal_prescription.AllowUserToResizeColumns = false;
            this.animal_prescription.AllowUserToResizeRows = false;
            this.animal_prescription.BackgroundColor = System.Drawing.Color.White;
            this.animal_prescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animal_prescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.amount,
            this.date});
            this.animal_prescription.Location = new System.Drawing.Point(435, 373);
            this.animal_prescription.Name = "animal_prescription";
            this.animal_prescription.RowHeadersVisible = false;
            this.animal_prescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.animal_prescription.Size = new System.Drawing.Size(301, 129);
            this.animal_prescription.TabIndex = 37;
            // 
            // animal_medicalRecords
            // 
            this.animal_medicalRecords.AllowUserToAddRows = false;
            this.animal_medicalRecords.AllowUserToDeleteRows = false;
            this.animal_medicalRecords.AllowUserToResizeColumns = false;
            this.animal_medicalRecords.AllowUserToResizeRows = false;
            this.animal_medicalRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.animal_medicalRecords.BackgroundColor = System.Drawing.Color.White;
            this.animal_medicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animal_medicalRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MR_date,
            this.title});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.animal_medicalRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.animal_medicalRecords.Location = new System.Drawing.Point(435, 83);
            this.animal_medicalRecords.Name = "animal_medicalRecords";
            this.animal_medicalRecords.ReadOnly = true;
            this.animal_medicalRecords.RowHeadersVisible = false;
            this.animal_medicalRecords.Size = new System.Drawing.Size(263, 252);
            this.animal_medicalRecords.TabIndex = 38;
            this.animal_medicalRecords.DoubleClick += new System.EventHandler(this.animal_medicalRecords_DoubleClick);
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button_help.BackgroundImage = global::AnimalHouseUI.Properties.Resources.question_mark_32px;
            this.button_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_help.FlatAppearance.BorderSize = 0;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_help.Location = new System.Drawing.Point(736, 43);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(45, 36);
            this.button_help.TabIndex = 29;
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.Button_help_Click);
            // 
            // label_hjaelp
            // 
            this.label_hjaelp.AutoSize = true;
            this.label_hjaelp.Location = new System.Drawing.Point(741, 81);
            this.label_hjaelp.Name = "label_hjaelp";
            this.label_hjaelp.Size = new System.Drawing.Size(35, 13);
            this.label_hjaelp.TabIndex = 39;
            this.label_hjaelp.Text = "Hjælp";
            // 
            // MR_date
            // 
            this.MR_date.HeaderText = "Dato";
            this.MR_date.Name = "MR_date";
            this.MR_date.ReadOnly = true;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Titel";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Medicin";
            this.name.Name = "name";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amount.HeaderText = "Antal";
            this.amount.Name = "amount";
            this.amount.Width = 56;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Dato";
            this.date.Name = "date";
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.label_hjaelp);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.animal_medicalRecords);
            this.Controls.Add(this.animal_prescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animal_bdate);
            this.Controls.Add(this.animal_gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.animal_employee);
            this.Controls.Add(this.animal_species);
            this.Controls.Add(this.animal_owner);
            this.Controls.Add(this.animalSpecies_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_adresse);
            this.Controls.Add(this.animal_weight);
            this.Controls.Add(this.label_navn);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label_telefonnummer);
            this.Controls.Add(this.animal_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AnimalName_Label);
            this.Controls.Add(this.label_dyr);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimalForm";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_prescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_medicalRecords)).EndInit();
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
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label_dyr;
        private System.Windows.Forms.Label AnimalName_Label;
        private System.Windows.Forms.Button button3;
        #endregion
        private System.Windows.Forms.TextBox animal_name;
        private System.Windows.Forms.Label label_telefonnummer;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_navn;
        private System.Windows.Forms.Label label_adresse;
        private System.Windows.Forms.TextBox animal_weight;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label animalSpecies_label;
        private System.Windows.Forms.Label animal_owner;
        private System.Windows.Forms.ComboBox animal_species;
        private System.Windows.Forms.ComboBox animal_employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox animal_gender;
        private System.Windows.Forms.DateTimePicker animal_bdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView animal_prescription;
        private System.Windows.Forms.DataGridView animal_medicalRecords;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Label label_hjaelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MR_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>


    #endregion
}
