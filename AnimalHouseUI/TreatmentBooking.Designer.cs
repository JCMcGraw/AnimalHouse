namespace AnimalHouseUI
{
    partial class TreatmentBooking
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange8 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange9 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange10 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelHeadline = new System.Windows.Forms.Panel();
            this.PanelDropdownBoxes = new System.Windows.Forms.Panel();
            this.LabelTreatmentType = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.ComboBoxTreatmentType = new System.Windows.Forms.ComboBox();
            this.ComboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PanelMonthView = new System.Windows.Forms.Panel();
            this.MonthViewBooking = new System.Windows.Forms.Calendar.MonthView();
            this.PanelCalendar = new System.Windows.Forms.Panel();
            this.CalendarBooking = new System.Windows.Forms.Calendar.Calendar();
            this.ContextMenuStripBooking = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.patternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timescaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutes30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutes20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutes15ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutes10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutes5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.PanelHeadline.SuspendLayout();
            this.PanelDropdownBoxes.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.PanelMonthView.SuspendLayout();
            this.PanelCalendar.SuspendLayout();
            this.ContextMenuStripBooking.SuspendLayout();
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
            this.PanelHeader.Size = new System.Drawing.Size(1111, 36);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHeader_Paint);
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.PanelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.PanelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(417, 4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(195, 29);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Book behandling";
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
            this.ButtonMinimize.Location = new System.Drawing.Point(1015, 2);
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
            this.ButtonMaximize.Location = new System.Drawing.Point(1047, 2);
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
            this.ButtonClose.Location = new System.Drawing.Point(1079, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(32, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sample Animal Name";
            // 
            // PanelHeadline
            // 
            this.PanelHeadline.Controls.Add(this.PanelDropdownBoxes);
            this.PanelHeadline.Controls.Add(this.label2);
            this.PanelHeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeadline.Location = new System.Drawing.Point(0, 36);
            this.PanelHeadline.Name = "PanelHeadline";
            this.PanelHeadline.Size = new System.Drawing.Size(1111, 70);
            this.PanelHeadline.TabIndex = 11;
            this.PanelHeadline.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHeadline_Paint);
            // 
            // PanelDropdownBoxes
            // 
            this.PanelDropdownBoxes.Controls.Add(this.LabelTreatmentType);
            this.PanelDropdownBoxes.Controls.Add(this.LabelEmployee);
            this.PanelDropdownBoxes.Controls.Add(this.ComboBoxTreatmentType);
            this.PanelDropdownBoxes.Controls.Add(this.ComboBoxEmployee);
            this.PanelDropdownBoxes.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDropdownBoxes.Location = new System.Drawing.Point(603, 0);
            this.PanelDropdownBoxes.Name = "PanelDropdownBoxes";
            this.PanelDropdownBoxes.Size = new System.Drawing.Size(508, 70);
            this.PanelDropdownBoxes.TabIndex = 15;
            // 
            // LabelTreatmentType
            // 
            this.LabelTreatmentType.AutoSize = true;
            this.LabelTreatmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTreatmentType.Location = new System.Drawing.Point(284, 10);
            this.LabelTreatmentType.Name = "LabelTreatmentType";
            this.LabelTreatmentType.Size = new System.Drawing.Size(89, 20);
            this.LabelTreatmentType.TabIndex = 13;
            this.LabelTreatmentType.Text = "Behandling";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployee.Location = new System.Drawing.Point(48, 10);
            this.LabelEmployee.Name = "LabelEmployee";
            this.LabelEmployee.Size = new System.Drawing.Size(98, 20);
            this.LabelEmployee.TabIndex = 12;
            this.LabelEmployee.Text = "Medarbejder";
            // 
            // ComboBoxTreatmentType
            // 
            this.ComboBoxTreatmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTreatmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxTreatmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTreatmentType.FormattingEnabled = true;
            this.ComboBoxTreatmentType.Location = new System.Drawing.Point(288, 33);
            this.ComboBoxTreatmentType.Name = "ComboBoxTreatmentType";
            this.ComboBoxTreatmentType.Size = new System.Drawing.Size(196, 28);
            this.ComboBoxTreatmentType.TabIndex = 14;
            this.ComboBoxTreatmentType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTreatmentType_SelectedIndexChanged);
            // 
            // ComboBoxEmployee
            // 
            this.ComboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEmployee.FormattingEnabled = true;
            this.ComboBoxEmployee.Location = new System.Drawing.Point(52, 33);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(196, 28);
            this.ComboBoxEmployee.TabIndex = 12;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.label3);
            this.PanelBottom.Controls.Add(this.button5);
            this.PanelBottom.Controls.Add(this.button4);
            this.PanelBottom.Controls.Add(this.button6);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 532);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1111, 113);
            this.PanelBottom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sample Label";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button5.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_search_32px;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(618, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 36);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.button4.BackgroundImage = global::AnimalHouseUI.Properties.Resources.icons8_arrow_pointing_left_32px;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(476, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 36);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(299, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 73);
            this.button6.TabIndex = 13;
            this.button6.Text = "Sample Button";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // PanelMonthView
            // 
            this.PanelMonthView.BackColor = System.Drawing.Color.Transparent;
            this.PanelMonthView.Controls.Add(this.MonthViewBooking);
            this.PanelMonthView.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMonthView.Location = new System.Drawing.Point(0, 106);
            this.PanelMonthView.Name = "PanelMonthView";
            this.PanelMonthView.Size = new System.Drawing.Size(261, 426);
            this.PanelMonthView.TabIndex = 12;
            // 
            // MonthViewBooking
            // 
            this.MonthViewBooking.ArrowsColor = System.Drawing.SystemColors.Window;
            this.MonthViewBooking.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.MonthViewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.MonthViewBooking.DayBackgroundColor = System.Drawing.Color.Empty;
            this.MonthViewBooking.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.MonthViewBooking.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.MonthViewBooking.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.MonthViewBooking.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.MonthViewBooking.ItemPadding = new System.Windows.Forms.Padding(2);
            this.MonthViewBooking.Location = new System.Drawing.Point(20, 6);
            this.MonthViewBooking.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.MonthViewBooking.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.MonthViewBooking.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MonthViewBooking.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.MonthViewBooking.Name = "MonthViewBooking";
            this.MonthViewBooking.SelectionMode = System.Windows.Forms.Calendar.MonthView.MonthViewSelection.WorkWeek;
            this.MonthViewBooking.Size = new System.Drawing.Size(229, 294);
            this.MonthViewBooking.TabIndex = 0;
            this.MonthViewBooking.Text = "monthView1";
            this.MonthViewBooking.TodayBorderColor = System.Drawing.Color.Maroon;
            this.MonthViewBooking.SelectionChanged += new System.EventHandler(this.MonthViewBooking_SelectionChanged);
            // 
            // PanelCalendar
            // 
            this.PanelCalendar.Controls.Add(this.CalendarBooking);
            this.PanelCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCalendar.Location = new System.Drawing.Point(261, 106);
            this.PanelCalendar.Name = "PanelCalendar";
            this.PanelCalendar.Padding = new System.Windows.Forms.Padding(10);
            this.PanelCalendar.Size = new System.Drawing.Size(850, 426);
            this.PanelCalendar.TabIndex = 0;
            // 
            // CalendarBooking
            // 
            this.CalendarBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("08:00:00");
            this.CalendarBooking.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange6,
        calendarHighlightRange7,
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10};
            this.CalendarBooking.Location = new System.Drawing.Point(10, 10);
            this.CalendarBooking.Name = "CalendarBooking";
            this.CalendarBooking.Size = new System.Drawing.Size(830, 406);
            this.CalendarBooking.TabIndex = 0;
            this.CalendarBooking.Text = "calendar1";
            this.CalendarBooking.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.CalendarBooking_LoadItems);
            this.CalendarBooking.ItemCreating += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.CalendarBooking_ItemCreating);
            this.CalendarBooking.ItemDeleting += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.CalendarBooking_ItemDeleting);
            this.CalendarBooking.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.CalendarBooking_ItemDatesChanged);
            this.CalendarBooking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CalendarBooking_MouseClick);
            // 
            // ContextMenuStripBooking
            // 
            this.ContextMenuStripBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redTagToolStripMenuItem,
            this.yellowTagToolStripMenuItem,
            this.greenTagToolStripMenuItem,
            this.blueTagToolStripMenuItem,
            this.otherColorTagToolStripMenuItem,
            this.toolStripMenuItem1,
            this.patternToolStripMenuItem,
            this.timescaleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editItemToolStripMenuItem});
            this.ContextMenuStripBooking.Name = "contextMenuStrip1";
            this.ContextMenuStripBooking.Size = new System.Drawing.Size(164, 192);
            // 
            // redTagToolStripMenuItem
            // 
            this.redTagToolStripMenuItem.Name = "redTagToolStripMenuItem";
            this.redTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.redTagToolStripMenuItem.Text = "Red tag";
            this.redTagToolStripMenuItem.Click += new System.EventHandler(this.redTagToolStripMenuItem_Click);
            // 
            // yellowTagToolStripMenuItem
            // 
            this.yellowTagToolStripMenuItem.Name = "yellowTagToolStripMenuItem";
            this.yellowTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yellowTagToolStripMenuItem.Text = "Yellow tag";
            this.yellowTagToolStripMenuItem.Click += new System.EventHandler(this.yellowTagToolStripMenuItem_Click);
            // 
            // greenTagToolStripMenuItem
            // 
            this.greenTagToolStripMenuItem.Name = "greenTagToolStripMenuItem";
            this.greenTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.greenTagToolStripMenuItem.Text = "Green tag";
            this.greenTagToolStripMenuItem.Click += new System.EventHandler(this.greenTagToolStripMenuItem_Click);
            // 
            // blueTagToolStripMenuItem
            // 
            this.blueTagToolStripMenuItem.Name = "blueTagToolStripMenuItem";
            this.blueTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.blueTagToolStripMenuItem.Text = "Blue tag";
            this.blueTagToolStripMenuItem.Click += new System.EventHandler(this.blueTagToolStripMenuItem_Click);
            // 
            // otherColorTagToolStripMenuItem
            // 
            this.otherColorTagToolStripMenuItem.Name = "otherColorTagToolStripMenuItem";
            this.otherColorTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.otherColorTagToolStripMenuItem.Text = "Other color tag...";
            this.otherColorTagToolStripMenuItem.Click += new System.EventHandler(this.otherColorTagToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // patternToolStripMenuItem
            // 
            this.patternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagonalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.hatchToolStripMenuItem,
            this.toolStripMenuItem3,
            this.noneToolStripMenuItem});
            this.patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            this.patternToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.patternToolStripMenuItem.Text = "Pattern";
            // 
            // diagonalToolStripMenuItem
            // 
            this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
            this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.diagonalToolStripMenuItem.Text = "Diagonal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hatchToolStripMenuItem.Text = "Cross";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 6);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // timescaleToolStripMenuItem
            // 
            this.timescaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hourToolStripMenuItem,
            this.minutes30ToolStripMenuItem,
            this.minutes20ToolStripMenuItem,
            this.minutes15ToolStripMenuItem,
            this.minutes10ToolStripMenuItem,
            this.minutes5ToolStripMenuItem});
            this.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem";
            this.timescaleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.timescaleToolStripMenuItem.Text = "Timescale";
            // 
            // hourToolStripMenuItem
            // 
            this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
            this.hourToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.hourToolStripMenuItem.Text = "1 hour";
            this.hourToolStripMenuItem.Click += new System.EventHandler(this.hourToolStripMenuItem_Click);
            // 
            // minutes30ToolStripMenuItem
            // 
            this.minutes30ToolStripMenuItem.Name = "minutes30ToolStripMenuItem";
            this.minutes30ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.minutes30ToolStripMenuItem.Text = "30 minutes";
            this.minutes30ToolStripMenuItem.Click += new System.EventHandler(this.minutesToolStripMenuItem_Click);
            // 
            // minutes20ToolStripMenuItem
            // 
            this.minutes20ToolStripMenuItem.Name = "minutes20ToolStripMenuItem";
            this.minutes20ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.minutes20ToolStripMenuItem.Text = "20 minutes";
            this.minutes20ToolStripMenuItem.Click += new System.EventHandler(this.minutes20ToolStripMenuItem_Click);
            // 
            // minutes15ToolStripMenuItem
            // 
            this.minutes15ToolStripMenuItem.Name = "minutes15ToolStripMenuItem";
            this.minutes15ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.minutes15ToolStripMenuItem.Text = "15 minutes";
            this.minutes15ToolStripMenuItem.Click += new System.EventHandler(this.minutes15ToolStripMenuItem_Click);
            // 
            // minutes10ToolStripMenuItem
            // 
            this.minutes10ToolStripMenuItem.Name = "minutes10ToolStripMenuItem";
            this.minutes10ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.minutes10ToolStripMenuItem.Text = "10 minutes";
            this.minutes10ToolStripMenuItem.Click += new System.EventHandler(this.minutes10ToolStripMenuItem_Click);
            // 
            // minutes5ToolStripMenuItem
            // 
            this.minutes5ToolStripMenuItem.Name = "minutes5ToolStripMenuItem";
            this.minutes5ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.minutes5ToolStripMenuItem.Text = "5 minutes";
            this.minutes5ToolStripMenuItem.Click += new System.EventHandler(this.minutes5ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 6);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editItemToolStripMenuItem.Text = "Edit item\'s text";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // TreatmentBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1111, 650);
            this.Controls.Add(this.PanelCalendar);
            this.Controls.Add(this.PanelMonthView);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelHeadline);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreatmentBooking";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Text = "SampleForm";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.PanelHeadline.ResumeLayout(false);
            this.PanelHeadline.PerformLayout();
            this.PanelDropdownBoxes.ResumeLayout(false);
            this.PanelDropdownBoxes.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.PanelMonthView.ResumeLayout(false);
            this.PanelCalendar.ResumeLayout(false);
            this.ContextMenuStripBooking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonMaximize;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelHeadline;
        private System.Windows.Forms.ComboBox ComboBoxEmployee;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.Panel PanelDropdownBoxes;
        private System.Windows.Forms.Label LabelTreatmentType;
        private System.Windows.Forms.ComboBox ComboBoxTreatmentType;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel PanelMonthView;
        private System.Windows.Forms.Panel PanelCalendar;
        private System.Windows.Forms.Calendar.MonthView MonthViewBooking;
        private System.Windows.Forms.Calendar.Calendar CalendarBooking;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripBooking;
        private System.Windows.Forms.ToolStripMenuItem redTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherColorTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timescaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutes30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutes15ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutes10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutes5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutes20ToolStripMenuItem;
    }
}