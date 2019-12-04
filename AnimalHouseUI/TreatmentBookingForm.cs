using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AnimalHouseEntities;
using System.Windows.Forms.Calendar;
using System.Data;
using AnimalHouse;
using System.Linq;
using System.Threading;

namespace AnimalHouseUI
{
    public partial class TreatmentBookingForm : Form
    {
        BossController bossController = BossController.Instance();

        Animal animal;

        List<OperationRoom> operationRooms;
        List<Cage> cages;

        Dictionary<int, Treatment> treatmentsCache = new Dictionary<int, Treatment>();

        DateTime treatmentCacheDateStart = DateTime.Today;
        DateTime treatmentCacheDateEnd = DateTime.Today;

        List<CalendarItem> calendarItemsCache = new List<CalendarItem>();
        //CalendarItem contextItem = null;

        
        public TreatmentBookingForm()
        {
            InitializeComponent();
            SetValuesForComboboxes();
            SetOperationRooms();
            SetCages();
            ComboBoxEmployee.SelectedIndex = 0;
            ComboBoxTreatmentType.SelectedIndex = 0;

            SelectWeek(DateTime.Today);
        }

        private void SetOperationRooms()
        {
            operationRooms = bossController.treatmentController.GetAllOperationRooms();
        }

        private void SetCages()
        {
            cages = bossController.treatmentController.GetAllCages();
        }

        private void SetValuesForComboboxes()
        {
            List<Employee> employees = bossController.employeeController.GetAllEmployees();

            List<Employee> vets = employees.Where(x => x.title.titleID == 1).ToList<Employee>();

            vets.Insert(0, new Employee(-1, "Alle", true, -1, new Title("Dyrlæge", -1)));

            ComboBoxEmployee.DataSource = vets;
            ComboBoxEmployee.DisplayMember = "name";


            List<TreatmentType> treatmentTypes = bossController.treatmentController.GetManyTreatmentTypes();
            
            ComboBoxTreatmentType.DataSource = treatmentTypes;
            ComboBoxTreatmentType.DisplayMember = "name";
            ComboBoxTreatmentType.ValueMember = "treatmentTypeID";
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
                    CalendarRangeStart = GetFirstDayOfWeek(MonthViewBooking.SelectionStart);
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
                if (treatment.employee == null)
                {
                    calendarItem.EmployeeID = -1;
                }
                else
                {
                    calendarItem.EmployeeID = treatment.employee.employeeID;
                }
                calendarItemsCache.Add(calendarItem);
            }
        }

