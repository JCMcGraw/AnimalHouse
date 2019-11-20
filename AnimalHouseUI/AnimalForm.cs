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
        Customer customer;
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
            
            
        }
        private void button_opret_Click(object sender, EventArgs e)
        {


            



        }

        private void Button_opret_Click_1(object sender, EventArgs e)
        {
            //Animal animal = new Animal(Animal_name.Text.ToString(), Animal_weight.Text.ToString(), Animal_bday.Text.ToString(),
            //    true);

            //string message = BossController.instance().animalController.CreateAnimal(animal);
            //MessageBox.Show(message);
            //fejl
            Animal animal = AnimalFactory.Instance().CreateAnimal(customer.customerID,animal_name.Text.ToString(), (animal_bdate.Value), 1, Convert.ToDouble(animal_weight.Text), 1, true);

            Animal message = BossController.instance().animalController.CreateAnimal(animal);
            MessageBox.Show("dyr oprettet");
        }

        private void Animal_species_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataView dv = new DataView(dataTableSubGroup);
            //    dv.RowFilter = $"MainGroup = {ComboModelMain.SelectedValue}";

            //    ComboModelSub.DataSource = dv.ToTable();
            //    ComboModelSub.DisplayMember = "Category";
            //    ComboModelSub.ValueMember = "SubGroupID";
            //}
            //catch
            //{

            //}
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
