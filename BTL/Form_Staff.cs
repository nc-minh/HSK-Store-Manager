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
using BTL.Staff;

namespace BTL
{
    public partial class Form_Staff : Form
    {
        public Form_Staff()
        {
            InitializeComponent();
        }
        StaffAction staffAction;
        Staff.Staff staff;
        private void Form_Staff_Load(object sender, EventArgs e)
        {
            staffAction = new StaffAction();
            try
            {
                dataGridView_Staff.DataSource = staffAction.getAllStaff();
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
                textBox_StaffID.Text = dataGridView_Staff.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
                textBox_FullName.Text = dataGridView_Staff.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
                textBox_Address.Text = dataGridView_Staff.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
                DateOfBirth.Text = dataGridView_Staff.CurrentRow.Cells["Ngày Sinh"].Value.ToString();
                textBox_PhoneNumber.Text = dataGridView_Staff.CurrentRow.Cells["Số Điện Thoại"].Value.ToString();
                textBox_BasicSalar.Text = dataGridView_Staff.CurrentRow.Cells["Lương Cơ Bản"].Value.ToString();
                textBox_Grant.Text = dataGridView_Staff.CurrentRow.Cells["Phụ Cấp"].Value.ToString();
            }
            catch
            {
                dataGridView_Staff.DataSource = staffAction.getAllStaff();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //execute code to add
            string _sFullName = textBox_FullName.Text;
            string _sAddress = textBox_Address.Text;
            DateTime _dDateOfBirth = DateOfBirth.Value;
            string _sPhoneNumber = textBox_PhoneNumber.Text;
            float _fBasicSalary = float.Parse(textBox_BasicSalar.Text);
            float _fGrant = float.Parse(textBox_Grant.Text);

            try
            {
                staff = new Staff.Staff(0, _sFullName, _sAddress, _dDateOfBirth, _sPhoneNumber, _fBasicSalary, _fGrant);
                if(staffAction.insert(staff))
                {
                    textBox_FullName.Text = "";
                    textBox_Address.Text = "";
                    textBox_PhoneNumber.Text = "";
                    textBox_BasicSalar.Text = "";
                    textBox_Grant.Text = "";
                    dataGridView_Staff.DataSource = staffAction.getAllStaff();
                }
                else
                {
                    MessageBox.Show("Add a new staff have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string _iStaffID = textBox_StaffID.Text;

            // MessageBox confirm if you want to delete the phone
            if (MessageBox.Show("Do you want delete a staff?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if (staffAction.delete(_iStaffID))
            {
                dataGridView_Staff.DataSource = staffAction.getAllStaff();
            }
            else
            {
                MessageBox.Show("Delete the staff have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // MessageBox confirm if you want to update the phone
                if (MessageBox.Show("Do you want update the staff?", "Notification",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                //execute code to add
                int _iStaffID = int.Parse(textBox_StaffID.Text);

                string _sFullName = textBox_FullName.Text;
                string _sAddress = textBox_Address.Text;
                DateTime _dDateOfBirth = DateOfBirth.Value;
                string _sPhoneNumber = textBox_PhoneNumber.Text;
                float _fBasicSalary = float.Parse(textBox_BasicSalar.Text);
                float _fGrant = float.Parse(textBox_Grant.Text);

                staff = new Staff.Staff(_iStaffID, _sFullName, _sAddress, _dDateOfBirth, _sPhoneNumber, _fBasicSalary, _fGrant);

                if (staffAction.update(staff))
                {
                    dataGridView_Staff.DataSource = staffAction.getAllStaff();
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

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Report.Staff_Report staff_Report = new Report.Staff_Report();
            staff_Report.Show();
        }
    }
}