        private void CalendarBooking_MouseClick(object sender, MouseEventArgs e)
        {
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

            CalendarBooking.Items.Clear();
            foreach (CalendarItem item in calendarItemsCache)
            {
                if (CalendarBooking.ViewIntersects(item))
                {
                    if (treatmenttype == 3)
                    {
                        if(treatmentsCache[item.TreatmentID].treatmentType.treatmentTypeID == 3)
                        {
                            CalendarBooking.Items.Add(item);
                            //if (Status==1)
                            //{
                            //    //BlueCollor();
                            //} 
                        }
                    }
                    else
                    {
                        if (treatmentsCache[item.TreatmentID].treatmentType.treatmentTypeID != 3)
                        {
                            Employee selectedEmployee = (Employee)ComboBoxEmployee.SelectedItem;

                            if (selectedEmployee.employeeID == -1)
                            {
                                CalendarBooking.Items.Add(item);

                                //if (Status==1)
                                //{
                                //    //BlueCollor();
                                //}
                            }
                            else if(item.EmployeeID == selectedEmployee.employeeID)
                            {
                                CalendarBooking.Items.Add(item);

                                //if (Status==1)
                                //{
                                //    //BlueCollor();
                                //}
                            }
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
                PanelViewSelection.Visible = false;
                radioButtonWeekView.Checked = true;
                //set view to day view
                CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionStart.AddDays(14));
            }
            else
            {
                PanelViewSelection.Visible = true;
                //set view to detailed view
                CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionEnd);
            }
        }

        private void SelectWeek(DateTime today)
        {

            switch (today.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    MonthViewBooking.SelectionStart = today.AddDays(1);
                    MonthViewBooking.SelectionEnd = today.AddDays(5);
                    break;
                case DayOfWeek.Monday:
                    MonthViewBooking.SelectionStart = today;
                    MonthViewBooking.SelectionEnd = today.AddDays(4);
                    break;
                case DayOfWeek.Tuesday:
                    MonthViewBooking.SelectionStart = today.AddDays(-1);
                    MonthViewBooking.SelectionEnd = today.AddDays(3);
                    break;
                case DayOfWeek.Wednesday:
                    MonthViewBooking.SelectionStart = today.AddDays(-2);
                    MonthViewBooking.SelectionEnd = today.AddDays(2);
                    break;
                case DayOfWeek.Thursday:
                    MonthViewBooking.SelectionStart = today.AddDays(-3);
                    MonthViewBooking.SelectionEnd = today.AddDays(1);
                    break;
                case DayOfWeek.Friday:
                    MonthViewBooking.SelectionStart = today.AddDays(-4);
                    MonthViewBooking.SelectionEnd = today;
                    break;
                case DayOfWeek.Saturday:
                    MonthViewBooking.SelectionStart = today.AddDays(-5);
                    MonthViewBooking.SelectionEnd = today.AddDays(-1);
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

        private List<OperationRoom> GetAllAvailableOperationRooms(List<OperationRoom> operationRooms, DateTime SuggestedStartTime, DateTime SuggestedEndTime)
        {
            List<OperationRoom> availableOperationRooms = new List<OperationRoom>();
            List<Treatment> treatments = bossController.treatmentController.GetManyTreatmentsByDateTime(SuggestedStartTime.Date, SuggestedStartTime.Date.AddDays(1));


            foreach (OperationRoom operationRoom in operationRooms)
            {
                if (CheckAvailabilityForOperationRooms(operationRoom, SuggestedStartTime, SuggestedEndTime, treatments) == true)
                {
                    availableOperationRooms.Add(operationRoom);
                }
            }

            return availableOperationRooms;
        }

        private bool CheckAvailabilityForOperationRooms(OperationRoom operationRoom, DateTime SuggestedStartTime, DateTime SuggestedEndTime, List<Treatment> treatments = null)
        {
            if (treatments == null)
            {
                treatments = bossController.treatmentController.GetManyTreatmentsByDateTime(SuggestedStartTime.Date, SuggestedStartTime.Date.AddDays(1));
            }

            foreach (Treatment treatment in treatments)
            {
                if (treatment.operationRoom.operationRoomID == operationRoom.operationRoomID)
                {
                    if ((treatment.startTime >= SuggestedStartTime && treatment.startTime < SuggestedEndTime) || (treatment.endTime > SuggestedStartTime && treatment.endTime <= SuggestedEndTime) ||
                        (treatment.startTime <= SuggestedStartTime && treatment.endTime >= SuggestedEndTime))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        
        private List<Employee> GetAllAvailableEmployeesForConsultationOrOperation(List<Employee> employees, DateTime SuggestedStartTime, DateTime SuggestedEndTime)
        {
            List<Employee> availableEmployees = new List<Employee>();
            List<Treatment> treatments = bossController.treatmentController.GetManyTreatmentsByDateTime(SuggestedStartTime.Date, SuggestedStartTime.Date.AddDays(1));


            foreach(Employee employee in employees)
            {
                if (CheckAvailabilityForConsultationOrOperation(employee, SuggestedStartTime, SuggestedEndTime, treatments) == true && employee.employeeID != -1)
                {
                    availableEmployees.Add(employee);
                }
            }

            return availableEmployees;
        }

        private bool CheckAvailabilityForConsultationOrOperation(Employee employee, DateTime SuggestedStartTime, DateTime SuggestedEndTime, List<Treatment> treatments = null)
        {
            if(treatments == null)
            {
                treatments = bossController.treatmentController.GetManyTreatmentsByDateTime(SuggestedStartTime.Date, SuggestedStartTime.Date.AddDays(1));
            }

            foreach(Treatment treatment in treatments)
            {
                if (treatment.employee != null && treatment.employee.employeeID == employee.employeeID)
                {
                    if ((treatment.startTime >= SuggestedStartTime && treatment.startTime < SuggestedEndTime) || (treatment.endTime > SuggestedStartTime && treatment.endTime <= SuggestedEndTime) ||
                        (treatment.startTime <= SuggestedStartTime && treatment.endTime >= SuggestedEndTime))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void CalendarBooking_ItemCreating(object sender, CalendarItemCancelEventArgs e)
        {
            Employee selectedEmployee = null;
            OperationRoom selectedOperationRoom = null;
            Cage selectedCage = null;

            bool employeeAvailable = true;

            if (animal == null)
            {
                MessageBox.Show("Du skal vælge et dyr, inden du opretter en aftale");
                e.Cancel = true;
                return;
            }

            if(((TreatmentType)ComboBoxTreatmentType.SelectedItem).treatmentTypeID != 3)
            {
                //if employee is selected in combobox check availability to avoid double bookings
                if (((Employee)ComboBoxEmployee.SelectedItem).employeeID != -1)
                {
                    selectedEmployee = (Employee)ComboBoxEmployee.SelectedItem;
                    employeeAvailable = CheckAvailabilityForConsultationOrOperation(selectedEmployee, e.Item.StartDate, e.Item.EndDate);

                    if (employeeAvailable == false)
                    {
                        MessageBox.Show($"{selectedEmployee.name} er ikke fri i det valgte tidsrum, vælg venligst et andet tidspunkt");
                        e.Cancel = true;
                        return;
                    }
                }
                //else check all employees for availability and show form with selection option to select employee
                else
                {
                    List<Employee> availableEmployees = GetAllAvailableEmployeesForConsultationOrOperation((List<Employee>)ComboBoxEmployee.DataSource, e.Item.StartDate, e.Item.EndDate);
                    SelectEmployeeForTreatmentForm selectEmployeeForTreatmentForm = new SelectEmployeeForTreatmentForm(availableEmployees);
                    selectEmployeeForTreatmentForm.ShowDialog();

                    if (selectEmployeeForTreatmentForm.DialogResult == DialogResult.OK)
                    {
                        selectedEmployee = selectEmployeeForTreatmentForm.selectedEmployee;
                    }
                    else
                    {
                        MessageBox.Show($"Der blev ikke valgt en dyrlæge, prøv venligst igen");
                        e.Cancel = true;
                        return;
                    }
                }
            }
            
            //check availability of operating rooms if treatment type is operation
            if (((TreatmentType)ComboBoxTreatmentType.SelectedItem).treatmentTypeID == 2)
            {
                List<OperationRoom> availableOperationRooms = GetAllAvailableOperationRooms(operationRooms, e.Item.StartDate, e.Item.EndDate);

                if (availableOperationRooms.Count == 0)
                {
                    MessageBox.Show("Der er ikke nogle operationsstuer ledige på dette tidspunkt.");
                    e.Cancel = true;
                    return;
                }
                else
                {

                    SelectOperationRoomForTreatmentForm selectOperationRoomForTreatmentForm = new SelectOperationRoomForTreatmentForm(operationRooms);
                    selectOperationRoomForTreatmentForm.ShowDialog();
                    if (selectOperationRoomForTreatmentForm.DialogResult == DialogResult.OK)
                    {
                        selectedOperationRoom = selectOperationRoomForTreatmentForm.selectedOperationRoom;
                    }
                    else
                    {
                        MessageBox.Show($"Der blev ikke valgt en operationsstue, prøv venligst igen");
                        e.Cancel = true;
                        return;
                    }
                }
            }

            if (((TreatmentType)ComboBoxTreatmentType.SelectedItem).treatmentTypeID == 3)
            {
                SelectCageForTreatmentForm selectCageForTreatmentForm = new SelectCageForTreatmentForm(cages);
                selectCageForTreatmentForm.ShowDialog();

                if (selectCageForTreatmentForm.DialogResult == DialogResult.OK)
                {
                    selectedCage = selectCageForTreatmentForm.selectedCage;
                }
                else
                {
                    MessageBox.Show($"Der blev ikke valgt et observationsbur, prøv venligst igen");
                    e.Cancel = true;
                    return;
                }

            }

                //question string for verifying items
                string message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} fra kl. {e.Item.StartDate.ToString("H:mm")} til kl. {e.Item.EndDate.ToString("H:mm")} den {e.Item.StartDate.ToString("dd/M")}";
            //altered question string if treatment type is Observation
            if ((int)ComboBoxTreatmentType.SelectedValue == 3)
            {
                message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} fra {e.Item.StartDate.ToString("dd/M")} til {e.Item.EndDate.ToString("dd/M")}";
            }

            string headline;
            if (((TreatmentType)ComboBoxTreatmentType.SelectedItem).treatmentTypeID == 3)
            {
                headline = $"{ComboBoxTreatmentType.Text}";
            }
            else
            {
                headline = $"{ComboBoxTreatmentType.Text}, {selectedEmployee.name}";
            }


            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //dummy item for testing
                Item item = ItemFactory.Instance().CreateItem(9, "Vaccination", 1, 399m, 299m, false, true, true);

                //create new treatment
                Treatment treatment = TreatmentFactory.Instance().CreateTreatment((TreatmentType)ComboBoxTreatmentType.SelectedItem, selectedOperationRoom, selectedCage, item, e.Item.StartDate, e.Item.EndDate, false, headline, true, animal, selectedEmployee);

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
            //check if times haven't been changed
            if (e.Item.StartDate == treatmentsCache[e.Item.TreatmentID].startTime && e.Item.EndDate == treatmentsCache[e.Item.TreatmentID].endTime)
            {
                return;
            }

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
            Treatment newTreatment = TreatmentFactory.Instance().CreateTreatment(treatmentID, oldTreatment.treatmentType, oldTreatment.operationRoom, oldTreatment.cage, oldTreatment.item,
                newStartTime, newEndTime, oldTreatment.payed, oldTreatment.headline, oldTreatment.active, oldTreatment.animal, oldTreatment.employee);

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

        private void ComboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaceItems();
        }

        private void ChooseAnimalButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();

            if (customerForm.DialogResult == DialogResult.OK)
            {
                animal = customerForm.selectedAnimal;
            }
        }

        private void CalendarBooking_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            //itemToolTip.Show(e.Item.Text,CalendarBooking);
        }

        private void radioButtonWeekView_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekView.Checked == true)
            {
                MonthViewBooking.SelectionMode = MonthView.MonthViewSelection.WorkWeek;
                SelectWeek(MonthViewBooking.SelectionStart);
            }
            else
            {
                MonthViewBooking.SelectionMode = MonthView.MonthViewSelection.Day;

                if (MonthViewBooking.SelectionStart < DateTime.Now && MonthViewBooking.SelectionEnd > DateTime.Now)
                {
                    MonthViewBooking.SelectionStart = DateTime.Today;
                    MonthViewBooking.SelectionEnd = DateTime.Today;
                }
                else
                {
                    MonthViewBooking.SelectionEnd = MonthViewBooking.SelectionStart;
                }
            }
        }

        private void CalendarBooking_ItemClick(object sender, CalendarItemEventArgs e)
        {
            if (e.MouseEventArgs.Button == MouseButtons.Right)
            {
                ContextMenuStripBooking.Show(Cursor.Position);
                
            }

        }

        private void CalendarBooking_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            BlueCollor();
            RemoveCustomerFromWaitingRoom(nr);


            int treatmentID = e.Item.TreatmentID;
            Treatment treatment = treatmentsCache[treatmentID];

            TreatmentForm treatmentform = new TreatmentForm(treatment);
            treatmentform.Show();
        }

        private void button_startbehandling_Click(object sender, EventArgs e)
        {
            StartTreatment();
            BlueCollor();
            RemoveCustomerFromWaitingRoom(nr);
        }

        public void StartTreatment()
        {
            List<CalendarItem> calendaritems=(List<CalendarItem>)CalendarBooking.GetSelectedItems();
            if (calendaritems.Count==0)
            {
                MessageBox.Show("Der er ikke valgt nogen aftale");
            }
            else if (calendaritems.Count>1)
            {
                MessageBox.Show("Der kan kun vælges en enkelt aftalte");
            }
            else
            {
                int treatmentID = calendaritems[0].TreatmentID;
                Treatment treatment = treatmentsCache[treatmentID];

                TreatmentForm treatmentform = new TreatmentForm(treatment);
                treatmentform.Show();
            }
        }

        private void AnkommetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedCollor();

            Thread waitingRoom = new Thread(() => AddCustomerToWaitingRoom(nr));
            waitingRoom.Start();
            CheckForIllegalCrossThreadCalls = false;
        }

        List<int> kunder = new List<int>();
        int nr = 0;

        private void AddCustomerToWaitingRoom(int nr)
        { 
            kunder.Add(nr++);
            WaitingRoomLable.Text = kunder.LongCount().ToString();  
        }

        private void RemoveCustomerFromWaitingRoom(int nr)
        {
            kunder.Remove(nr--);
            WaitingRoomLable.Text = kunder.LongCount().ToString();
        }

        private void ContextMenuStripBooking_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //skal Fjernes
        }

        private void RedCollor()
        {
            foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                CalendarBooking.Invalidate(item);
            }
        }

        private void BlueCollor()
        {
            foreach (CalendarItem item in CalendarBooking.GetSelectedItems())
            {
                item.ApplyColor(Color.Blue);
                CalendarBooking.Invalidate(item);
            }
        }
    }
}
