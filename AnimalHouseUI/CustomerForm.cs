﻿using System;
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
            button_opret.Enabled = false;
            Customer customer = BossController.instance().customerController.GetCustomer(textBox_phonenumber.Text);
            
            textBox_navn.Text = customer.name.ToString();
            textBox_adresse.Text = customer.address.ToString();
            textBox_email.Text = customer.email.ToString();

            button_rediger.Enabled = true;

            button_slet.Enabled = true;

           button_dyr.Enabled = true;
            label_headline.Text = customer.name.ToString();

            CheckCustomerDeletion();
        }

        private void button_opret_Click(object sender, EventArgs e)
        {
            string cvr = textBox_cvr.Text;
            int cvrint = 0;

            if (cvr != "")
            {
                cvrint = Convert.ToInt32(cvr);
                if (cvrint.ToString().Length==8)
                {
                    customer = CustomerFactory.Instance().CreateCustomer(textBox_navn.Text.ToString(), textBox_adresse.Text.ToString(), textBox_phonenumber.Text.ToString(), textBox_email.Text.ToString(), true, cvrint);

                    //stringen oprettes gennem bosscontrolleren og videre igennem customercontroleren
                    customer = BossController.instance().customerController.CreateCustomer(customer);

                    MessageBox.Show("Kunde oprettet");

                }
                else
                {
                    MessageBox.Show("Ugyldigt CVR-nummer.");
                }
                
            }
            

        }

        private void button_rediger_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Er du sikker på du vil rette denne kunde?", "Bekræft redigering", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                //skaf en kunde fra databasen så du kan finde hans customerID
                customer = BossController.instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());

                string name = textBox_navn.Text.ToString();
                string phone = textBox_phonenumber.Text.ToString();
                string address = textBox_adresse.Text.ToString();
                string email = textBox_email.Text.ToString();
                int customerID = customer.customerID;
                

                Customer tmpcustomer = new Customer(customerID, name, address, phone, email, true);

                string message = BossController.instance().customerController.UpdateCustomer(tmpcustomer);
                MessageBox.Show(message);

            }

            textBox_phonenumber.Clear();
            textBox_navn.Clear();
            textBox_adresse.Clear();
            textBox_email.Clear();
            textBox_cvr.Clear();
            LabelTitle.Text = "Administrer kunde";

            button_opret.Enabled = true;
            button_rediger.Enabled = false;
            button_dyr.Enabled = false;
            button_slet.Enabled = false;


        }

        private void button_slet_Click(object sender, EventArgs e)
            //lav en "er du sikker" popup
        {
            var confirm=MessageBox.Show("Er du sikker på du vil slette denne kunde?", "Bekræft sletning", MessageBoxButtons.YesNo);

            if (confirm==DialogResult.Yes)
            {
                customer = BossController.instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());

                string message = BossController.instance().customerController.DeleteCustomer(customer);
                MessageBox.Show(message);

            }

            textBox_phonenumber.Clear();
            textBox_navn.Clear();
            textBox_adresse.Clear();
            textBox_email.Clear();
            textBox_cvr.Clear();
            LabelTitle.Text = "Administrer kunde";

            button_opret.Enabled = true;
            button_rediger.Enabled = false;
            button_dyr.Enabled = false;
            button_slet.Enabled = false;


        }

        private void button_dyr_Click(object sender, EventArgs e)
        {
            AnimalForm animalForm = new AnimalForm(customer);
            animalForm.Show();
        }

        private void checkBox_erhverskunde_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_erhverskunde.Checked==true)
                {
                textBox_cvr.Enabled = true;
            }
            else
            {
                textBox_cvr.Enabled = false;
            }
        }

        private void CheckCustomerDeletion()
        {
            customer = BossController.instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());
            if (customer.active == false)
            {
                var confirm = MessageBox.Show("Denne kunde er slettet, vil du reaktivere?", "Kunde slettet",MessageBoxButtons.YesNoCancel);

                if (confirm == DialogResult.Yes)
                {
                    customer = BossController.instance().customerController.GetCustomer(textBox_phonenumber.Text.ToString());

                    string message = BossController.instance().customerController.UndeleteCustomer(customer);
                    MessageBox.Show(message);

                }
            }

        }


        
    }
}
