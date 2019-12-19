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
using System.Diagnostics;
using System.IO;
namespace AnimalHouseUI
{
    public partial class SaleForm : Form
    {
        Sale sale;
        Customer customer;
        List<Item> items;
        List<Prescription> prescriptions;
        List<Treatment> treatments;
        DateTime LastUpdate;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            ItemListDataGridView.AutoGenerateColumns = false;
            ItemDataGridView.AutoGenerateColumns = false;
            UnPaidPrescriptionsDataGridView.AutoGenerateColumns = false;
            UnPaidTreatmentDataGridView.AutoGenerateColumns = false;
            FakturaButton.Enabled = false;

            LoadAllItemsInListBox();
            sale = SaleFactory.Instance().CreateSale(customer, DateTime.Now);
            try
            {
                LastUpdate = BossController.Instance().itemController.GetLastUpdate();
                UpdateMedicineLabel.Text = "Dato for sidst opdateret medicinpriser: " + LastUpdate.ToString("dd-MM-yyyy");
            }
            catch
            {
                UpdateMedicineLabel.Text = "";
            }
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
            this.Cursor = Cursors.WaitCursor;

            try
            {
                customer = BossController.Instance().customerController.GetCustomer(PhoneTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorManager.Instance().GetErrorMessage(exception));
                this.Cursor = Cursors.Default;
                return;
            }

            CustomerNameLabel.Text = customer.name.ToString();
            CustomerNameLabel.Enabled = true;
            AdressTextBox.Text = customer.address;
            EmailTextBox.Text = customer.email;

            sale.SetCustomer(customer);
            LoadeAllUnPaidPrescriptions(customer);
            LoadeAllUnpaidTreatments(customer);

            this.Cursor = Cursors.Default;
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                BossController.Instance().saleController.CreateSale(sale);
            }
            catch (Exception exception)
            {
                string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                MessageBox.Show(errorMessage);
                this.Cursor = Cursors.Default;
                return;
            }
            MessageBox.Show("Salg Oprettet");
            FakturaButton.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void FakturaButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            BossController.Instance().saleController.CreateInvoice(sale);
            string file = "Faktura" + sale.saleID.ToString() + ".pdf";
            Process.Start(file);

