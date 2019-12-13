using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using AnimalHouseEntities;
using AnimalHouse;

namespace AnimalHouseUI
{
    public partial class StockForm : Form
    {
        List<Item> allItems;
        List<Item> items;
        BossController bossController = BossController.Instance();

        public StockForm()
        {
            InitializeComponent();
            
            ItemDataGridView.AutoGenerateColumns = false;

            LoadAllItemsInListBox();
            AmountComboBox.SelectedIndex = 9;
        }

        #region Copy this 

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

        private void LoadAllItemsInListBox()
        {
            ItemDataGridView.Columns["itemName"].DataPropertyName = "name";
            ItemDataGridView.Columns["itemAmount"].DataPropertyName = "amount";
            ItemDataGridView.Columns["itemPrice"].DataPropertyName = "costPrice";
            try
            {
                allItems = bossController.itemController.GetAllActiveItems();
                ShowAllItems();
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorManager.Instance().GetErrorMessage(exception));
            }
        }

        private void ShowAllItems()
        {
            items = allItems.Where(item => item.isTreatment == false).ToList<Item>();

            ItemDataGridView.DataSource = items;

            ShowTotalStockValue();
        }

        private void ShowItemsUnderLimit(int limit)
        {
            items = allItems.Where(item => item.isTreatment == false && item.amount <= limit).ToList<Item>();

            ItemDataGridView.DataSource = items;

            ShowTotalStockValue();
        }

        private void AmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AmountCheckBox.Checked == false)
            {
                ShowAllItems();
            }
            else
            {
                ShowItemsUnderLimit(Convert.ToInt32(AmountComboBox.SelectedItem));
            }
        }

        private void AmountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AmountCheckBox.Checked == true)
            {
                ShowItemsUnderLimit(Convert.ToInt32(AmountComboBox.SelectedItem.ToString()));
            }
        }

        private void ShowTotalStockValue()
        {
            decimal totalStockValue = GetTotalStockValue();

            TotalValueLabel.Text = $"Total værdi: {totalStockValue.ToString("N2")}";
        }

        private decimal GetTotalStockValue()
        {
            decimal totalStockValue = 0;
            foreach (Item item in items)
            {
                totalStockValue += item.GetTotalStockValue();
            }
            return totalStockValue;
        }


        private PrintDocument docToPrint = new PrintDocument();

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string printText = GetStringOfItemList();
            docToPrint.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(printText, new Font("Times New Roman", 14), new SolidBrush(Color.Black), new RectangleF(10, 10, docToPrint.DefaultPageSettings.PrintableArea.Width, docToPrint.DefaultPageSettings.PrintableArea.Height));

            };

            PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;

            PrintDialog1.ShowHelp = true;
            
            PrintDialog1.Document = docToPrint;

            DialogResult result = PrintDialog1.ShowDialog();

            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();
            }
        }

        private string GetStringOfItemList()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach(Item item in items)
            {
                stringBuilder.Append(item.ToString() + "\n");
            }

            stringBuilder.Append($"\nTotal værdi: {GetTotalStockValue().ToString("N2")}");

            return stringBuilder.ToString();
        }
    }
}
