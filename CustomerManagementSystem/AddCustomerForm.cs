using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagementSystem
{
    public partial class AddCustomerForm : Form
    {
        CountryManager _countryManager = new CountryManager(new EfCountryDal());
        CustomerManager _customerManager = new CustomerManager(new EfCustomerDal());
        
        public AddCustomerForm()
        {
            InitializeComponent();
            
            foreach (var country in _countryManager.GetAll())
            {
                comboBoxCountries.Items.Add(country.Name);
                
            }

        }
        byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
           
          
                foreach (var country in _countryManager.GetAll())
                {
                    if (comboBoxCountries.SelectedItem.ToString()==country.Name)
                    {
                        customer.CountryId = country.Id;
                        break;
                    }
                }
           
                customer.Email = textBoxEmail.Text.ToString();
                customer.FatherName = textBoxFatherName.Text.ToString();
                customer.MotherName = textBoxMotherName.Text.ToString();
                customer.Name = textBoxName.Text.ToString();
                customer.Surname = textBoxSurname.Text.ToString();
            customer.Phone = textBoxPhone.Text.ToString();
            if (pictureBox1.Image!=null)
            {
                customer.Image = ConvertImageToBytes(pictureBox1.Image);
            }
            _customerManager.Add(customer);
            
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
           
            
            
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() {
                Filter = "Resim Dosyaları(*.jpg;*.jpeg;*.png)|*.jpg|*.jpeg|*.png",
                Multiselect = false

            })
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }

            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMotherName_MouseLeave(object sender, EventArgs e)
        {
            buttonAddCustomer.BackColor = Color.Green;
        }

    }
}

