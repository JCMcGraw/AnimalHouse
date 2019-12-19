using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseEntities;
using AnimalHouse;

namespace AnimalHouseUI
{
    public partial class SendReminderForm : Form
    {
        BossController bossController = BossController.Instance();
        List<Treatment> treatments;

        public SendReminderForm()
        {
            InitializeComponent();
            RemindersDataGridView.AutoGenerateColumns = false;
        }

        #region Form Functions 

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


        #endregion

        private void GetRemindersToSend_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            DateTime startDate, endDate;

            GetTheWeekFromAYearAgo(out startDate, out endDate);

            try
            {
                treatments = BossController.Instance().treatmentController.GetManyTreatmentsForSendingRminders(startDate, endDate);
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorManager.Instance().GetErrorMessage(exception));
            }

            RemindersDataGridView.DataSource = treatments;
            EnterDataInDataGridViewCells();
        }

        private void EnterDataInDataGridViewCells()
        {
            try
            {
                for (int i = 0; i < treatments.Count; i++)
                {
                    RemindersDataGridView.Rows[i].Cells["Customer"].Value = treatments[i].animal.customer.name;
                    RemindersDataGridView.Rows[i].Cells["Email"].Value = treatments[i].animal.customer.email;
                    RemindersDataGridView.Rows[i].Cells["Animal"].Value = treatments[i].animal.name;
                    RemindersDataGridView.Rows[i].Cells["Species"].Value = treatments[i].animal.Species.speciesName;
                    RemindersDataGridView.Rows[i].Cells["LatestVisit"].Value = treatments[i].endTime.ToString("d/M/yyyy");
                }
            }
            catch
            { }
        }

        private void GetTheWeekFromAYearAgo(out DateTime startDate, out DateTime endDate)
        {
            DateTime oneYearAgo = DateTime.Today.AddYears(-1);
            switch (oneYearAgo.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    startDate = oneYearAgo.AddDays(-6);
                    endDate = oneYearAgo.AddDays(1);
                    break;
                case DayOfWeek.Monday:
                    startDate = oneYearAgo;
                    endDate = oneYearAgo.AddDays(7);
                    break;
                case DayOfWeek.Tuesday:
                    startDate = oneYearAgo.AddDays(-1);
                    endDate = oneYearAgo.AddDays(6);
                    break;
                case DayOfWeek.Wednesday:
                    startDate = oneYearAgo.AddDays(-2);
                    endDate = oneYearAgo.AddDays(5);
                    break;
                case DayOfWeek.Thursday:
                    startDate = oneYearAgo.AddDays(-3);
                    endDate = oneYearAgo.AddDays(4);
                    break;
                case DayOfWeek.Friday:
                    startDate = oneYearAgo.AddDays(-4);
                    endDate = oneYearAgo.AddDays(3);
                    break;
                default:
                    startDate = oneYearAgo.AddDays(-5);
                    endDate = oneYearAgo.AddDays(2);
                    break;
                    
            }
        }

        private void SendToAllButton_Click(object sender, EventArgs e)
        {
            if (treatments==null)
            {
                MessageBox.Show("Der er ikke nogle at sende til");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Ønsker du at sende påmindelser til {treatments.Count} kunder?", "Book behandling", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Påmindelser sendt!");
                }
            }
        }

        private void SendToChosenButton_Click(object sender, EventArgs e)
        {
            if (treatments==null)
            {
                MessageBox.Show("Der er ikke nogle at sende til");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"Ønsker du at sende påmindelser til {RemindersDataGridView.SelectedRows.Count} kunder?", "Book behandling", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Påmindelser sendt!");
                }
            }
        }
    }
}
