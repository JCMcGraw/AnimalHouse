namespace AnimalHouseUI
{
    partial class TreatmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentForm));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.button_udsted_recept = new System.Windows.Forms.Button();
            this.label_underheadline = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.textBox_entry = new System.Windows.Forms.TextBox();
            this.button_gemogafslut = new System.Windows.Forms.Button();
            this.label_skrivjournal = new System.Windows.Forms.Label();
            this.label_underheadline2 = new System.Windows.Forms.Label();
            this.comboBox_recept = new System.Windows.Forms.ComboBox();
            this.label_vaelg_medicin = new System.Windows.Forms.Label();
            this.label_hjaelp = new System.Windows.Forms.Label();
            this.button_help = new System.Windows.Forms.Button();
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
            this.LabelTitle.Size = new System.Drawing.Size(135, 29);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Behandling";
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
            // button_udsted_recept
            // 
            this.button_udsted_recept.BackColor = System.Drawing.Color.AliceBlue;
            this.button_udsted_recept.FlatAppearance.BorderSize = 0;
            this.button_udsted_recept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_udsted_recept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_udsted_recept.Location = new System.Drawing.Point(43, 309);
            this.button_udsted_recept.Name = "button_udsted_recept";
            this.button_udsted_recept.Size = new System.Drawing.Size(118, 73);
            this.button_udsted_recept.TabIndex = 6;
            this.button_udsted_recept.Text = "Udsted recept";
            this.button_udsted_recept.UseVisualStyleBackColor = false;
            this.button_udsted_recept.Click += new System.EventHandler(this.button_recept_Click);
            // 
            // label_underheadline
            // 
            this.label_underheadline.AutoSize = true;
            this.label_underheadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_underheadline.Location = new System.Drawing.Point(39, 129);
            this.label_underheadline.Name = "label_underheadline";
            this.label_underheadline.Size = new System.Drawing.Size(89, 20);
            this.label_underheadline.TabIndex = 7;
            this.label_underheadline.Text = "Behandling";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(35, 82);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(210, 47);
            this.label_header.TabIndex = 8;
            this.label_header.Text = "Animal Name";
            // 
            // textBox_entry
            // 
            this.textBox_entry.Location = new System.Drawing.Point(304, 119);
            this.textBox_entry.Multiline = true;
            this.textBox_entry.Name = "textBox_entry";
            this.textBox_entry.Size = new System.Drawing.Size(464, 263);
            this.textBox_entry.TabIndex = 11;
            // 
            // button_gemogafslut
            // 
            this.button_gemogafslut.BackColor = System.Drawing.Color.AliceBlue;
            this.button_gemogafslut.FlatAppearance.BorderSize = 0;
            this.button_gemogafslut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gemogafslut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gemogafslut.Location = new System.Drawing.Point(167, 309);
            this.button_gemogafslut.Name = "button_gemogafslut";
            this.button_gemogafslut.Size = new System.Drawing.Size(118, 73);
            this.button_gemogafslut.TabIndex = 12;
            this.button_gemogafslut.Text = "Gem og Afslut";
            this.button_gemogafslut.UseVisualStyleBackColor = false;
            this.button_gemogafslut.Click += new System.EventHandler(this.button_gem_Click);
            // 
            // label_skrivjournal
            // 
            this.label_skrivjournal.AutoSize = true;
            this.label_skrivjournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_skrivjournal.Location = new System.Drawing.Point(310, 96);
            this.label_skrivjournal.Name = "label_skrivjournal";
            this.label_skrivjournal.Size = new System.Drawing.Size(142, 20);
            this.label_skrivjournal.TabIndex = 13;
            this.label_skrivjournal.Text = "Skriv journalindlæg";
            // 
            // label_underheadline2
            // 
            this.label_underheadline2.AutoSize = true;
            this.label_underheadline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_underheadline2.Location = new System.Drawing.Point(41, 149);
            this.label_underheadline2.Name = "label_underheadline2";
            this.label_underheadline2.Size = new System.Drawing.Size(37, 20);
            this.label_underheadline2.TabIndex = 14;
            this.label_underheadline2.Text = "Ejer";
            // 
            // comboBox_recept
            // 
            this.comboBox_recept.FormattingEnabled = true;
            this.comboBox_recept.Location = new System.Drawing.Point(43, 230);
            this.comboBox_recept.Name = "comboBox_recept";
            this.comboBox_recept.Size = new System.Drawing.Size(245, 21);
            this.comboBox_recept.TabIndex = 15;
            // 
            // label_vaelg_medicin
            // 
            this.label_vaelg_medicin.AutoSize = true;
            this.label_vaelg_medicin.Location = new System.Drawing.Point(40, 214);
            this.label_vaelg_medicin.Name = "label_vaelg_medicin";
            this.label_vaelg_medicin.Size = new System.Drawing.Size(71, 13);
            this.label_vaelg_medicin.TabIndex = 16;
            this.label_vaelg_medicin.Text = "Vælg medicin";
            // 
            // label_hjaelp
            // 
            this.label_hjaelp.AutoSize = true;
            this.label_hjaelp.Location = new System.Drawing.Point(746, 82);
            this.label_hjaelp.Name = "label_hjaelp";
            this.label_hjaelp.Size = new System.Drawing.Size(35, 13);
            this.label_hjaelp.TabIndex = 33;
            this.label_hjaelp.Text = "Hjælp";
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button_help.BackgroundImage = global::AnimalHouseUI.Properties.Resources.question_mark_32px;
            this.button_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_help.FlatAppearance.BorderSize = 0;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_help.Location = new System.Drawing.Point(743, 42);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(45, 36);
            this.button_help.TabIndex = 32;
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.label_hjaelp);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.label_vaelg_medicin);
            this.Controls.Add(this.comboBox_recept);
            this.Controls.Add(this.label_underheadline2);
            this.Controls.Add(this.label_skrivjournal);
            this.Controls.Add(this.button_gemogafslut);
            this.Controls.Add(this.textBox_entry);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.label_underheadline);
            this.Controls.Add(this.button_udsted_recept);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreatmentForm";
            this.Text = "Behandling";
            this.Load += new System.EventHandler(this.TreatmentForm_Load_1);
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
        private System.Windows.Forms.Button button_udsted_recept;
        private System.Windows.Forms.Label label_underheadline;
        private System.Windows.Forms.Label label_header;
        #endregion

        private System.Windows.Forms.TextBox textBox_entry;
        private System.Windows.Forms.Button button_gemogafslut;
        private System.Windows.Forms.Label label_skrivjournal;
        private System.Windows.Forms.Label label_underheadline2;
        private System.Windows.Forms.ComboBox comboBox_recept;
        private System.Windows.Forms.Label label_vaelg_medicin;
        private System.Windows.Forms.Label label_hjaelp;
        private System.Windows.Forms.Button button_help;
    }
}