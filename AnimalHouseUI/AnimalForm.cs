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
    public partial class AnimalForm : Form
    {
        Animal animal;
        Customer customer;
        //Employee employee;
        List<Employee> employee;
        List<Species> species;

        //private DataTable Animal_Gender = new DataTable();

        public AnimalForm(Customer customer,Animal animal)

        {
            this.customer = customer;
            this.animal = animal;
            InitializeComponent();

            //MessageBox.Show(animal.gender.ToString());
        }
        private void SetStatusComboBoxToDefault()
        {
            animal_gender.SelectedIndex=0;
            animal_species.SelectedIndex = 0;
            
        }
        public AnimalForm(Customer customer)

        {
            this.customer = customer;

            InitializeComponent();

            
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
            LoadeAllItemsInComboBox();
            BossController.instance().animalController.GetSpecies();
            if( animal != null)
            {
                animal_owner.Text = customer.name;
                AnimalName_Label.Text = animal.name;
                animalAge_label.Text = Convert.ToString(animal.birthday);
                animalSpecies_label.Text = animal.Species.speciesType.ToString();

                animal_name.Text = animal.name;
                animal_bdate.Text = Convert.ToString(animal.birthday);
                animal_species.Text = Convert.ToString(animal.Species.speciesType);
                animal_weight.Text = Convert.ToString(animal.weight);
                animal_gender.SelectedIndex = Convert.ToInt32(animal.gender);
                //animal_employee.SelectedIndex = Convert.ToInt32(animal.employeeid);
               
            }
           

            

       



        }
        private void button_opret_Click(object sender, EventArgs e)
        {


            



        }

        private void Button_opret_Click_1(object sender, EventArgs e)
        {

            //Species species = new Species(2, "Hund");

            //Animal animal = AnimalFactory.Instance().CreateAnimal(123, 10, animal_name.Text.ToString(), (animal_bdate.Value), species, Convert.ToDouble(animal_weight.Text), true, employee, true);

            //Animal animal = AnimalFactory.Instance().CreateAnimal(customer.customerID, 1, animal_name.Text.ToString(), (animal_bdate.Value), species, Convert.ToDouble(animal_weight.Text), true, 1, true); ; ;

            //Animal message = BossController.instance().animalController.CreateAnimal(animal);
            //MessageBox.Show("dyr oprettet");
            //int speciesID = Convert.ToInt32(animal_species.SelectedIndex);
            Species species = (Species)animal_species.SelectedItem;
            bool gender = Convert.ToBoolean(animal_gender.SelectedIndex);
            Employee employee = null;
            if (animal_employee.SelectedIndex != 0)
            {
                employee = (Employee)animal_employee.SelectedItem;
            }
                

            animal = AnimalFactory.Instance().CreateAnimal(customer, animal_name.Text.ToString(), (animal_bdate.Value), species, Convert.ToDouble(animal_weight.Text), true, employee, true);

            animal = BossController.instance().animalController.CreateAnimal(animal);
        }

        private void Animal_species_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }

        private void Button_rediger_Click(object sender, EventArgs e)
        {
            
            

            string name = animal_name.Text.ToString();
            DateTime birthday = animal_bdate.Value;
            int speciesID = Convert.ToInt32(animal_species.SelectedIndex);
            Species species = animal.Species;
            double weight = Convert.ToDouble(animal_weight.Text);
            bool gender = Convert.ToBoolean(animal_gender.SelectedIndex);
            int employeeID = Convert.ToInt32(animal_employee.SelectedIndex);
            Employee employee = animal.Employee;



            Animal tmpanimal = new Animal(customer, animal.animalID, name, birthday, species, weight, true, employee, true);

            string message = BossController.instance().animalController.UpdateAnimal(tmpanimal);
            MessageBox.Show(message);








        }

        private void Button_slet_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Fjern dette dyr?", "Bekræft sletning", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                //animal = BossController.instance().animalController.GetAnimal();

                string message = BossController.instance().animalController.DeleteAnimal(animal);
                MessageBox.Show(message);
                this.Close();
            }
            
            

        }
        private void LoadeAllItemsInComboBox()
        {

         
            List<Species> species = BossController.instance().animalController.GetSpecies();

            //List<Species> SpeciesType = species.Where(x => x.speciesid.speciesType == 1).ToList<Employee>();

            //SpeciesType.Insert(0, new Species(-1,new SpecieTitle"Dyrlæge"));

            animal_species.DataSource = species;
            animal_species.DisplayMember = "speciesType";




            List<Employee> employees = BossController.instance().employeeController.GetAllEmployees();


            List<Employee> vets = employees.Where(x => x.title.titleID == 1).ToList<Employee>();
            vets.Insert(0, new Employee(-1, "ingen", true, -1, new Title("Dyrlæge", -1)));

            animal_employee.DataSource = vets;
            animal_employee.DisplayMember = "name";

            LoadPrescription();

           


        }
        private void LoadPrescription()
        {
            //List<Prescription> prescription = BossController.instance().animalController.GetManyAnimalByCustomerID(customer);

            //customer.AddAnimalList(animals);

            //dataGridView_dyr.DataSource = animals;
            //dataGridView_dyr.Columns["animalID"].Visible = false;

        }
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
    }
}
