using BTL.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Form_Customer : Form
    {
        public Form_Customer()
        {
            InitializeComponent();
        }

        CustomerAction customerAction;
        Customer.Customer customer;

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            customerAction = new CustomerAction();
            try
            {
                dataGridView_Customer.DataSource = customerAction.getAllCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //execute code to add
            string _sFullName = textBox_FullName.Text;
            string _sAddress = textBox_Address.Text;
            DateTime _dDateOfBirth = DateOfBirth.Value;
            string _sGender = textBox_Gender.Text;
            string _sPhoneNumber = textBox_PhoneNumber.Text;

            try
            {
                customer = new Customer.Customer(0, _sFullName, _sAddress, _dDateOfBirth, _sGender, _sPhoneNumber);
                if (customerAction.insert(customer))
                {
                    dataGridView_Customer.DataSource = customerAction.getAllCustomer();
                }
                else
                {
                    MessageBox.Show("Add a new customer have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataToTextView(object sender, DataGridViewCellEventArgs e)
        {
            //This function use to get data follow each row and fill to TextBox
            //If you want click full row you click in DataGridView and find 'SelectionMode' property switch to 'FullRowSelect'
            try
            {
                textBox_CustomerID.Text = dataGridView_Customer.CurrentRow.Cells["Mã Khách Hàng"].Value.ToString();
                textBox_FullName.Text = dataGridView_Customer.CurrentRow.Cells["Tên Khách Hàng"].Value.ToString();
                textBox_Address.Text = dataGridView_Customer.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
                DateOfBirth.Text = dataGridView_Customer.CurrentRow.Cells["Ngày Sinh"].Value.ToString();
                textBox_Gender.Text = dataGridView_Customer.CurrentRow.Cells["Giới Tính"].Value.ToString();
                textBox_PhoneNumber.Text = dataGridView_Customer.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
            }
            catch
            {
                dataGridView_Customer.DataSource = customerAction.getAllCustomer();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string _iCustomerID = textBox_CustomerID.Text;

            // MessageBox confirm if you want to delete the phone
            if (MessageBox.Show("Do you want delete a customer?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if (customerAction.delete(_iCustomerID))
            {
                dataGridView_Customer.DataSource = customerAction.getAllCustomer();
            }
            else
            {
                MessageBox.Show("Delete the customer have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // MessageBox confirm if you want to update the phone
                if (MessageBox.Show("Do you want update the customer?", "Notification",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                //execute code to add
                int _iCustomerID = int.Parse(textBox_CustomerID.Text);

                string _sFullName = textBox_FullName.Text;
                string _sAddress = textBox_Address.Text;
                DateTime _dDateOfBirth = DateOfBirth.Value;
                string _sGender = textBox_Gender.Text;
                string _sPhoneNumber = textBox_PhoneNumber.Text;

                customer = new Customer.Customer(_iCustomerID, _sFullName, _sAddress, _dDateOfBirth, _sGender, _sPhoneNumber);

                if (customerAction.update(customer))
                {
                    dataGridView_Customer.DataSource = customerAction.getAllCustomer();
                }
                else
                {
                    MessageBox.Show("Update the staff have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
