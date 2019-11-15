using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using AnimalHouseEntities;
using AnimalHouse;

namespace AnimalHouseUI
{
    public partial class TreatmentBooking : Form
    {
        

        List<CalendarItem> calendarItemsCache = new List<CalendarItem>();
        CalendarItem contextItem = null;

        public TreatmentBooking()
        {
            InitializeComponent();
            ComboBoxEmployee.SelectedIndex = 0;
            ComboBoxTreatmentType.SelectedIndex = 0;

            SelectCurrentWeek();

            //string query = "insert into customer values ('Larsen', 'gadenavn 211', '666', 'mail2@mail.com)',1)";
            //AnimalHousePersistence.SQLQuery sQLQuery = new AnimalHousePersistence.SQLQuery(query);
            //AnimalHousePersistence.SQLQueryResult sQLQueryResult = AnimalHousePersistence.SQLDatabaseConnector.QueryDatabase(sQLQuery);

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
            if (ComboBoxTreatmentType.Text == "Observation")
            {
                CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionStart.AddDays(14));
            }
            else
            {
                if (MonthViewBooking.SelectionEnd.Year != 1)
                {
                    CalendarBooking.SetViewRange(MonthViewBooking.SelectionStart, MonthViewBooking.SelectionEnd);
                }
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
            foreach (CalendarItem item in calendarItemsCache)
            {
                if (CalendarBooking.ViewIntersects(item))
                {
                    CalendarBooking.Items.Add(item);
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
            string message = $"Ønsker du at oprette denne {ComboBoxTreatmentType.Text} kl. {e.Item.StartDate.ToString("HH:mm")} den {e.Item.StartDate.ToString("M/dd")}";


            DialogResult dialogResult = MessageBox.Show(message, "Book behandling", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Treatment treatment = new Treatment(1, -1, -1, -1, e.Item.StartDate, e.Item.EndDate, false);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
