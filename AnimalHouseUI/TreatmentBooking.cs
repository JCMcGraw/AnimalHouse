using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AnimalHouseEntities;
using System.Windows.Forms.Calendar;
using System.Data;
using AnimalHouse;

namespace AnimalHouseUI
{
    public partial class TreatmentBooking : Form
    {
        BossController bossController = BossController.instance();

        Dictionary<int, Treatment> treatmentsCache = new Dictionary<int, Treatment>();

        DateTime treatmentCacheDateStart = DateTime.Today;
        DateTime treatmentCacheDateEnd = DateTime.Today;

        List<CalendarItem> calendarItemsCache = new List<CalendarItem>();
        CalendarItem contextItem = null;

        
        public TreatmentBooking()
        {
            InitializeComponent();
            DummyValuesForComboboxes();
            ComboBoxEmployee.SelectedIndex = 0;
            ComboBoxTreatmentType.SelectedIndex = 0;

            SelectCurrentWeek();
            //UpdateTreatmentCache(DateTime.Today,DateTime.Today);


            //string query = "insert into customer values ('Larsen', 'gadenavn 211', @phone, 'mail2@mail.com)',1)";
            //AnimalHousePersistence.SQLQuery sQLQuery = new AnimalHousePersistence.SQLQuery(query);
            //sQLQuery.AddParameter("@phone", "2345235", SqlDbType.VarChar);
            //AnimalHousePersistence.SQLQueryResult sQLQueryResult = AnimalHousePersistence.SQLDatabaseConnector.QueryDatabase(sQLQuery);

        }

