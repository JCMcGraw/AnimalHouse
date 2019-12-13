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
    public partial class SelectItemForTreatmentForm : Form
    {
        public List<Item> items;
        public Item selectedItem;

        BossController bossController = BossController.Instance();

        public SelectItemForTreatmentForm(TreatmentType treatmentType)
        {
            InitializeComponent();
            GetAllItems();

            if(treatmentType.treatmentTypeID == 3)
            {
                FilterObservations();
            }
            else
            {
                FilterNotObservations();
            }

        }

        #region Form methods

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

        private void GetAllItems()
        {
            items = bossController.itemController.GetAllActiveItems();
        }

        private void FilterObservations()
        {
            items = items.Where(x => x.name.Contains("Observation") && x.isTreatment == true).ToList<Item>();
            BindItemDataGrid();
        }

        private void FilterNotObservations()
        {
            items = items.Where(x => x.name.Contains("Observation") == false && x.isTreatment == true).ToList<Item>();
            BindItemDataGrid();
        }

        private void BindItemDataGrid()
        {
            ItemDataGridView.Columns["ItemName"].DataPropertyName = "name";
            ItemDataGridView.Columns["itemPrice"].DataPropertyName = "price";

            items = items.OrderBy(x => x.name).ToList<Item>();
            ItemDataGridView.DataSource = items;
        }
        
        private void SearchItemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchItemTextBox.Text == "")
            {
                ItemDataGridView.DataSource = items;
            }
            else
            {
                List<Item> searchedItems = items.Where(x => x.name.ToLower().Contains(SearchItemTextBox.Text.ToLower())).ToList<Item>();
                ItemDataGridView.DataSource = searchedItems;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = ItemDataGridView.SelectedRows[0];

            selectedItem = row.DataBoundItem as Item;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void CancellingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
