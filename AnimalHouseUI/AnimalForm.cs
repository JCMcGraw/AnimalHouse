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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;


namespace AnimalHouseUI
{
    public partial class AnimalForm : Form
    {
        Animal animal;
        Customer customer;
        List<Employee> employee;
        List<Species> species;
        List<Prescription> prescriptions;
        List<MedicalRecord> medicalRecords;
        public MedicalRecord selectedMedicalRecord;
        CustomerForm customerForm;



        //private DataTable Animal_Gender = new DataTable();

        public AnimalForm(Customer customer,Animal animal, CustomerForm customerForm)

        {
            this.customerForm = customerForm;
            this.customer = customer;
            this.animal = animal;
            InitializeComponent();
            animal_prescription.AutoGenerateColumns = false;


            button_create.Enabled = false;

            animal_name.Enabled = false;
            animal_bdate.Enabled = false;
            animal_species.Enabled = false;
            animal_gender.Enabled = false;
            animal_medicalRecords.AutoGenerateColumns = false;
            //MessageBox.Show(animal.gender.ToString());
        }
        private void SetStatusComboBoxToDefault()
        {
            animal_gender.SelectedIndex=0;
            animal_species.SelectedIndex = 0;
           
            
        }
        public AnimalForm(Customer customer, CustomerForm customerForm)

        {
            this.customerForm = customerForm;
            this.customer = customer;

           
            InitializeComponent();

            button_delete.Enabled = false;
            button_edit.Enabled = false;


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

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            
            //animal_medicalRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadeAllItemsInComboBox();
            BossController.Instance().animalController.GetSpecies();
            if( animal != null)
            {
                animal_owner.Text = "Ejer: " + customer.name;
                AnimalName_Label.Text = animal.name;
                
                animalSpecies_label.Text = animal.Species.speciesType.ToString();

                animal_name.Text = animal.name;
                animal_bdate.Text = Convert.ToString(animal.birthday);
                animal_species.Text = Convert.ToString(animal.Species.speciesType);
                animal_weight.Text = Convert.ToString(animal.weight);
                animal_gender.SelectedIndex = Convert.ToInt32(animal.gender);
                if (animal.Employee != null)
                {
                    animal_employee.Text = Convert.ToString(animal.Employee.name);
                }


                try
                {
                    prescriptions = BossController.Instance().animalController.GetAllPrescriptionByAnimal(animal.animalID);

                    animal.AddPrescriptionList(prescriptions);

                    animal_prescription.DataSource = prescriptions;

                    for (int i = 0; i < prescriptions.Count; i++)
                    {
                        Prescription tmpprescription = prescriptions[i];

                        animal_prescription.Rows[i].Cells["name"].Value = tmpprescription.item.name;
                        animal_prescription.Rows[i].Cells["date"].Value = tmpprescription.prescriptionDay;
                        animal_prescription.Rows[i].Cells["amount"].Value = tmpprescription.amount;
                    }
                }
                catch (Exception exception)
                {

                    string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                    MessageBox.Show(errorMessage);
                    return;
                }



                try
                {

                medicalRecords = BossController.Instance().animalController.GetAllMedicalRecordByAnimal(animal);
                //List<MedicalRecord> medicalRecords = BossController.Instance().animalController.GetAllMedicalRecordByAnimal(animal);

                animal.AddMedicalRecordEntryList(medicalRecords);

                animal_medicalRecords.DataSource = medicalRecords;

              

                    for (int i = 0; i < medicalRecords.Count; i++)
                    {
                        MedicalRecord tmpMedicalRecord = medicalRecords[i];

                        animal_medicalRecords.Rows[i].Cells["title"].Value = tmpMedicalRecord.treatment.headline;
                        animal_medicalRecords.Rows[i].Cells["MR_date"].Value = tmpMedicalRecord.treatment.startTime;

                    }
                }
                catch (Exception exception)
                {

                    string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                    MessageBox.Show(errorMessage);
                    return;
                }




            }












        }
        private void animal_medicalRecords_DoubleClick(object sender, EventArgs e)
        {

            DataGridViewRow row = animal_medicalRecords.SelectedRows[0];

            MedicalRecord medicalRecord = row.DataBoundItem as MedicalRecord;
            
            if (this.Modal == true)
            {
                this.DialogResult = DialogResult.OK;
                selectedMedicalRecord = medicalRecord;
                this.Close();
            }
            else
            {
                AnimalMREform animalMREform = new AnimalMREform(medicalRecord, animal);
                animalMREform.Show();

            }
        }
        private void button_opret_Click(object sender, EventArgs e)
        {


            



        }

