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
    public partial class Form_Orders : Form
    {
        public Form_Orders()
        {
            InitializeComponent();
        }
        Customer.CustomerAction  customerAction;
        Staff.StaffAction staffAction;
        Orders.OrdersAction ordersAction;
        Orders.Orders orders;
        private void Form_Sell_Load(object sender, EventArgs e)
        {
            customerAction = new Customer.CustomerAction();
            staffAction = new Staff.StaffAction();
            ordersAction = new Orders.OrdersAction();
            try
            {
                comboBox_CustomerID.DataSource = customerAction.getAllCustomer();
                comboBox_CustomerID.ValueMember = "Mã Khách Hàng";
                comboBox_CustomerID.DisplayMember = "Tên Khách Hàng";

                comboBox_StaffID.DataSource = staffAction.getAllStaff();
                comboBox_StaffID.ValueMember = "Mã Nhân Viên";
                comboBox_StaffID.DisplayMember = "Tên Nhân Viên";

                dataGridView_Orders.DataSource = ordersAction.getAllOrders();
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
                textBox__OrdersID.Text = dataGridView_Orders.CurrentRow.Cells["Mã Orders"].Value.ToString();
                OrdersDate.Text = dataGridView_Orders.CurrentRow.Cells["Ngày Orders"].Value.ToString();
            }
            catch
            {
                dataGridView_Orders.DataSource = ordersAction.getAllOrders();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //execute code to add
            string _iCustomerID = comboBox_CustomerID.SelectedValue.ToString();
            string _iStaffID = comboBox_StaffID.SelectedValue.ToString();
            DateTime _dOrdersDate = OrdersDate.Value;

            try
            {
                orders = new Orders.Orders(0, int.Parse(_iCustomerID), int.Parse(_iStaffID), _dOrdersDate);
                if (ordersAction.insert(orders))
                {
                    textBox__OrdersID.Text = "";
                    dataGridView_Orders.DataSource = ordersAction.getAllOrders();
                }
                else
                {
                    MessageBox.Show("Add a new orders have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int _iOrdersID = int.Parse(textBox__OrdersID.Text);

            // MessageBox confirm if you want to delete the phone
            if (MessageBox.Show("Do you want delete a orders?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if (ordersAction.delete(_iOrdersID))
            {
                dataGridView_Orders.DataSource = ordersAction.getAllOrders();
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
                if (MessageBox.Show("Do you want update the orders?", "Notification",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                //execute code to add
                int _iOrdersID = int.Parse(textBox__OrdersID.Text);

                string _iCustomerID = comboBox_CustomerID.SelectedValue.ToString();
                string _iStaffID = comboBox_StaffID.SelectedValue.ToString();
                DateTime _dOrdersDate = OrdersDate.Value;

                orders = new Orders.Orders(_iOrdersID, int.Parse(_iCustomerID), int.Parse(_iStaffID), _dOrdersDate);

                if (ordersAction.update(orders))
                {
                    dataGridView_Orders.DataSource = ordersAction.getAllOrders();
                }
                else
                {
                    MessageBox.Show("Update the orders have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
