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


namespace AnimalHouseUI
{
    public partial class CustomerForm : Form
    {

        Customer customer;

        public Animal selectedAnimal;
        public CustomerForm()
        {
           
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


        //private void SampleForm_Load(object sender, EventArgs e)
        //{

        //}

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView_dyr.AutoGenerateColumns = false;
            dataGridView_dyr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_soeg_Click(object sender, EventArgs e)
        {
            button_opret.Enabled = false;

            try
            {
                 customer = BossController.Instance().customerController.GetCustomer(textBox_phonenumber.Text);
            }
            catch (Exception exception)
            {
                string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                MessageBox.Show(errorMessage);
                return;
            }

            textBox_navn.Text = customer.name.ToString();
            textBox_adresse.Text = customer.address.ToString();
            textBox_email.Text = customer.email.ToString();
            label_headline.Text = customer.name.ToString();

            CheckForBusinesscustomer(customer);
            this.Refresh();

            //danner en liste af dyr der hedder animals. Denne liste bliver dannet et sted på animalmanager og der bruges en customer
            List<Animal> animals= BossController.Instance().animalController.GetManyAnimalByCustomerID(customer);
            
            //tilknytter listen af dyr til kunden
            customer.AddAnimalList(animals);
            
            dataGridView_dyr.DataSource = customer.animals;

            dataGridView_dyr.Columns["name"].DataPropertyName = "Name";

            for (int i = 0; i < dataGridView_dyr.RowCount; i++)
            {
                Species tmpspecies = animals[i].Species;

                dataGridView_dyr.Rows[i].Cells["speciestype"].Value = tmpspecies.speciesType;
            }
            
            button_rediger.Enabled = true;
            button_slet.Enabled = true;
            button_dyr.Enabled = true;
            
            CheckCustomerDeletion();
        }

        private void button_rediger_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Er du sikker på du vil redigere denne kunde?", "Bekræft redigering", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                //Tjekker for at se om emailen er gyldig.

                if (CheckForValidEmail(textBox_email.Text.ToString()) == false)
                {
                    MessageBox.Show("Ugyldig E-mailadresse");
                    return;
                }


                if (CheckUniquePhone(textBox_phonenumber.Text.ToString()) == false)
                {
                    MessageBox.Show("Telefonnummeret er allerede i brug");
                    return;

                }

                string phone = textBox_phonenumber.Text.ToString();
                
                try
                {
                    customer = BossController.Instance().customerController.GetCustomer(phone);
                }
                catch (Exception exception)
                {
                    string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                    MessageBox.Show(errorMessage);
                    return;
                }
                string name = textBox_navn.Text.ToString();
                
                string address = textBox_adresse.Text.ToString();
                string email = textBox_email.Text.ToString();
                int customerID = customer.customerID;
                int cvr = 0;

                Customer tmpcustomer = CustomerFactory.Instance().CreateCustomer(customerID, name, address, phone, email, true, cvr);

                try
                {
                    string message = BossController.Instance().customerController.UpdateCustomer(tmpcustomer);
                    MessageBox.Show(message);
                    ResetForm();

                }
                catch(Exception exception)
                {
                    string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                    MessageBox.Show(errorMessage);
                    return;
                }

            }
            label_headline.Text = name.ToString();

        }

        private void button_slet_Click(object sender, EventArgs e)
       
        {
            var confirm = MessageBox.Show("Er du sikker på du vil slette denne kunde?", "Bekræft sletning", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                customer = BossController.Instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());

                try
                {
                    

                    string message = BossController.Instance().customerController.DeleteCustomer(customer);
                    MessageBox.Show(message);

                }
                 catch (Exception exception)
                {
                    string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                    MessageBox.Show(errorMessage);
                    return;
                }

            }

