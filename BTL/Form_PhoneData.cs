using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL
{
    public partial class Form_PhoneData : Form
    {
        public Form_PhoneData()
        {
            InitializeComponent();
        }

        private void Form_PhoneData_FormClosing(object sender, FormClosingEventArgs e)
        {
            //show noti when you click close this form - default event of form at Events
            if (MessageBox.Show("Do you want close this form?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        PhoneAction phoneAction;
        BrandAction brandAction;
        Phone phone;
        private void Form_PhoneData_Load(object sender, EventArgs e)
        {
            phoneAction = new PhoneAction();
            brandAction = new BrandAction();
            try
            {
                dataGridView_Phone.DataSource = phoneAction.getAllPhone();
                comboBox_BrandID.DataSource = brandAction.getAllBrand();
                comboBox_BrandID.DisplayMember = "sBrandName";
                comboBox_BrandID.ValueMember = "sBrandID";
            }
            catch(Exception ex)
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
                textBox_PhoneID.Text = dataGridView_Phone.CurrentRow.Cells["Mã Điện Thoại"].Value.ToString();
                textBox_BrandID.Text = dataGridView_Phone.CurrentRow.Cells["Mã Hãng Điện Thoại"].Value.ToString();
                textBox_PhoneModel.Text = dataGridView_Phone.CurrentRow.Cells["Tên Điện Thoại"].Value.ToString();
                textBox_Quantity.Text = dataGridView_Phone.CurrentRow.Cells["Số Lượng"].Value.ToString();
                textBox_Price.Text = dataGridView_Phone.CurrentRow.Cells["Giá Bán"].Value.ToString();
            }
            catch
            {
                dataGridView_Phone.DataSource = phoneAction.getAllPhone();
            }
        }

        private void btn_AddPhone_Click(object sender, EventArgs e)
        {

            //execute code to add
            string _sPhoneID = textBox_PhoneID.Text;
            string _sBrandID = textBox_BrandID.Text;
            string _sPhoneModel = textBox_PhoneModel.Text;
            string _iQuantity = textBox_Quantity.Text;
            string _iPrice = textBox_Price.Text;

            try
            {
                phone = new Phone(_sPhoneID, _sBrandID, _sPhoneModel, int.Parse(_iQuantity), int.Parse(_iPrice));
                if (phoneAction.insert(phone))
                {
                    textBox_BrandID.Text = comboBox_BrandID.SelectedValue.ToString();
                    textBox_PhoneID.Text = "";
                    textBox_PhoneModel.Text = "";
                    textBox_Quantity.Text = "";
                    textBox_Price.Text = "";
                    dataGridView_Phone.DataSource = phoneAction.getAllPhone();
                }
                else
                {
                    MessageBox.Show("Add a new phone have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_DeletePhone_Click(object sender, EventArgs e)
        {
            string _sPhoneID = textBox_PhoneID.Text;

            // MessageBox confirm if you want to delete the phone
            if (MessageBox.Show("Do you want delete a phone?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if (phoneAction.delete(_sPhoneID))
            {
                dataGridView_Phone.DataSource = phoneAction.getAllPhone();
            }
            else
            {
                MessageBox.Show("Delete the phone have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_UpdatePhone_Click(object sender, EventArgs e)
        {

            try
            {
                // MessageBox confirm if you want to update the phone
                if (MessageBox.Show("Do you want update the phone?", "Notification",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                //execute code to add
                string _sPhoneID = textBox_PhoneID.Text;
                string _sBrandID = textBox_BrandID.Text;
                string _sPhoneModel = textBox_PhoneModel.Text;
                string _iQuantity = textBox_Quantity.Text;
                string _iPrice = textBox_Price.Text;

                phone = new Phone(_sPhoneID, _sBrandID, _sPhoneModel, int.Parse(_iQuantity), int.Parse(_iPrice));

                if (phoneAction.update(phone))
                {
                    dataGridView_Phone.DataSource = phoneAction.getAllPhone();
                }
                else
                {
                    MessageBox.Show("Update the phone have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string _sPhoneModel = textBox_PhoneModel.Text;

                var dataTable = phoneAction.search(_sPhoneModel);
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView_Phone.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Nothing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_BrandID_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_BrandID.Text = comboBox_BrandID.SelectedValue.ToString();
            textBox_PhoneID.Text = "";
            textBox_PhoneModel.Text = "";
            textBox_Quantity.Text = "";
            textBox_Price.Text = "";
        }

        private void btn_Brand_Click(object sender, EventArgs e)
        {
            Form_Brand form_Brand = new Form_Brand();
            form_Brand.Show();
        }

        private void label_BrandID_Click(object sender, EventArgs e)
        {
            comboBox_BrandID.DataSource = brandAction.getAllBrand();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            Form_Staff form_Staff = new Form_Staff();
            form_Staff.Show();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Form_Customer form_Customer = new Form_Customer();
            form_Customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Orders form_Sell = new Form_Orders();
            form_Sell.Show();
        }

        private void btn_ReportPhone_Click(object sender, EventArgs e)
        {
            Report.Phone_Report phone_Report = new Report.Phone_Report();
            phone_Report.Show();
        }
    }
}
