using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AnimalHouseEntities;
using System.Windows.Forms.Calendar;
using System.Data;
using AnimalHouse;
using System.Linq;

namespace AnimalHouseUI
{
    public partial class TreatmentBookingForm : Form
    {
        BossController bossController = BossController.instance();

        Dictionary<int, Treatment> treatmentsCache = new Dictionary<int, Treatment>();

        DateTime treatmentCacheDateStart = DateTime.Today;
        DateTime treatmentCacheDateEnd = DateTime.Today;

        List<CalendarItem> calendarItemsCache = new List<CalendarItem>();
        CalendarItem contextItem = null;

        
        public TreatmentBookingForm()
        {
            InitializeComponent();
            DummyValuesForComboboxes();
            ComboBoxEmployee.SelectedIndex = 0;
            ComboBoxTreatmentType.SelectedIndex = 0;

            SelectCurrentWeek();
        }

        private void DummyValuesForComboboxes()
        {
            List<Employee> employees = bossController.employeeController.GetAllEmployees();

            List<Employee> vets = new List<Employee>();

            vets.Add(new Employee(-1, "Alle", true, -1, new Title("Dyrlæge", -1)));

            foreach(var employee in employees)
            {
                if (employee.title.titleID == 1)
                {
                    vets.Add(employee);
                }
            }

            ComboBoxEmployee.DataSource = vets;
            ComboBoxEmployee.DisplayMember = "name";


            List<TreatmentType> treatmentTypes = bossController.treatmentController.GetManyTreatmentTypes();
            
            ComboBoxTreatmentType.DataSource = treatmentTypes;
            ComboBoxTreatmentType.DisplayMember = "name";
            ComboBoxTreatmentType.ValueMember = "treatmentTypeID";

            //ComboBoxTreatmentType.DisplayMember = "treatment";
            //ComboBoxTreatmentType.ValueMember = "treatmentid";
        }

        #region form methods
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

        #endregion form methods

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
                    CalendarRangeStart = GetFirstDayOfWeek( MonthViewBooking.SelectionStart);
                    CalendarRangeEnd = CalendarRangeStart.AddDays(19);
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
            CalendarBooking.TimeUnitsOffset = -32;
                
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