        private void Button_opret_Click_1(object sender, EventArgs e)
        {


            string AnimalWeight = animal_weight.Text;

            int animalWeight = 0;

            if(CheckEmtyTextBoxes() == false)
            {
                MessageBox.Show("Alle felter skal udfyldes");
                return;
            }

            if (CheckWeightDigit(AnimalWeight) == false)
            {

                

                if (AnimalWeight.ToString().Length == 8)
                {
                    
                    animalWeight = Convert.ToInt32(animal_weight.Text);

                }

                MessageBox.Show("Vægten må kun bestå af tal");
                return;
            }

            try
            {
                Species species = (Species)animal_species.SelectedItem;
                bool gender = Convert.ToBoolean(animal_gender.SelectedIndex);
                Employee employee = null;
                if (animal_employee.SelectedIndex != 0)
                {
                    employee = (Employee)animal_employee.SelectedItem;
                }


                animal = AnimalFactory.Instance().CreateAnimal(customer, animal_name.Text.ToString(), (animal_bdate.Value), species, Convert.ToDouble(animal_weight.Text),gender, employee, true);

                animal = BossController.Instance().animalController.CreateAnimal(animal);

                MessageBox.Show("Dyret er oprettet");
                customerForm.UpdateDataGridView();

                AnimalName_Label.Text = animal.name;
                animalSpecies_label.Text = animal.Species.speciesType.ToString();
                animal_owner.Text = "Ejer: " + customer.name;
                button_edit.Enabled = true;
                button_create.Enabled = false;
                button_delete.Enabled = true;

               

                


            }
            catch (Exception exception)
            {

                string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                MessageBox.Show(errorMessage);
                return;
            }
        }

        private void Animal_species_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void Button_rediger_Click(object sender, EventArgs e)
        {

            string AnimalWeight = animal_weight.Text;

            int animalWeight = 0;

            if (CheckWeightDigit(AnimalWeight) == false)
            {

                if (AnimalWeight.ToString().Length == 8)
                {
                    
                    animalWeight = Convert.ToInt32(animal_weight.Text);

                }

                MessageBox.Show("Vægten må kun bestå af tal");
                return;
            }

            try
            {
                string name = animal_name.Text.ToString();
                DateTime birthday = animal_bdate.Value;
                Species species = animal.Species;
                double weight = Convert.ToDouble(animal_weight.Text);
                bool gender = Convert.ToBoolean(animal_gender.SelectedIndex);

                Employee employee = null;
                if (animal_employee.SelectedIndex != 0)
                {
                    employee = (Employee)animal_employee.SelectedItem;
                }

                Animal tmpanimal = new Animal(customer, animal.animalID, name, birthday, species, weight, true, employee, true);

                string message = BossController.Instance().animalController.UpdateAnimal(tmpanimal);
                if (message == "ok")
                {
                    MessageBox.Show("Dyret rettet");
                    customerForm.UpdateDataGridView();
                }
            }
            //MessageBox.Show(message);
            catch (Exception exception)
            {

                string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                MessageBox.Show(errorMessage);
                return;
            }





        }

        private void Button_slet_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Fjern dette dyr?", "Bekræft sletning", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                //animal = BossController.instance().animalController.GetAnimal();

                try
                {
                    string message = BossController.Instance().animalController.DeleteAnimal(animal);
                    this.Close();
                    if (message == "ok")
                    {
                        MessageBox.Show("Dyret Slettet");
                        this.Close();
                        customerForm.UpdateDataGridView();
                    }
                }
                catch (Exception exception)
                {
                    string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                    MessageBox.Show(errorMessage);
                    return;
                }

            }
            
            

        }
        private void LoadeAllItemsInComboBox()
        {

         
            List<Species> species = BossController.Instance().animalController.GetSpecies();

            //List<Species> SpeciesType = species.Where(x => x.speciesid.speciesType == 1).ToList<Employee>();

            //SpeciesType.Insert(0, new Species(-1,new SpecieTitle"Dyrlæge"));

            animal_species.DataSource = species;
            animal_species.DisplayMember = "speciesType";




            List<Employee> employees = BossController.Instance().employeeController.GetAllEmployees();


            List<Employee> vets = employees.Where(x => x.title.titleID == 1).ToList<Employee>();
            vets.Insert(0, new Employee(-1, "ingen", true, -1, new Title("Dyrlæge", -1)));

            animal_employee.DataSource = vets;
            animal_employee.DisplayMember = "name";

            LoadPrescription();
            

           


        }

        private void LoadPrescription()

        {
            if(animal == null)
            {
                return;
            }
            List<Prescription> prescription = BossController.Instance().animalController.GetAllPrescriptionByAnimal(animal.animalID);

            animal.AddPrescriptionList(prescription);

            

        }
        //private void LoadMedicalRecord()

        //{
        //    if (animal == null)
        //    {
        //        return;
        //    }
        //    List<MedicalRecord> medicalRecord = BossController.Instance().animalController.GetAllMedicalRecordByAnimal(animal.animalID);

        //    animal.AddMedicalRecordEntryList(medicalRecord);



        //}
        public bool selectGender
        {
            get
            {
                return animal_gender.SelectedIndex == 0;
            }
            set
            {
                animal_gender.SelectedIndex = value ? 0 : 1;
            }
        }
        public bool CheckWeightDigit(string weight)
        {
            double checkWeight =0;
           
            //return weight.All(char.IsDigit);
            if(Double.TryParse(weight, out checkWeight))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
      


        private void Animal_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Animal_employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_help_Click(object sender, EventArgs e)
        {
            try
            {

                string file = Path.GetDirectoryName(Application.ExecutablePath) + "/helpfiles/AnimalForm Instructions.pdf";
                Process.Start(file);
            }
            catch
            {
                MessageBox.Show("Filen kunne ikke findes");
            }
        }
        public bool CheckEmtyTextBoxes()
        {

            if (string.IsNullOrEmpty(animal_name.Text.ToString())||animal_gender.SelectedIndex<0)
            {

                return false;
            }
            return true;
        }

        //private void Animal_medicalRecords_DoubleClick(object sender, EventArgs e)
        //{

        //}
    }
}