            ResetForm();

        }

        private void button_opret_Click(object sender, EventArgs e)
        {

          //  Tjekker for at se om emailen er gyldig.

            if (CheckForValidEmail(textBox_email.Text.ToString()) == false)
                {
                    MessageBox.Show("Ugyldig E-mailadresse");
                    return;
                }

            // tjekker om cvrnummeret består af tal
            string cvr = textBox_cvr.Text;
            
            //opretter en ny int og sætter den til 0
            int cvrint = 0;

            if (checkBox_erhverskunde.Checked == true && CheckForCVRdegit(cvr) == false)
            {

                //Hvis ikke cvr-nummeret består af noget bliver det lavet om til inten cvrint som er 0.

                if (cvr.ToString().Length == 8)
                {
                    //hvis cvrboxen er chacket af og tallet er i orden erstattes nullet med det nye cvr-nummer
                    cvrint =Convert.ToInt32(textBox_cvr.Text);

                }
                else
                {
                    MessageBox.Show("CVR-nummeret skal bestå af 8 tal.");
                    return;
                }

                MessageBox.Show("CVR-nummer må kun bestå af tal");
                return;
            }

            if (checkBox_erhverskunde.Checked == true && CheckForCVRdegit(cvr) == true)
            {
                cvrint =Convert.ToInt32( textBox_cvr.Text);
            }
            customer = CustomerFactory.Instance().CreateCustomer(textBox_navn.Text.ToString(), textBox_adresse.Text.ToString(), textBox_phonenumber.Text.ToString(), textBox_email.Text.ToString(), true, cvrint);


            try
            {
                
                //her skriver vi den oprettede kunde ind i databasen
                customer = BossController.Instance().customerController.CreateCustomer(customer);

                MessageBox.Show("Kunde oprettet");

                button_dyr.Enabled = true;
                button_rediger.Enabled = true;
                button_slet.Enabled = true;
                label_headline.Text = textBox_navn.Text.ToString().ToString();

            }
                catch (Exception exception)
            {

                string errorMessage = ErrorManager.Instance().GetErrorMessage(exception);
                MessageBox.Show(errorMessage);
                return;
            }
        }

        private void button_dyr_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm(customer);
            animalForm.Show();
        }

        private void checkBox_erhverskunde_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_erhverskunde.Checked == true)
            {
                textBox_cvr.Enabled = true;
            }
            else
            {
                textBox_cvr.Enabled = false;
            }
        }

        private void dataGridView_dyr_DoubleClick(object sender, EventArgs e)
        { 
            DataGridViewRow row = dataGridView_dyr.SelectedRows[0];

            Animal animal = row.DataBoundItem as Animal;

            if(this.Modal == true)
            {
                this.DialogResult = DialogResult.OK;
                selectedAnimal = animal;
                this.Close();
            }
            else
            {
                AnimalForm animalForm = new AnimalForm(customer, animal);
                animalForm.Show();
            }
        }

        private void CheckCustomerDeletion()
        {
            customer = BossController.Instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());
            if (customer.active == false)
            {
                var confirm = MessageBox.Show("Denne kunde er slettet, vil du reaktivere?", "Kunde slettet", MessageBoxButtons.YesNoCancel);

                if (confirm == DialogResult.Yes)
                {
                    customer = BossController.Instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());

                    string message = BossController.Instance().customerController.UndeleteCustomer(customer);
                    MessageBox.Show(message);

                }
            }

        }

        private void ResetForm()
        {
            textBox_phonenumber.Clear();
            textBox_navn.Clear();
            textBox_adresse.Clear();
            textBox_email.Clear();
            textBox_cvr.Clear();

            //Denne label gider ikke opdatere, for some reason
            LabelTitle.Text = "Administrer kunde";

            button_opret.Enabled = true;
            button_rediger.Enabled = false;
            button_dyr.Enabled = false;
            button_slet.Enabled = false;
        }

        public bool CheckForCVRdegit(string cvr)
        {
            return cvr.All(char.IsDigit);
        }

        private void LoadeAllItemsInListBox()
        {
            List<Animal> animals = BossController.Instance().animalController.GetManyAnimalByCustomerID(customer);

            customer.AddAnimalList(animals);

            dataGridView_dyr.DataSource = animals;
            dataGridView_dyr.Columns["animalID"].Visible = false;
          
        }

        public void CheckForBusinesscustomer(Customer customer)
        {
           
            if(customer.GetType()==typeof(BusinessCustomer))
            {
                
                textBox_cvr.Text = ((BusinessCustomer)customer).cvr.ToString();
            }
        }

        public bool CheckForValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckUniquePhone(string phone)
        {
            return BossController.Instance().customerController.CheckUniquePhone(phone);
                     }
        
    }
}
