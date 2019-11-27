using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouse;
using AnimalHouseEntities;

namespace AnimalHouseUI
{
    public partial class SaleForm : Form
    {
        Sale sale;
        Customer customer;
        List<Item> items;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadeAllItemsInListBox();
            sale = new Sale(customer,DateTime.Now);

            DataGridViewItemList.AutoGenerateColumns = false;
            ItemDataGridView.AutoGenerateColumns = false;
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

        private void SearchPhoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                customer = BossController.instance().customerController.GetCustomer(PhoneTextBox.Text);

                CustomerNameLabel.Text = customer.name.ToString();
                CustomerNameLabel.Enabled = true;
                AdressTextBox.Text = customer.address;
                EmailTextBox.Text = customer.email;

                sale.SetCustomer(customer);
            }
            catch (Exception)
            {
                MessageBox.Show("Prøv igen ");
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            try
            {
                BossController.instance().saleController.CreateSale(sale);
                MessageBox.Show("Salg Oprettet");
            }
            catch (Exception)
            {
                MessageBox.Show("prøv igen");
            }
        }

        private void FakturaButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LoadeAllItemsInListBox()
        {
            try
            {
                ItemDataGridView.Columns["ItemName"].DataPropertyName = "name";
                ItemDataGridView.Columns["itemAmount"].DataPropertyName = "amount";
                ItemDataGridView.Columns["itemPrice"].DataPropertyName = "price";

                items = BossController.instance().saleController.GetAllActiveItems();
                ItemDataGridView.DataSource = items;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ItemDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (customer != null)
                {
                    DataGridViewRow row = ItemDataGridView.SelectedRows[0];

                    Item item = row.DataBoundItem as Item;
                    SaleItemForm saleItemForm = new SaleItemForm(item);

                    if (saleItemForm.ShowDialog() == DialogResult.OK)
                    {
                        SaleLineItem saleLineItem = saleItemForm.saleLineItem;

                        if (sale == null)
                        {
                            sale = new Sale(customer, DateTime.Now);
                        }

                        sale.AddSaleLineItem(saleLineItem);

                        DataGridViewItemList.Columns["Amount"].DataPropertyName = "amount";
                        DataGridViewItemList.Columns["Price"].DataPropertyName = "price";

                        DataGridViewItemList.DataSource = null;
                        DataGridViewItemList.DataSource = sale.saleLineItems;

                        for (int i = 0; i < DataGridViewItemList.RowCount; i++)
                        {

                            Item item2 = sale.saleLineItems[i].item;

                            DataGridViewItemList.Rows[i].Cells["Name"].Value = item2.name;

                            FillPriceInLable(item2.price,item2.amount);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Du skal finde en kunde før du kan tilføje vare til et salg");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("noget gik galt");
            }
        }

        private void FillPriceInLable(decimal price,int amount)
        {
            try
            {
                for (int i = 0; i < DataGridViewItemList.RowCount; i++)
                {
                    price = Convert.ToInt32(DataGridViewItemList.Rows[i].Cells["Price"].Value);
                    amount = Convert.ToInt32(DataGridViewItemList.Rows[i].Cells["Amount"].Value);
                }

                TotalPriceLabel.Text = Convert.ToString(sale.Price(price, amount));

                MomsLabel.Text = Convert.ToString(sale.Moms(sale.Price(price, amount)));

                TotalInkMomsLabel.Text = Convert.ToString(sale.TotalPriceInkMoms(sale.Price(price, amount), sale.Moms(sale.Price(price, amount))));
            }
            catch (Exception)
            {
                MessageBox.Show("noget gik galt");
            }
        }

        private void NewSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                customer = null;
                CustomerNameLabel.Text = "";
                PhoneTextBox.Text = "";
                AdressTextBox.Text = "";
                EmailTextBox.Text = "";
                TotalPriceLabel.Text = "0";
                MomsLabel.Text = "0";
                TotalInkMomsLabel.Text = "0";
                 
                sale = new Sale(customer,DateTime.Now);
                DataGridViewItemList.DataSource = null;
                SearchItemTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("noget gik galt");
            }
        }

        private void SearchItemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchItemTextBox.Text == "")
                {
                    ItemDataGridView.DataSource = items;
                }
                else
                {
                    List<Item> itemss = items.Where(x => x.name.ToLower().Contains(SearchItemTextBox.Text.ToLower())).ToList<Item>();
                    ItemDataGridView.DataSource = itemss;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Noget gik galt");
            }
        }        
    }
}

