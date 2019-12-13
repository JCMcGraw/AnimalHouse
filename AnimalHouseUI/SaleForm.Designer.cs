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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.SearchPhoneButton = new System.Windows.Forms.Button();
            this.FakturaButton = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.SearchItemTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MomsLabel = new System.Windows.Forms.Label();
            this.TotalInkMomsLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.UpdateMedecinLabel = new System.Windows.Forms.Label();
            this.ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemListDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewSaleButton = new System.Windows.Forms.Button();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowStockButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UnPaidPrescriptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.prescriptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnPaidTreatmentDataGridView = new System.Windows.Forms.DataGridView();
            this.treatmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnPaidPrescriptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnPaidTreatmentDataGridView)).BeginInit();
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
            this.PanelHeader.Size = new System.Drawing.Size(864, 36);
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
            this.ButtonMinimize.Location = new System.Drawing.Point(768, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(800, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(832, 2);
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
            this.EndButton.Location = new System.Drawing.Point(743, 582);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(92, 48);
            this.EndButton.TabIndex = 6;
            this.EndButton.Text = "Gem Salg";
            this.EndButton.UseVisualStyleBackColor = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(16, 67);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(106, 47);
            this.CustomerNameLabel.TabIndex = 8;
            this.CustomerNameLabel.Text = "Kunde";
            // 
            // SearchPhoneButton
            // 
            this.SearchPhoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.SearchPhoneButton.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_search_32px;
            this.SearchPhoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchPhoneButton.FlatAppearance.BorderSize = 0;
            this.SearchPhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPhoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPhoneButton.Location = new System.Drawing.Point(153, 139);
            this.SearchPhoneButton.Name = "SearchPhoneButton";
            this.SearchPhoneButton.Size = new System.Drawing.Size(31, 28);
            this.SearchPhoneButton.TabIndex = 9;
            this.SearchPhoneButton.UseVisualStyleBackColor = false;
            this.SearchPhoneButton.Click += new System.EventHandler(this.SearchPhoneButton_Click);
            // 
            // FakturaButton
            // 
            this.FakturaButton.BackColor = System.Drawing.Color.AliceBlue;
            this.FakturaButton.FlatAppearance.BorderSize = 0;
            this.FakturaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FakturaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakturaButton.Location = new System.Drawing.Point(631, 582);
            this.FakturaButton.Name = "FakturaButton";
            this.FakturaButton.Size = new System.Drawing.Size(92, 48);
            this.FakturaButton.TabIndex = 11;
            this.FakturaButton.Text = "Faktura";
            this.FakturaButton.UseVisualStyleBackColor = false;
            this.FakturaButton.Click += new System.EventHandler(this.FakturaButton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(24, 145);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(123, 20);
            this.PhoneTextBox.TabIndex = 12;
            // 
            // SearchItemTextBox
            // 
            this.SearchItemTextBox.Location = new System.Drawing.Point(394, 137);
            this.SearchItemTextBox.Name = "SearchItemTextBox";
            this.SearchItemTextBox.Size = new System.Drawing.Size(153, 20);
            this.SearchItemTextBox.TabIndex = 20;
            this.SearchItemTextBox.TextChanged += new System.EventHandler(this.SearchItemTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(804, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total";
            // 
            // MomsLabel
            // 
            this.MomsLabel.AutoSize = true;
            this.MomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MomsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MomsLabel.Location = new System.Drawing.Point(789, 514);
            this.MomsLabel.Name = "MomsLabel";
            this.MomsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MomsLabel.Size = new System.Drawing.Size(0, 13);
            this.MomsLabel.TabIndex = 33;
            this.MomsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalInkMomsLabel
            // 
            this.TotalInkMomsLabel.AutoSize = true;
            this.TotalInkMomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInkMomsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalInkMomsLabel.Location = new System.Drawing.Point(747, 541);
            this.TotalInkMomsLabel.Name = "TotalInkMomsLabel";
            this.TotalInkMomsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalInkMomsLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalInkMomsLabel.TabIndex = 34;
            this.TotalInkMomsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(753, 541);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Total Inkl Moms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(800, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Moms";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalPriceLabel.Location = new System.Drawing.Point(789, 490);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalPriceLabel.TabIndex = 37;
            this.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UpdateMedecinLabel
            // 
            this.UpdateMedecinLabel.AutoSize = true;
            this.UpdateMedecinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMedecinLabel.Location = new System.Drawing.Point(326, 541);
            this.UpdateMedecinLabel.Name = "UpdateMedecinLabel";
            this.UpdateMedecinLabel.Size = new System.Drawing.Size(191, 13);
            this.UpdateMedecinLabel.TabIndex = 38;
            this.UpdateMedecinLabel.Text = "Dato for sidste opdateret Medicin priser";
            // 
            // ItemDataGridView
            // 
            this.ItemDataGridView.AllowUserToAddRows = false;
            this.ItemDataGridView.AllowUserToDeleteRows = false;
            this.ItemDataGridView.AllowUserToResizeColumns = false;
            this.ItemDataGridView.AllowUserToResizeRows = false;
            this.ItemDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.itemAmount,
            this.itemPrice});
            this.ItemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ItemDataGridView.Location = new System.Drawing.Point(314, 163);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.RowHeadersVisible = false;
            this.ItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemDataGridView.Size = new System.Drawing.Size(233, 316);
            this.ItemDataGridView.TabIndex = 45;
            this.ItemDataGridView.DoubleClick += new System.EventHandler(this.ItemDataGridView_DoubleClick);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Navn";
            this.ItemName.Name = "ItemName";
            // 
            // itemAmount
            // 
            this.itemAmount.HeaderText = "Antal";
            this.itemAmount.Name = "itemAmount";
            this.itemAmount.Width = 50;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Pris";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Width = 80;
            // 
            // ItemListDataGridView
            // 
            this.ItemListDataGridView.AllowUserToAddRows = false;
            this.ItemListDataGridView.AllowUserToDeleteRows = false;
            this.ItemListDataGridView.AllowUserToResizeColumns = false;
            this.ItemListDataGridView.AllowUserToResizeRows = false;
            this.ItemListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ItemListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.amount,
            this.price});
            this.ItemListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ItemListDataGridView.Location = new System.Drawing.Point(601, 163);
            this.ItemListDataGridView.Name = "ItemListDataGridView";
            this.ItemListDataGridView.RowHeadersVisible = false;
            this.ItemListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemListDataGridView.Size = new System.Drawing.Size(234, 316);
            this.ItemListDataGridView.TabIndex = 46;
            // 
            // name
            // 
            this.name.HeaderText = "Navn";
            this.name.Name = "name";
            // 
            // amount
            // 
            this.amount.HeaderText = "Antal";
            this.amount.Name = "amount";
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amount.Width = 50;
            // 
            // price
            // 
            this.price.HeaderText = "Pris";
            this.price.Name = "price";
            this.price.Width = 80;
            // 
            // NewSaleButton
            // 
            this.NewSaleButton.BackColor = System.Drawing.Color.AliceBlue;
            this.NewSaleButton.FlatAppearance.BorderSize = 0;
            this.NewSaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSaleButton.Location = new System.Drawing.Point(515, 582);
            this.NewSaleButton.Name = "NewSaleButton";
            this.NewSaleButton.Size = new System.Drawing.Size(92, 48);
            this.NewSaleButton.TabIndex = 47;
            this.NewSaleButton.Text = "Nyt Salg";
            this.NewSaleButton.UseVisualStyleBackColor = false;
            this.NewSaleButton.Click += new System.EventHandler(this.NewSaleButton_Click);
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(24, 195);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(123, 20);
            this.AdressTextBox.TabIndex = 51;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(24, 243);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(123, 20);
            this.EmailTextBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Søg ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Vare i Kurven";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Hylde Vare";
            // 
            // ShowStockButton
            // 
            this.ShowStockButton.BackColor = System.Drawing.Color.AliceBlue;
            this.ShowStockButton.FlatAppearance.BorderSize = 0;
            this.ShowStockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStockButton.Location = new System.Drawing.Point(428, 485);
            this.ShowStockButton.Name = "ShowStockButton";
            this.ShowStockButton.Size = new System.Drawing.Size(119, 33);
            this.ShowStockButton.TabIndex = 58;
            this.ShowStockButton.Text = "Lagerstatus";
            this.ShowStockButton.UseVisualStyleBackColor = false;
            this.ShowStockButton.Click += new System.EventHandler(this.ShowStockButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Ubetalte Recepter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Ubetalte Behandlinger";
            // 
            // UnPaidPrescriptionsDataGridView
            // 
            this.UnPaidPrescriptionsDataGridView.AllowUserToAddRows = false;
            this.UnPaidPrescriptionsDataGridView.AllowUserToDeleteRows = false;
            this.UnPaidPrescriptionsDataGridView.AllowUserToResizeColumns = false;
            this.UnPaidPrescriptionsDataGridView.AllowUserToResizeRows = false;
            this.UnPaidPrescriptionsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UnPaidPrescriptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnPaidPrescriptionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prescriptionName,
            this.prescriptionAmount,
            this.prescriptionPrice});
            this.UnPaidPrescriptionsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UnPaidPrescriptionsDataGridView.Location = new System.Drawing.Point(24, 291);
            this.UnPaidPrescriptionsDataGridView.Name = "UnPaidPrescriptionsDataGridView";
            this.UnPaidPrescriptionsDataGridView.RowHeadersVisible = false;
            this.UnPaidPrescriptionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnPaidPrescriptionsDataGridView.Size = new System.Drawing.Size(233, 138);
            this.UnPaidPrescriptionsDataGridView.TabIndex = 63;
            this.UnPaidPrescriptionsDataGridView.DoubleClick += new System.EventHandler(this.UnPaidPrescriptionsDataGridView_DoubleClick);
            // 
            // prescriptionName
            // 
            this.prescriptionName.HeaderText = "Navn";
            this.prescriptionName.Name = "prescriptionName";
            // 
            // prescriptionAmount
            // 
            this.prescriptionAmount.HeaderText = "Antal";
            this.prescriptionAmount.Name = "prescriptionAmount";
            this.prescriptionAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prescriptionAmount.Width = 50;
            // 
            // prescriptionPrice
            // 
            this.prescriptionPrice.HeaderText = "Pris";
            this.prescriptionPrice.Name = "prescriptionPrice";
            this.prescriptionPrice.Width = 80;
            // 
            // UnPaidTreatmentDataGridView
            // 
            this.UnPaidTreatmentDataGridView.AllowUserToAddRows = false;
            this.UnPaidTreatmentDataGridView.AllowUserToDeleteRows = false;
            this.UnPaidTreatmentDataGridView.AllowUserToResizeColumns = false;
            this.UnPaidTreatmentDataGridView.AllowUserToResizeRows = false;
            this.UnPaidTreatmentDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UnPaidTreatmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnPaidTreatmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatmentName,
            this.treatmentDay,
            this.treatmentPrice});
            this.UnPaidTreatmentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UnPaidTreatmentDataGridView.Location = new System.Drawing.Point(24, 463);
            this.UnPaidTreatmentDataGridView.Name = "UnPaidTreatmentDataGridView";
            this.UnPaidTreatmentDataGridView.RowHeadersVisible = false;
            this.UnPaidTreatmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnPaidTreatmentDataGridView.Size = new System.Drawing.Size(233, 135);
            this.UnPaidTreatmentDataGridView.TabIndex = 64;
            this.UnPaidTreatmentDataGridView.DoubleClick += new System.EventHandler(this.UnPaidTreatmentDataGridView_DoubleClick);
            // 
            // treatmentName
            // 
            this.treatmentName.HeaderText = "Navn";
            this.treatmentName.Name = "treatmentName";
            // 
            // treatmentDay
            // 
            this.treatmentDay.HeaderText = "Day";
            this.treatmentDay.Name = "treatmentDay";
            this.treatmentDay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.treatmentDay.Width = 50;
            // 
            // treatmentPrice
            // 
            this.treatmentPrice.HeaderText = "Pris";
            this.treatmentPrice.Name = "treatmentPrice";
            this.treatmentPrice.Width = 80;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(864, 661);
            this.Controls.Add(this.UnPaidTreatmentDataGridView);
            this.Controls.Add(this.UnPaidPrescriptionsDataGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowStockButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.NewSaleButton);
            this.Controls.Add(this.ItemListDataGridView);
            this.Controls.Add(this.ItemDataGridView);
            this.Controls.Add(this.UpdateMedecinLabel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TotalInkMomsLabel);
            this.Controls.Add(this.MomsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SearchItemTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.FakturaButton);
            this.Controls.Add(this.SearchPhoneButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleForm";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnPaidPrescriptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnPaidTreatmentDataGridView)).EndInit();
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
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button SearchPhoneButton;
        #endregion

        private System.Windows.Forms.Button FakturaButton;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox SearchItemTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MomsLabel;
        private System.Windows.Forms.Label TotalInkMomsLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label UpdateMedecinLabel;
        private System.Windows.Forms.DataGridView ItemDataGridView;
        private System.Windows.Forms.DataGridView ItemListDataGridView;
        private System.Windows.Forms.Button NewSaleButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ShowStockButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView UnPaidPrescriptionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridView UnPaidTreatmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentPrice;
    }

}
