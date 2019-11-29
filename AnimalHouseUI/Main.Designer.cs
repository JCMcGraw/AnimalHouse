namespace AnimalHouseUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.button_kunde = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_headline = new System.Windows.Forms.Label();
            this.button_salg = new System.Windows.Forms.Button();
            this.button_behandling = new System.Windows.Forms.Button();
            this.button_dyr = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
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
            this.PanelHeader.Size = new System.Drawing.Size(540, 36);
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
            // button_kunde
            // 
            this.button_kunde.BackColor = System.Drawing.Color.AliceBlue;
            this.button_kunde.FlatAppearance.BorderSize = 0;
            this.button_kunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kunde.Location = new System.Drawing.Point(217, 203);
            this.button_kunde.Name = "button_kunde";
            this.button_kunde.Size = new System.Drawing.Size(118, 73);
            this.button_kunde.TabIndex = 6;
            this.button_kunde.Text = "Kunde";
            this.button_kunde.UseVisualStyleBackColor = false;
            this.button_kunde.Click += new System.EventHandler(this.button_kunde_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sample Label";
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(35, 82);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(197, 47);
            this.label_headline.TabIndex = 8;
            this.label_headline.Text = "AnimalHouse";
            // 
            // button_salg
            // 
            this.button_salg.BackColor = System.Drawing.Color.AliceBlue;
            this.button_salg.FlatAppearance.BorderSize = 0;
            this.button_salg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salg.Location = new System.Drawing.Point(341, 203);
            this.button_salg.Name = "button_salg";
            this.button_salg.Size = new System.Drawing.Size(118, 73);
            this.button_salg.TabIndex = 11;
            this.button_salg.Text = "Salg";
            this.button_salg.UseVisualStyleBackColor = false;
            this.button_salg.Click += new System.EventHandler(this.button_salg_Click);
            // 
            // button_behandling
            // 
            this.button_behandling.BackColor = System.Drawing.Color.AliceBlue;
            this.button_behandling.FlatAppearance.BorderSize = 0;
            this.button_behandling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_behandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_behandling.Location = new System.Drawing.Point(217, 282);
            this.button_behandling.Name = "button_behandling";
            this.button_behandling.Size = new System.Drawing.Size(118, 73);
            this.button_behandling.TabIndex = 12;
            this.button_behandling.Text = "Behandling";
            this.button_behandling.UseVisualStyleBackColor = false;
            this.button_behandling.Click += new System.EventHandler(this.button_behandling_Click);
            // 
            // button_dyr
            // 
            this.button_dyr.BackColor = System.Drawing.Color.AliceBlue;
            this.button_dyr.FlatAppearance.BorderSize = 0;
            this.button_dyr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dyr.Location = new System.Drawing.Point(341, 282);
            this.button_dyr.Name = "button_dyr";
            this.button_dyr.Size = new System.Drawing.Size(118, 73);
            this.button_dyr.TabIndex = 13;
            this.button_dyr.Text = "Dyr";
            this.button_dyr.UseVisualStyleBackColor = false;
            this.button_dyr.Click += new System.EventHandler(this.button_dyr_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button3.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_arrow_pointing_left_32px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(59, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 36);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button2.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_search_32px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(59, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 36);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
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
            this.ButtonMinimize.Location = new System.Drawing.Point(444, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(476, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(508, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.button_dyr);
            this.Controls.Add(this.button_behandling);
            this.Controls.Add(this.button_salg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_headline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kunde);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.Main_Load);
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
        private System.Windows.Forms.Button button_kunde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_salg;
        private System.Windows.Forms.Button button_behandling;
        private System.Windows.Forms.Button button_dyr;
    }
}