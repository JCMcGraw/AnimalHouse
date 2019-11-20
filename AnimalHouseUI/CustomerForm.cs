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
    public partial class CustomerForm : Form
    {
        Customer customer;
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
            
        }

        private void button_soeg_Click(object sender, EventArgs e)
        {
            
            Customer customer = BossController.instance().customerController.GetCustomer(textBox_phonenumber.Text);
            
            textBox_navn.Text = customer.name.ToString();
            textBox_adresse.Text = customer.address.ToString();
            textBox_email.Text = customer.email.ToString();

            button_rediger.Enabled = true;

            button_slet.Enabled = true;

           button_dyr.Enabled = true;
            label_headline.Text = customer.name.ToString();
        }

        private void button_opret_Click(object sender, EventArgs e)
        {
            //Kunden skabes direkte fra entity-laget, men igennem factoryen
             customer =CustomerFactory.Instance().CreateCustomer(textBox_navn.Text.ToString(), textBox_adresse.Text.ToString(), textBox_phonenumber.Text.ToString(), textBox_email.Text.ToString(), true, textBox_cvr.Text.ToString());

            //stringen oprettes gennem bosscontrolleren og videre igennem customercontroleren
            string message= BossController.instance().customerController.CreateCustomer(customer);
            MessageBox.Show(message);


        }

        private void button_rediger_Click(object sender, EventArgs e)
        {
            //Lav en "er du sikker"-popup

            //skaf en kunde fra databasen så du kan finde hans customerID
             customer = new Customer(textBox_navn.Text.ToString(), textBox_adresse.Text.ToString(), textBox_phonenumber.ToString(), textBox_email.ToString(),true);

            //string message=customer.name.ToString();
            string message = BossController.instance().customerController.UpdateCustomer(customer);
            MessageBox.Show(message);

           
        }

        private void button_slet_Click(object sender, EventArgs e)
            //lav en "er du sikker" popup
        {
             customer = new Customer(textBox_navn.Text.ToString(), textBox_adresse.Text.ToString(), textBox_phonenumber.ToString(), textBox_email.ToString(), true);

            string message = BossController.instance().customerController.DeleteCustomer(customer);
            MessageBox.Show(message);

           

        }

        private void button_dyr_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm(customer);
            animalForm.Show();
        }
    }
}
