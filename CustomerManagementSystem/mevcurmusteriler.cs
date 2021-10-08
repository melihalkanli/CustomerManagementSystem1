using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class mevcurmusteriler : Form
    {

        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal());
        public mevcurmusteriler()
        {
            InitializeComponent();
            StyleDatagridView();
        }
        void StyleDatagridView()
        {
            dataGridViewCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 24);
            dataGridViewCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCustomers.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridViewCustomers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCustomers.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCustomers.EnableHeadersVisualStyles = false;
            dataGridViewCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void mevcurmusteriler_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoadCustomers_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = _customerManager.GetCustomersDetails();
            SetDataGridVievColumnNames();

        }

        private void SetDataGridVievColumnNames()
        {
            dataGridViewCustomers.Columns[0].HeaderText = "Id";
            dataGridViewCustomers.Columns[1].HeaderText = "Ülkesi";
            dataGridViewCustomers.Columns[2].HeaderText = "Müşteri Adı";
            dataGridViewCustomers.Columns[3].HeaderText = "Müşteri Soyadı";
            dataGridViewCustomers.Columns[4].HeaderText = "Anne Adı";
            dataGridViewCustomers.Columns[5].HeaderText = "Baba Adı";
            dataGridViewCustomers.Columns[6].HeaderText = "Müşteri Emaili";
            dataGridViewCustomers.Columns[7].HeaderText = "Müşteri Numarası";
            dataGridViewCustomers.Columns[8].HeaderText = "Müşteri Resmi";
        }

        List<CustomerDetailDto> searchedList = new List<CustomerDetailDto>();

       

        private void textBoxSearchText_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = null;
            dataGridViewCustomers.Rows.Clear();
            searchedList.Clear();
            foreach (var item in _customerManager.GetCustomersDetails())
            {
                string fullName = item.Name.ToUpper() + " " + item.Surname.ToUpper();
                if (fullName.Contains(textBoxSearchText.Text.ToString().ToUpper()))
                {
                    searchedList.Add(item);
                }

            }
            dataGridViewCustomers.DataSource = searchedList;
            SetDataGridVievColumnNames();
        }
    }
}