            this.Cursor = Cursors.Default;
        }

        private void ShowStockButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            StockForm stockForm = new StockForm();
            stockForm.Show();

            this.Cursor = Cursors.Default;
        }

        private void NewSaleButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                customer = null;
                CustomerNameLabel.Text = "";
                PhoneTextBox.Text = "";
                AdressTextBox.Text = "";
                EmailTextBox.Text = "";
                TotalPriceLabel.Text = "";
                MomsLabel.Text = "";
                TotalInkMomsLabel.Text = "";

                sale = SaleFactory.Instance().CreateSale(customer, DateTime.Now);
                ItemListDataGridView.DataSource = null;
                UnPaidPrescriptionsDataGridView.DataSource = null;
                UnPaidTreatmentDataGridView.DataSource = null;
                SearchItemTextBox.Text = "";

                LoadAllItemsInListBox();
                EndButton.Enabled = false;
                FakturaButton.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("noget gik galt");
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void ItemDataGridView_DoubleClick(object sender, EventArgs e)
        {
            ChoseDataView1();
        }

        private void UnPaidPrescriptionsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            ChoseDataView2();
        }

        private void UnPaidTreatmentDataGridView_DoubleClick(object sender, EventArgs e)
        {
            ChoseDataView3();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Path.GetDirectoryName(Application.ExecutablePath) + "/helpfiles/Sale-Form-Help.pdf";
                Process.Start(file);
            }
            catch
            {
                MessageBox.Show("Hjælpefilen kunne ikke findes");
            }
        }

        private void DeleteItemInStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                int row = ItemListDataGridView.SelectedRows[0].Index;
                sale.saleLineItems.RemoveAt(row);
                LoadeItemList();

            }
            catch { }

        }

        private void ChoseDataView1()
        {
            DataGridViewRow row = ItemDataGridView.SelectedRows[0];
            Item item = row.DataBoundItem as Item;
            FillItemList(item,null,null);
        }

        private void ChoseDataView2()
        {
            DataGridViewRow row = UnPaidPrescriptionsDataGridView.SelectedRows[0];
            Prescription prescription = row.DataBoundItem as Prescription;
            FillItemList(prescription.item,prescription,null, prescription.amount);
        }

        private void ChoseDataView3()
        {
            DataGridViewRow row = UnPaidTreatmentDataGridView.SelectedRows[0];
            Treatment treatment = row.DataBoundItem as Treatment;
            
            int amount = 1;
            if (treatment.treatmentType.treatmentTypeID ==3)
            {
                amount = Convert.ToInt32((treatment.endTime - treatment.startTime).TotalDays);
                    
            }
                FillItemList(treatment.item,null,treatment,amount);
        }

        private void FillItemList(Item item,Prescription prescription,Treatment treatment, int amount= -1)
        {
            SaleItemForm saleItemForm = new SaleItemForm(item,prescription,treatment,amount);

            if (saleItemForm.ShowDialog() == DialogResult.OK)
            {
                SaleLineItem saleLineItem = saleItemForm.saleLineItem;

                if (sale == null)
                {
                    sale = SaleFactory.Instance().CreateSale(customer, DateTime.Now);
                }

                sale.AddSaleLineItem(saleLineItem);
                LoadeItemList();
                EndButton.Enabled = true;
            }
        }

        private void LoadeItemList()
        {
            ItemListDataGridView.Columns["Amount"].DataPropertyName = "amount";
            ItemListDataGridView.Columns["Price"].DataPropertyName = "price";

            ItemListDataGridView.DataSource = null;
            ItemListDataGridView.DataSource = sale.saleLineItems;

            for (int i = 0; i < ItemListDataGridView.RowCount; i++)
            {
                Item item2 = sale.saleLineItems[i].item;
                
                ItemListDataGridView.Rows[i].Cells["Name"].Value = item2.name;
            }
            FillPriceInLable();
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

        private void FillPriceInLable()
        {
            try
            {
                TotalPriceLabel.Text = sale.Price() +" Kr";
                MomsLabel.Text = sale.Moms() + " Kr";
                TotalInkMomsLabel.Text = sale.TotalPriceInkMoms() + " Kr";  
            }
            catch (Exception)
            {
                MessageBox.Show("noget gik galt");
            }
        }

        private void LoadAllItemsInListBox()
        {
            ItemDataGridView.Columns["ItemName"].DataPropertyName = "name";
            ItemDataGridView.Columns["itemAmount"].DataPropertyName = "amount";
            ItemDataGridView.Columns["itemPrice"].DataPropertyName = "price";

            try
            {
                items = BossController.Instance().itemController.GetAllActiveItems();
                items = items.Where(x => x.prescription.Equals(false) && x.treatment.Equals(false)).ToList<Item>();
                ItemDataGridView.DataSource = items;
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorManager.Instance().GetErrorMessage(exception));
            }
        }

        private void LoadeAllUnPaidPrescriptions(Customer customer)
        {
            try
            {
                prescriptions = BossController.Instance().animalController.GetUnpaidPrescriptionByCustomer(customer);
                UnPaidPrescriptionsDataGridView.DataSource = prescriptions;
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorManager.Instance().GetErrorMessage(exception));
            }

            for (int i = 0; i < UnPaidPrescriptionsDataGridView.RowCount; i++)
            {
                Prescription prescription = prescriptions[i];

                UnPaidPrescriptionsDataGridView.Rows[i].Cells["prescriptionName"].Value = prescription.item.name;
                UnPaidPrescriptionsDataGridView.Rows[i].Cells["prescriptionAmount"].Value = prescription.amount;
                UnPaidPrescriptionsDataGridView.Rows[i].Cells["prescriptionPrice"].Value = prescription.item.price;
            }
        }

        private void LoadeAllUnpaidTreatments(Customer customer)
        {
            try
            {
                treatments = BossController.Instance().treatmentController.GetUnpaidTreatmentsByCustomer(customer);
                UnPaidTreatmentDataGridView.DataSource = treatments;
            }
            catch (Exception exception)
            {
                MessageBox.Show(ErrorManager.Instance().GetErrorMessage(exception));
            }
            

            for (int i = 0; i < UnPaidTreatmentDataGridView.RowCount; i++)
            {
                Treatment treatment = treatments[i];

                UnPaidTreatmentDataGridView.Rows[i].Cells["treatmentName"].Value = treatment.item.name;
                UnPaidTreatmentDataGridView.Rows[i].Cells["treatmentDay"].Value = treatment.endTime;
                UnPaidTreatmentDataGridView.Rows[i].Cells["treatmentPrice"].Value = treatment.item.price;
            }
        }
    }
}

