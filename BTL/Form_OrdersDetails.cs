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
    public partial class Form_OrdersDetails : Form
    {
        public Form_OrdersDetails()
        {
            InitializeComponent();
        }
        Orders.OrdersAction ordersAction;
        PhoneAction phoneAction;
        OrdersDetails.OrdersDetailsAction ordersDetailsAction;
        OrdersDetails.OrdersDetails ordersDetails;
        private void Form_OrdersDetails_Load(object sender, EventArgs e)
        {
            ordersAction = new Orders.OrdersAction();
            phoneAction = new PhoneAction();
            ordersDetailsAction = new OrdersDetails.OrdersDetailsAction();
            try
            {
                comboBox_OrdersID.DataSource = ordersAction.getAllOrders();
                comboBox_OrdersID.ValueMember = "Mã Orders";
                comboBox_OrdersID.DisplayMember = "Mã Orders";

                comboBox_PhoneID.DataSource = phoneAction.getAllPhone();
                comboBox_PhoneID.ValueMember = "Mã Điện Thoại";
                comboBox_PhoneID.DisplayMember = "Tên Điện Thoại";

                dataGridView_OrdersDetails.DataSource = ordersDetailsAction.getAllOrdersDetails();
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
                textBox_OrdersDetailsID.Text = dataGridView_OrdersDetails.CurrentRow.Cells["Mã OrdersDetails"].Value.ToString();
                comboBox_OrdersID.Text = dataGridView_OrdersDetails.CurrentRow.Cells["Mã Orders"].Value.ToString();
                comboBox_PhoneID.Text = dataGridView_OrdersDetails.CurrentRow.Cells["Mã Điện Thoại"].Value.ToString();
                textBox_Quantity.Text = dataGridView_OrdersDetails.CurrentRow.Cells["Số Lượng"].Value.ToString();
                textBox_Price.Text = dataGridView_OrdersDetails.CurrentRow.Cells["Giá Bán"].Value.ToString();
            }
            catch
            {
                dataGridView_OrdersDetails.DataSource = ordersDetailsAction.getAllOrdersDetails();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //execute code to add
            int _iOrdersID = int.Parse(comboBox_OrdersID.SelectedValue.ToString());
            string _iPhoneID = comboBox_PhoneID.SelectedValue.ToString();
            int _iQuantity = int.Parse(textBox_Quantity.Text);
            int _iPrice = int.Parse(textBox_Price.Text);

            try
            {
                ordersDetails = new OrdersDetails.OrdersDetails(0, _iOrdersID, _iPhoneID, _iQuantity, _iPrice);
                if (ordersDetailsAction.insert(ordersDetails))
                {
                    textBox_Quantity.Text = "";
                    textBox_Price.Text = "";
                    dataGridView_OrdersDetails.DataSource = ordersDetailsAction.getAllOrdersDetails();
                }
                else
                {
                    MessageBox.Show("Add a new orders details have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _iOrdersDetailsID = int.Parse(textBox_OrdersDetailsID.Text);

            // MessageBox confirm if you want to delete the phone
            if (MessageBox.Show("Do you want delete a orders details?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if (ordersDetailsAction.delete(_iOrdersDetailsID))
            {
                dataGridView_OrdersDetails.DataSource = ordersDetailsAction.getAllOrdersDetails();
            }
            else
            {
                MessageBox.Show("Delete the orders have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // MessageBox confirm if you want to update the phone
                if (MessageBox.Show("Do you want update the orders details?", "Notification",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                //execute code to add
                int _iOrdersDetailsID = int.Parse(textBox_OrdersDetailsID.Text);

                int _iOrdersID = int.Parse(comboBox_OrdersID.SelectedValue.ToString());
                string _iPhoneID = comboBox_PhoneID.SelectedValue.ToString();
                int _iQuantity = int.Parse(textBox_Quantity.Text);
                int _iPrice = int.Parse(textBox_Price.Text);

                ordersDetails = new OrdersDetails.OrdersDetails(_iOrdersDetailsID, _iOrdersID, _iPhoneID, _iQuantity, _iPrice);

                if (ordersDetailsAction.update(ordersDetails))
                {
                    dataGridView_OrdersDetails.DataSource = ordersDetailsAction.getAllOrdersDetails();
                }
                else
                {
                    MessageBox.Show("Update the orders details have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_PhoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Price.Text = phoneAction.getPriceOfPhone(comboBox_PhoneID.SelectedValue.ToString()).ToString();
        }
    }
}
