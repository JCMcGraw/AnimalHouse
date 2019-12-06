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
    public partial class TreatmentForm : Form
    {
        public Treatment treatment { get; private set; }

        public TreatmentForm(Treatment treatment)
        {
            InitializeComponent();
            this.treatment = treatment;
          
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

        private void TreatmentForm_Load_1(object sender, EventArgs e)
        {
            string animalName= treatment.animal.name.ToString();
            string underheadline = treatment.animal.Species.speciesType+", " + treatment.treatmentType.name.ToString();
            string underheadline2 = "Ejet af: "+treatment.animal.customer.name.ToString();

            label_header.Text = animalName;
            label_underheadline.Text = underheadline;
            label_underheadline2.Text = underheadline2;

            //husk at slette alt det jazz i itemmanager

            LoadAllItemsInComboBox();
        }

        private void button_gem_Click(object sender, EventArgs e)
        {
            string entry = textBox_entry.Text.ToString();

            MedicalRecord medicalRecord = MedicalRecordFactory.Instance().CreateMedicalRecord(entry, treatment.animal, treatment);
                
            BossController.Instance().animalController.CreateMedicalRecordEntry(medicalRecord);
            //UpdateStatus(3);

            MessageBox.Show("Behandling gemt");
            this.Close();
        }

        private void button_recept_Click(object sender, EventArgs e)
        {
            Item prescriptionItem = (Item)comboBox_recept.SelectedItem;
            
            SaleItemForm saleItemForm = new SaleItemForm(prescriptionItem);
            saleItemForm.RemovePriceOption();

            
            if (saleItemForm.ShowDialog() == DialogResult.OK)
            {
                int amount = saleItemForm.saleLineItem.amount;



                DateTime prescriptionDay = DateTime.Now;
                Employee employee = treatment.employee;
                Animal animal = treatment.animal;
                Item item = prescriptionItem;

                Prescription prescription = PrescriptionFactory.Instance().CreatePrescription(amount, prescriptionDay, employee, animal, item);
                prescription = BossController.Instance().animalController.CreatePrescription(prescription);

                MessageBox.Show(prescription.item.name.ToString() + " Udstedet til " + animal.name.ToString());
            }
            

           
        }

        public void LoadAllItemsInComboBox()
        {
            List<Item> prescriptionItemList = GetPerscriptionList();
            comboBox_recept.DataSource = prescriptionItemList;
            comboBox_recept.DisplayMember = "name";
        }

        public List<Item>GetPerscriptionList()
        {
            List<Item> itemList = BossController.Instance().saleController.GetAllActiveItems();
            List<Item> prescriptionItemList = new List<Item>();

            
            foreach (Item item in itemList)
            {
                if (item.active==true&&item.prescription==true)
                {
                    prescriptionItemList.Add(item);
                }
            }

            return prescriptionItemList;
        }

        private void UpdateTreatmentStatus(int status)
        {
            int treatmentID = treatment.treatmentID;

            //get updated treatment
            Treatment newTreatment = GetUpdatedTreatmentStatus(treatmentID, status);
            //update treatment in database
            
            BossController.Instance().treatmentController.UpdateTreatment(newTreatment);
        }

        private Treatment GetUpdatedTreatmentStatus(int treatmentID, int status)
        {
            Treatment oldTreatment = treatment;
            Treatment newTreatment = TreatmentFactory.Instance().CreateTreatment(treatmentID, oldTreatment.treatmentType, oldTreatment.operationRoom, oldTreatment.cage, oldTreatment.item,
                oldTreatment.startTime, oldTreatment.endTime, oldTreatment.payed, oldTreatment.headline, oldTreatment.active, oldTreatment.animal, oldTreatment.employee, status);

            return newTreatment;
        }
    }
}
