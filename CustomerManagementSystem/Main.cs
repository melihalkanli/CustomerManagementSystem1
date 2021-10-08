using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = false;
            
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = true;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm; childForm.TopLevel = false; childForm.FormBorderStyle = FormBorderStyle.None; childForm.Dock = DockStyle.Fill; panelForm.Controls.Add(childForm); panelForm.Tag = childForm; childForm.BringToFront(); childForm.Show();

        }

        private void buttonCustomersAddForm_Click(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = false;
            openChildForm(new AddCustomerForm());
        }

        private void ButtonCustomersGetAllForm_Click(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = false;
            openChildForm(new mevcurmusteriler());
        }
        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCustomersSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCustomersÜlkeEkleForm_Click(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = false;
            openChildForm(new Ülkeekle());
        }

        private void buttonCustomersÜlkelerForm_Click(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = false;
            openChildForm(new Ülkeler());
        }
    }
}