        private void DummyValuesForComboboxes()
        {
            DataTable employees = new DataTable();
            employees.Columns.Add("employee", typeof(string));
            employees.Columns.Add("employeeid", typeof(int));

            DataRow dataRow = employees.NewRow();
            dataRow[0] = "Alle";
            dataRow[1] = -1;
            employees.Rows.Add(dataRow);
            DataRow dataRow1 = employees.NewRow();
            dataRow1[0] = "Ole Ernst";
            dataRow1[1] = 0;
            employees.Rows.Add(dataRow1);
            DataRow dataRow2 = employees.NewRow();
            dataRow2[0] = "Poul Bundgaard";
            dataRow2[1] = 1;
            employees.Rows.Add(dataRow2);
            DataRow dataRow3 = employees.NewRow();
            dataRow3[0] = "Dirch Passer";
            dataRow3[1] = 2;
            employees.Rows.Add(dataRow3);

            ComboBoxEmployee.DataSource = employees;
            ComboBoxEmployee.DisplayMember = "employee";
            ComboBoxEmployee.ValueMember = "employeeid";

            DataTable treatment = new DataTable();
            treatment.Columns.Add("treatment", typeof(string));
            treatment.Columns.Add("treatmentid", typeof(int));

            DataRow dataRow6 = treatment.NewRow();
            dataRow6[0] = "Konsultation";
            dataRow6[1] = 0;
            treatment.Rows.Add(dataRow6);
            DataRow dataRow4 = treatment.NewRow();
            dataRow4[0] = "Operation";
            dataRow4[1] = 1;
            treatment.Rows.Add(dataRow4);
            DataRow dataRow5 = treatment.NewRow();
            dataRow5[0] = "Observation";
            dataRow5[1] = 2;
            treatment.Rows.Add(dataRow5);

            ComboBoxTreatmentType.DataSource = treatment;
            ComboBoxTreatmentType.DisplayMember = "treatment";
            ComboBoxTreatmentType.ValueMember = "treatmentid";


        }

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        int posX;
        int posY;
        bool drag;
        bool maximized;


        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
                posX = Cursor.Position.X - this.Left;
                posY = Cursor.Position.Y - this.Top;
            }
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = System.Windows.Forms.Cursor.Position.Y - posY;
                this.Left = System.Windows.Forms.Cursor.Position.X - posX;
            }
            this.Cursor = Cursors.Default;
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = true;
                posX = Cursor.Position.X - this.Left;
                posY = Cursor.Position.Y - this.Top;
            }
        }

        private void LabelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void LabelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = System.Windows.Forms.Cursor.Position.Y - posY;
                this.Left = System.Windows.Forms.Cursor.Position.X - posX;
            }
            this.Cursor = Cursors.Default;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximize_Click(object sender, EventArgs e)
        {
            if (maximized)
            {
                maximized = false;
                this.WindowState = FormWindowState.Normal;
                ButtonMaximize.BackgroundImage = Properties.Resources.icons8_maximize_button_32px;
            }
            else
            {
                maximized = true;
                this.WindowState = FormWindowState.Maximized;
                ButtonMaximize.BackgroundImage = Properties.Resources.icons8_restore_down_32px;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthViewBooking_SelectionChanged(object sender, EventArgs e)
        {

            DateTime CalendarRangeStart;
            DateTime CalendarRangeEnd;

            DateTime CacheRangeStart;
            DateTime CacheRangeEnd;

            if (MonthViewBooking.SelectionEnd > MonthViewBooking.SelectionStart)
            {
                if (ComboBoxTreatmentType.Text == "Observation")
                {
                    CalendarRangeStart = MonthViewBooking.SelectionStart;
                    CalendarRangeEnd = MonthViewBooking.SelectionStart.AddDays(14);
                }
                else
                {
                    CalendarRangeStart = MonthViewBooking.SelectionStart;
                    CalendarRangeEnd = MonthViewBooking.SelectionEnd;
                }

                CacheRangeStart = CalendarRangeStart.AddDays(-14);
                CacheRangeEnd = CalendarRangeEnd.AddDays(21);

                if (CheckCacheDates(CacheRangeStart, CacheRangeEnd) == false)
                {
                    UpdateTreatmentCache(CacheRangeStart, CacheRangeEnd);
                }

                CalendarBooking.SetViewRange(CalendarRangeStart, CalendarRangeEnd);
            }

                
        }

        private bool CheckCacheDates(DateTime CalendarRangeStart, DateTime CalendarRangeEnd)
        {
            if(CalendarRangeStart.Year == 1 || CalendarRangeEnd.Year == 1)
            {
                return true;
            }

            if(treatmentCacheDateStart <= CalendarRangeStart && treatmentCacheDateEnd >= CalendarRangeEnd)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void UpdateTreatmentCache(DateTime CalendarRangeStart, DateTime CalendarRangeEnd)
        {
            List<Treatment> treatments = bossController.treatmentController.GetManyTreatmentsByDateTime(CalendarRangeStart, CalendarRangeEnd);
            UpdateCacheRange(CalendarRangeStart, CalendarRangeEnd);

            foreach (var treatment in treatments)
            {
                AddTreatmentToCache(treatment);
            }

            PlaceItems();
        }

        private void UpdateCacheRange(DateTime CacheRangeStart, DateTime CacheRangeEnd)
        {
            if (CacheRangeStart < treatmentCacheDateStart)
            {
                treatmentCacheDateStart = CacheRangeStart;
            }
            if (CacheRangeEnd > treatmentCacheDateEnd)
            {
                treatmentCacheDateEnd = CacheRangeEnd;
            }
        }

        private void AddTreatmentToCache(Treatment treatment)
        {
            if (!treatmentsCache.ContainsKey(treatment.treatmentID))
            {
                treatmentsCache.Add(treatment.treatmentID, treatment);

                CalendarItem calendarItem = new CalendarItem(CalendarBooking, treatment.startTime, treatment.endTime, "");
                calendarItem.TreatmentID = treatment.treatmentID;
                calendarItemsCache.Add(calendarItem);
            }
        }

        private void CalendarBooking_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStripBooking.Show(Cursor.Position);
            }
        }

        private void PlaceItems()
        {
            int treatmenttype = 0;
            if(ComboBoxTreatmentType.SelectedValue != null)
            {
                try
                {
                    treatmenttype = (int)ComboBoxTreatmentType.SelectedValue;
                }
                catch { }
            }
            foreach (CalendarItem item in calendarItemsCache)
            {
                if (CalendarBooking.ViewIntersects(item))
                {
                    if (treatmenttype == 2)
                    {
                        if(treatmentsCache[item.TreatmentID].treatmentTypeID == 2)
                        {
                            CalendarBooking.Items.Add(item);
                        }
                    }
                    else
                    {
                        if (treatmentsCache[item.TreatmentID].treatmentTypeID != 2)
                        {
                            CalendarBooking.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                CalendarBooking.Invalidate(item);
            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
            {
                item.ApplyColor(Color.Gold);
                CalendarBooking.Invalidate(item);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                CalendarBooking.Invalidate(item);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
            {
                item.ApplyColor(Color.DarkBlue);
                CalendarBooking.Invalidate(item);
            }
        }

        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
                    {
                        item.ApplyColor(dlg.Color);
                        CalendarBooking.Invalidate(item);
                    }
                }
            }
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.ActivateEditMode();
        }

        private void ComboBoxTreatmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTreatmentType.Text == "Observation")
            {
                CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionStart.AddDays(14));
            }
            else
            {
                CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionEnd);
            }
        }

        private void SelectCurrentWeek()
        {
            DateTime today = DateTime.Today;

            switch (today.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    MonthViewBooking.SelectionStart = DateTime.Today.AddDays(1);
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(5);
                    break;
                case DayOfWeek.Monday:
                    MonthViewBooking.SelectionStart = DateTime.Today;
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(4);
                    break;
                case DayOfWeek.Tuesday:
                    MonthViewBooking.SelectionStart = DateTime.Today.AddDays(-1);
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(3);
                    break;
                case DayOfWeek.Wednesday:
                    MonthViewBooking.SelectionStart = DateTime.Today.AddDays(-2);
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(-2);
                    break;
                case DayOfWeek.Thursday:
                    MonthViewBooking.SelectionStart = DateTime.Today.AddDays(-2);
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(1);
                    break;
                case DayOfWeek.Friday:
                    MonthViewBooking.SelectionStart = DateTime.Today.AddDays(-4);
                    MonthViewBooking.SelectionEnd = DateTime.Today;
                    break;
                case DayOfWeek.Saturday:
                    MonthViewBooking.SelectionStart = DateTime.Today.AddDays(-5);
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(-1);
                    break;
            }
        }

        private void CalendarBooking_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            //TimeSpan appointmentDuration = e.Item.EndDate - e.Item.StartDate;
            string message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} fra kl. {e.Item.StartDate.ToString("H:mm")} til kl. {e.Item.EndDate.ToString("H:mm")} den {e.Item.StartDate.ToString("dd/M")}";


            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Treatment treatment = TreatmentFaktory.Instance().CreateTreatment((int)ComboBoxTreatmentType.SelectedValue, -1, -1, -1, e.Item.StartDate, e.Item.EndDate, false);
                Treatment treatmentWithID = bossController.treatmentController.CreateTreatment(treatment);

                AddTreatmentToCache(treatmentWithID);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CalendarBooking_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }

        private void CalendarBooking_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            string message = $"Ønsker du at ændre denne aftale til kl. {e.Item.StartDate.ToString("H:mm")}-{e.Item.EndDate.ToString("H:mm")} den {e.Item.StartDate.ToString("dd/M")}?";
            if ((int)ComboBoxTreatmentType.SelectedValue == 2)
            {
                message = $"Ønsker du at ændre denne observation til {e.Item.StartDate.ToString("d/M")}-{e.Item.EndDate.ToString("d/M")}?";
            }

            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int treatmentID = e.Item.TreatmentID;

                Treatment newTreatment = GetUpdatedTreatment(treatmentID, e.Item.StartDate, e.Item.EndDate);
                //bossController.treatmentController.UpdateTreatment(newTreatment);

                treatmentsCache.Remove(treatmentID);
                treatmentsCache.Add(newTreatment.treatmentID, newTreatment);
                
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Item.StartDate = treatmentsCache[e.Item.TreatmentID].startTime;
                e.Item.EndDate = treatmentsCache[e.Item.TreatmentID].endTime;
            }

            PlaceItems();
        }

        private Treatment GetUpdatedTreatment(int treatmentID, DateTime newStartTime, DateTime newEndTime)
        {
            Treatment oldTreatment = treatmentsCache[treatmentID];
            Treatment newTreatment = TreatmentFaktory.Instance().CreateTreatment(treatmentID, oldTreatment.treatmentTypeID, oldTreatment.operationRoomID, oldTreatment.cageID,
                oldTreatment.itemID, newStartTime, newEndTime, oldTreatment.payed);


            return newTreatment;
        }

        private void hourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.TimeScale = CalendarTimeScale.SixtyMinutes;
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.TimeScale = CalendarTimeScale.ThirtyMinutes;
        }

        private void minutes20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.TimeScale = CalendarTimeScale.TwentyMinutes;
        }

        private void minutes15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.TimeScale = CalendarTimeScale.FifteenMinutes;
        }

        private void minutes10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.TimeScale = CalendarTimeScale.TenMinutes;
        }

        private void minutes5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarBooking.TimeScale = CalendarTimeScale.FiveMinutes;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }

        private void DeleteSelectedItems()
        {
            var selectedItems = CalendarBooking.GetSelectedItems();

            foreach (var item in selectedItems)
            {
                CalendarBooking.Items.Remove(item);
            }
        }

        private void CalendarBooking_ItemDeleting(object sender, CalendarItemCancelEventArgs e)
        {
            string message = $"Ønsker du at slette denne aftale?";


            DialogResult dialogResult = MessageBox.Show(message, "Slet aftale", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int treatmentID = e.Item.TreatmentID;

                treatmentsCache.Remove(treatmentID);

                //bossController.treatmentController.DeleteTreatment(treatmentsCache[treatmentID]);

                treatmentsCache.Remove(treatmentID);
                RemoveItemFromCalendarItemsCache(treatmentID);

            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void RemoveItemFromCalendarItemsCache(int treatmentID)
        {
            int itemcounter = -1;

            for(itemcounter = 0; itemcounter < calendarItemsCache.Count; itemcounter++)
            {
                if (calendarItemsCache[itemcounter].TreatmentID == treatmentID)
                {
                    break;
                }
            }

            if (itemcounter > -1)
            {
                calendarItemsCache.RemoveAt(itemcounter);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedItems();
        }

        private void ButtonCreateTreatment_Click(object sender, EventArgs e)
        {
            DateTime selectionStart = CalendarBooking.SelectedElementStart.Date;
            DateTime selectionEnd = CalendarBooking.SelectedElementEnd.Date.AddMinutes((int)CalendarBooking.TimeScale);

            string message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} fra kl. {selectionStart.ToString("H:mm")} til kl. {selectionEnd.ToString("H:mm")} den {selectionStart.ToString("dd/M")}";


            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Treatment treatment = TreatmentFaktory.Instance().CreateTreatment((int)ComboBoxTreatmentType.SelectedValue, -1, -1, -1, selectionStart, selectionEnd, false);
                Treatment treatmentWithID = bossController.treatmentController.CreateTreatment(treatment);

                AddTreatmentToCache(treatmentWithID);
            }
            PlaceItems();
        }
    }
}