                CalendarItem calendarItem = new CalendarItem(CalendarBooking, treatment.startTime, treatment.endTime, treatment.headline);
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
                    if (treatmenttype == 3)
                    {
                        if(treatmentsCache[item.TreatmentID].treatmentType.treatmentTypeID == 3)
                        {
                            CalendarBooking.Items.Add(item);
                        }
                    }
                    else
                    {
                        if (treatmentsCache[item.TreatmentID].treatmentType.treatmentTypeID != 3)
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
                //set view to day view
                CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionStart.AddDays(14));
            }
            else
            {
                //set view to detailed view
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
                    MonthViewBooking.SelectionEnd = DateTime.Today.AddDays(2);
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

        private DateTime GetFirstDayOfWeek(DateTime selectionStart)
        {
            DateTime newSelectedStartDate = selectionStart;
            switch (selectionStart.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    newSelectedStartDate = selectionStart.AddDays(1);
                    break;
                case DayOfWeek.Monday:
                    newSelectedStartDate = selectionStart;
                    break;
                case DayOfWeek.Tuesday:
                    newSelectedStartDate = selectionStart.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    newSelectedStartDate = selectionStart.AddDays(-2);
                    break;
                case DayOfWeek.Thursday:
                    newSelectedStartDate = selectionStart.AddDays(-2);
                    break;
                case DayOfWeek.Friday:
                    newSelectedStartDate = selectionStart.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    newSelectedStartDate = selectionStart.AddDays(-5);
                    break;
            }

            return newSelectedStartDate;
        }

        private List<Treatment> GetDoubleBookings(DateTime startTime, DateTime endTime)
        {
            List<Treatment> treatments = new List<Treatment>();

            foreach(var treatment in treatmentsCache)
            {
                if ((treatment.Value.endTime > startTime && treatment.Value.endTime <  endTime) || (treatment.Value.startTime > startTime && treatment.Value.startTime < endTime)||
                    (treatment.Value.startTime < startTime && treatment.Value.endTime > endTime))
                {
                    treatments.Add(treatment.Value);
                }
            }

            return treatments;
        }

        private void CalendarBooking_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            //question string for verifying items
            string message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} fra kl. {e.Item.StartDate.ToString("H:mm")} til kl. {e.Item.EndDate.ToString("H:mm")} den {e.Item.StartDate.ToString("dd/M")}";
            //altered question string if treatment type is Observation
            if ((int)ComboBoxTreatmentType.SelectedValue == 3)
            {
                message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} fra {e.Item.StartDate.ToString("dd/M")} til {e.Item.EndDate.ToString("dd/M")}";
            }
            
            string headline = ComboBoxTreatmentType.Text;


            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                //create new treatment
                Treatment treatment = TreatmentFactory.Instance().CreateTreatment((TreatmentType)ComboBoxTreatmentType.SelectedItem, -1, -1, -1, e.Item.StartDate, e.Item.EndDate, false, headline, true, -1, (Employee)ComboBoxEmployee.SelectedItem);

                //add treatment to database and get treatment with treatment ID
                Treatment treatmentWithID = bossController.treatmentController.CreateTreatment(treatment);

                //add treatment to cache
                AddTreatmentToCache(treatmentWithID);

                e.Item.Text = headline;
                e.Item.TreatmentID = treatment.treatmentID;
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

        //actions for calendaritems dates/times changed
        private void CalendarBooking_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {
            //question string for verifying new datetimes
            string message = $"Ønsker du at ændre denne aftale til kl. {e.Item.StartDate.ToString("H:mm")}-{e.Item.EndDate.ToString("H:mm")} den {e.Item.StartDate.ToString("dd/M")}?";
            //altered question string if treatment type is Observation
            if ((int)ComboBoxTreatmentType.SelectedValue == 3)
            {
                message = $"Ønsker du at ændre denne observation til {e.Item.StartDate.ToString("d/M")}-{e.Item.EndDate.ToString("d/M")}?";
            }

            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int treatmentID = e.Item.TreatmentID;

                //get updated treatment
                Treatment newTreatment = GetUpdatedTreatment(treatmentID, e.Item.StartDate, e.Item.EndDate);
                //update treatment in database
                bossController.treatmentController.UpdateTreatment(newTreatment);

                //remove old treatment from cache
                treatmentsCache.Remove(treatmentID);
                //add updated treatment to cache
                treatmentsCache.Add(newTreatment.treatmentID, newTreatment);
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //reset datetimes to original
                e.Item.StartDate = treatmentsCache[e.Item.TreatmentID].startTime;
                e.Item.EndDate = treatmentsCache[e.Item.TreatmentID].endTime;
            }

            PlaceItems();
        }

        //return new treatment with updated start/end time
        private Treatment GetUpdatedTreatment(int treatmentID, DateTime newStartTime, DateTime newEndTime)
        {
            Treatment oldTreatment = treatmentsCache[treatmentID];
            Treatment newTreatment = TreatmentFactory.Instance().CreateTreatment(treatmentID, oldTreatment.treatmentType, oldTreatment.operationRoomID, oldTreatment.cageID, oldTreatment.item,
                newStartTime, newEndTime, oldTreatment.payed, oldTreatment.headline, oldTreatment.active, oldTreatment.animalID, oldTreatment.employee);

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
            //send 'enter' key press to calendar
            ContextMenuStripBooking.Close();
            CalendarBooking.Focus();
            SendKeys.Send("{DELETE}");
        }

        //actions for deleting treatment
        private void CalendarBooking_ItemDeleting(object sender, CalendarItemCancelEventArgs e)
        {
            string message = $"Ønsker du at slette denne aftale?";

            DialogResult dialogResult = MessageBox.Show(message, "Slet aftale", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int treatmentID = e.Item.TreatmentID;
                
                //delete treatement from database
                bossController.treatmentController.DeleteTreatment(treatmentID);

                //delete treatment fromm treatmentcache
                treatmentsCache.Remove(treatmentID);
                //delete calendaritem from items cache
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
            //button sends 'delete' key stroke to calendar
            CalendarBooking.Focus();
            SendKeys.Send("{DELETE}");
        }

        private void ButtonCreateTreatment_Click(object sender, EventArgs e)
        {
            //button sends 'enter' key stroke to calendar
            CalendarBooking.Focus();
            SendKeys.Send("{ENTER}");
        }
        
        private void CalendarBooking_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter has been pressed with calendar in focus and no selection made show message box
            if(e.KeyCode == Keys.Enter)
            {
                if (CalendarBooking.SelectedElementStart == null)
                {
                    MessageBox.Show("Du har ikke valgt en tid til at indsætte en ny aftale");
                }
            }

            //if delete has been pressed with calendar in focus and no treatement has been selected show message box
            if (e.KeyCode == Keys.Delete)
            {
                List<CalendarItem> calendarItems = CalendarBooking.GetSelectedItems().ToList<CalendarItem>();
                if (calendarItems.Count == 0)
                {
                    MessageBox.Show("Du har ikke valgt nogle aftaler at slette.");
                }
            }
        }
    }
}
