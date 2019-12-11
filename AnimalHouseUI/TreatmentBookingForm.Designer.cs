namespace AnimalHouseUI
{
    partial class TreatmentBookingForm
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange16 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange17 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange18 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange19 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange20 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonMaximize = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.AnimalLabel = new System.Windows.Forms.Label();
            this.PanelHeadline = new System.Windows.Forms.Panel();
            this.PanelDropdownBoxes = new System.Windows.Forms.Panel();
            this.LabelTreatmentType = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.ComboBoxTreatmentType = new System.Windows.Forms.ComboBox();
            this.ComboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.button_startbehandling = new System.Windows.Forms.Button();
            this.ChooseAnimalButton = new System.Windows.Forms.Button();
            this.ButtonCreateTreatment = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.PanelMonthView = new System.Windows.Forms.Panel();
            this.PanelViewSelection = new System.Windows.Forms.Panel();
            this.radioButtonDayView = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekView = new System.Windows.Forms.RadioButton();
            this.MonthViewBooking = new System.Windows.Forms.Calendar.MonthView();
            this.PanelCalendar = new System.Windows.Forms.Panel();
            this.CalendarBooking = new System.Windows.Forms.Calendar.Calendar();
            this.ContextMenuStripBooking = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ankommetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.StartTreatmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.PanelHeadline.SuspendLayout();
            this.PanelDropdownBoxes.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.PanelMonthView.SuspendLayout();
            this.PanelViewSelection.SuspendLayout();
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
            // AnimalLabel
            // 
            this.AnimalLabel.AutoSize = true;
            this.AnimalLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalLabel.Location = new System.Drawing.Point(12, 10);
            this.AnimalLabel.Name = "AnimalLabel";
            this.AnimalLabel.Size = new System.Drawing.Size(0, 47);
            this.AnimalLabel.TabIndex = 8;
            // 
            // PanelHeadline
            // 
            this.PanelHeadline.Controls.Add(this.PanelDropdownBoxes);
            this.PanelHeadline.Controls.Add(this.AnimalLabel);
            this.PanelHeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeadline.Location = new System.Drawing.Point(0, 36);
            this.PanelHeadline.Name = "PanelHeadline";
            this.PanelHeadline.Size = new System.Drawing.Size(1111, 70);
            this.PanelHeadline.TabIndex = 11;
            // 
            // PanelDropdownBoxes
            // 
            this.PanelDropdownBoxes.Controls.Add(this.ButtonHelp);
            this.PanelDropdownBoxes.Controls.Add(this.LabelTreatmentType);
            this.PanelDropdownBoxes.Controls.Add(this.LabelEmployee);
            this.PanelDropdownBoxes.Controls.Add(this.ComboBoxTreatmentType);
            this.PanelDropdownBoxes.Controls.Add(this.ComboBoxEmployee);
            this.PanelDropdownBoxes.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDropdownBoxes.Location = new System.Drawing.Point(561, 0);
            this.PanelDropdownBoxes.Name = "PanelDropdownBoxes";
            this.PanelDropdownBoxes.Size = new System.Drawing.Size(550, 70);
            this.PanelDropdownBoxes.TabIndex = 15;
            // 
            // LabelTreatmentType
            // 
            this.LabelTreatmentType.AutoSize = true;
            this.LabelTreatmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTreatmentType.Location = new System.Drawing.Point(267, 13);
            this.LabelTreatmentType.Name = "LabelTreatmentType";
            this.LabelTreatmentType.Size = new System.Drawing.Size(89, 20);
            this.LabelTreatmentType.TabIndex = 13;
            this.LabelTreatmentType.Text = "Behandling";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployee.Location = new System.Drawing.Point(31, 13);
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
            this.ComboBoxTreatmentType.Location = new System.Drawing.Point(271, 36);
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
            this.ComboBoxEmployee.Location = new System.Drawing.Point(35, 36);
            this.ComboBoxEmployee.Name = "ComboBoxEmployee";
            this.ComboBoxEmployee.Size = new System.Drawing.Size(196, 28);
            this.ComboBoxEmployee.TabIndex = 12;
            this.ComboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEmployee_SelectedIndexChanged);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.button_startbehandling);
            this.PanelBottom.Controls.Add(this.ChooseAnimalButton);
            this.PanelBottom.Controls.Add(this.ButtonCreateTreatment);
            this.PanelBottom.Controls.Add(this.ButtonDelete);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 532);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1111, 113);
            this.PanelBottom.TabIndex = 6;
            // 
            // button_startbehandling
            // 
            this.button_startbehandling.BackColor = System.Drawing.Color.AliceBlue;
            this.button_startbehandling.FlatAppearance.BorderSize = 0;
            this.button_startbehandling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_startbehandling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startbehandling.Location = new System.Drawing.Point(636, 15);
            this.button_startbehandling.Name = "button_startbehandling";
            this.button_startbehandling.Size = new System.Drawing.Size(118, 73);
            this.button_startbehandling.TabIndex = 16;
            this.button_startbehandling.Text = "Start Behandling";
            this.button_startbehandling.UseVisualStyleBackColor = false;
            this.button_startbehandling.Click += new System.EventHandler(this.button_startbehandling_Click);
            // 
            // ChooseAnimalButton
            // 
            this.ChooseAnimalButton.BackColor = System.Drawing.Color.AliceBlue;
            this.ChooseAnimalButton.FlatAppearance.BorderSize = 0;
            this.ChooseAnimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseAnimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAnimalButton.Location = new System.Drawing.Point(264, 15);
            this.ChooseAnimalButton.Name = "ChooseAnimalButton";
            this.ChooseAnimalButton.Size = new System.Drawing.Size(118, 73);
            this.ChooseAnimalButton.TabIndex = 15;
            this.ChooseAnimalButton.Text = "Vælg dyr til behandling";
            this.ChooseAnimalButton.UseVisualStyleBackColor = false;
            this.ChooseAnimalButton.Click += new System.EventHandler(this.ChooseAnimalButton_Click);
            // 
            // ButtonCreateTreatment
            // 
            this.ButtonCreateTreatment.BackColor = System.Drawing.Color.AliceBlue;
            this.ButtonCreateTreatment.FlatAppearance.BorderSize = 0;
            this.ButtonCreateTreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateTreatment.Location = new System.Drawing.Point(388, 15);
            this.ButtonCreateTreatment.Name = "ButtonCreateTreatment";
            this.ButtonCreateTreatment.Size = new System.Drawing.Size(118, 73);
            this.ButtonCreateTreatment.TabIndex = 14;
            this.ButtonCreateTreatment.Text = "Opret aftale";
            this.ButtonCreateTreatment.UseVisualStyleBackColor = false;
            this.ButtonCreateTreatment.Click += new System.EventHandler(this.ButtonCreateTreatment_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.Location = new System.Drawing.Point(512, 15);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(118, 73);
            this.ButtonDelete.TabIndex = 13;
            this.ButtonDelete.Text = "Slet valgte aftale";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // PanelMonthView
            // 
            this.PanelMonthView.BackColor = System.Drawing.Color.Transparent;
            this.PanelMonthView.Controls.Add(this.PanelViewSelection);
            this.PanelMonthView.Controls.Add(this.MonthViewBooking);
            this.PanelMonthView.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMonthView.Location = new System.Drawing.Point(0, 106);
            this.PanelMonthView.Name = "PanelMonthView";
            this.PanelMonthView.Size = new System.Drawing.Size(261, 426);
            this.PanelMonthView.TabIndex = 12;
            // 
            // PanelViewSelection
            // 
            this.PanelViewSelection.Controls.Add(this.radioButtonDayView);
            this.PanelViewSelection.Controls.Add(this.radioButtonWeekView);
            this.PanelViewSelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelViewSelection.Location = new System.Drawing.Point(0, 326);
            this.PanelViewSelection.Name = "PanelViewSelection";
            this.PanelViewSelection.Size = new System.Drawing.Size(261, 100);
            this.PanelViewSelection.TabIndex = 1;
            // 
            // radioButtonDayView
            // 
            this.radioButtonDayView.AutoSize = true;
            this.radioButtonDayView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDayView.Location = new System.Drawing.Point(39, 45);
            this.radioButtonDayView.Name = "radioButtonDayView";
            this.radioButtonDayView.Size = new System.Drawing.Size(80, 24);
            this.radioButtonDayView.TabIndex = 1;
            this.radioButtonDayView.Text = "Vis dag";
            this.radioButtonDayView.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeekView
            // 
            this.radioButtonWeekView.AutoSize = true;
            this.radioButtonWeekView.Checked = true;
            this.radioButtonWeekView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeekView.Location = new System.Drawing.Point(39, 15);
            this.radioButtonWeekView.Name = "radioButtonWeekView";
            this.radioButtonWeekView.Size = new System.Drawing.Size(80, 24);
            this.radioButtonWeekView.TabIndex = 0;
            this.radioButtonWeekView.TabStop = true;
            this.radioButtonWeekView.Text = "Vis uge";
            this.radioButtonWeekView.UseVisualStyleBackColor = true;
            this.radioButtonWeekView.CheckedChanged += new System.EventHandler(this.radioButtonWeekView_CheckedChanged);
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
            calendarHighlightRange16.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange16.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange16.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange17.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange17.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange17.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange18.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange18.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange18.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange19.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange19.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange19.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange20.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange20.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange20.StartTime = System.TimeSpan.Parse("08:00:00");
            this.CalendarBooking.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange16,
        calendarHighlightRange17,
        calendarHighlightRange18,
        calendarHighlightRange19,
        calendarHighlightRange20};
            this.CalendarBooking.Location = new System.Drawing.Point(10, 10);
            this.CalendarBooking.Name = "CalendarBooking";
            this.CalendarBooking.Size = new System.Drawing.Size(830, 406);
            this.CalendarBooking.TabIndex = 0;
            this.CalendarBooking.Text = "calendar1";
            this.CalendarBooking.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.FifteenMinutes;
            this.CalendarBooking.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.CalendarBooking_LoadItems);
            this.CalendarBooking.ItemCreating += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.CalendarBooking_ItemCreating);
            this.CalendarBooking.ItemDeleting += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.CalendarBooking_ItemDeleting);
            this.CalendarBooking.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.CalendarBooking_ItemDatesChanged);
            this.CalendarBooking.ItemClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.CalendarBooking_ItemClick);
            this.CalendarBooking.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.CalendarBooking_ItemDoubleClick);
            this.CalendarBooking.ItemMouseHover += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.CalendarBooking_ItemMouseHover);
            this.CalendarBooking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalendarBooking_KeyDown);
            this.CalendarBooking.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CalendarBooking_MouseClick);
            // 
            // ContextMenuStripBooking
            // 
            this.ContextMenuStripBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ankommetToolStripMenuItem,
            this.StartTreatmentToolStripMenuItem,
            this.editItemToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ContextMenuStripBooking.Name = "contextMenuStrip1";
            this.ContextMenuStripBooking.Size = new System.Drawing.Size(181, 114);
            this.ContextMenuStripBooking.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripBooking_Opening);
            // 
            // ankommetToolStripMenuItem
            // 
            this.ankommetToolStripMenuItem.Name = "ankommetToolStripMenuItem";
            this.ankommetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ankommetToolStripMenuItem.Text = "Ankommet";
            this.ankommetToolStripMenuItem.Click += new System.EventHandler(this.AnkommetToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editItemToolStripMenuItem.Text = "Rediger tekst";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Slet";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.ButtonHelp.BackgroundImage = global::AnimalHouseUI.Properties.Resources.question_mark_32px;
            this.ButtonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonHelp.FlatAppearance.BorderSize = 0;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHelp.Location = new System.Drawing.Point(495, 20);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(45, 36);
            this.ButtonHelp.TabIndex = 29;
            this.ButtonHelp.UseVisualStyleBackColor = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // StartTreatmentToolStripMenuItem
            // 
            this.StartTreatmentToolStripMenuItem.Name = "StartTreatmentToolStripMenuItem";
            this.StartTreatmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StartTreatmentToolStripMenuItem.Text = "Start Behandling";
            this.StartTreatmentToolStripMenuItem.Visible = false;
            this.StartTreatmentToolStripMenuItem.Click += new System.EventHandler(this.StartTreatmentToolStripMenuItem_Click);
            // 
            // TreatmentBookingForm
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
            this.Name = "TreatmentBookingForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.TreatmentBookingForm_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.PanelHeadline.ResumeLayout(false);
            this.PanelHeadline.PerformLayout();
            this.PanelDropdownBoxes.ResumeLayout(false);
            this.PanelDropdownBoxes.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelMonthView.ResumeLayout(false);
            this.PanelViewSelection.ResumeLayout(false);
            this.PanelViewSelection.PerformLayout();
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
        private System.Windows.Forms.Label AnimalLabel;
        private System.Windows.Forms.Panel PanelHeadline;
        private System.Windows.Forms.ComboBox ComboBoxEmployee;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.Panel PanelDropdownBoxes;
        private System.Windows.Forms.Label LabelTreatmentType;
        private System.Windows.Forms.ComboBox ComboBoxTreatmentType;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Panel PanelMonthView;
        private System.Windows.Forms.Panel PanelCalendar;
        private System.Windows.Forms.Calendar.MonthView MonthViewBooking;
        private System.Windows.Forms.Calendar.Calendar CalendarBooking;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripBooking;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button ButtonCreateTreatment;
        private System.Windows.Forms.Button ChooseAnimalButton;
        private System.Windows.Forms.ToolTip itemToolTip;
        private System.Windows.Forms.Panel PanelViewSelection;
        private System.Windows.Forms.RadioButton radioButtonDayView;
        private System.Windows.Forms.RadioButton radioButtonWeekView;
        private System.Windows.Forms.Button button_startbehandling;
        private System.Windows.Forms.ToolStripMenuItem ankommetToolStripMenuItem;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem StartTreatmentToolStripMenuItem;
    }
}