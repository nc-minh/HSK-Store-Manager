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
    public partial class Form_Brand : Form
    {
        public Form_Brand()
        {
            InitializeComponent();
        }
        BrandAction brandAction;
        Brand brand;

        private void Form_Brand_Load(object sender, EventArgs e)
        {
            brandAction = new BrandAction();
            try
            {
                dataGridView_Brand.DataSource = brandAction.getAllBrand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrandToTextView(object sender, DataGridViewCellEventArgs e)
        {
            //This function use to get data follow each row and fill to TextBox
            //If you want click full row you click in DataGridView and find 'SelectionMode' property switch to 'FullRowSelect'
            try
            {
                textBox_BrandID.Text = dataGridView_Brand.CurrentRow.Cells["sBrandID"].Value.ToString();
                textBox_BrandName.Text = dataGridView_Brand.CurrentRow.Cells["sBrandName"].Value.ToString();
            }
            catch
            {
                dataGridView_Brand.DataSource = brandAction.getAllBrand();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //execute code to add
            string _sBrandID = textBox_BrandID.Text;
            string _sBrandName = textBox_BrandName.Text;

            try
            {
                brand = new Brand(_sBrandID, _sBrandName);
                if (brandAction.insert(brand))
                {
                    textBox_BrandID.Text = "";
                    textBox_BrandName.Text = "";
                    dataGridView_Brand.DataSource = brandAction.getAllBrand();
                }
                else
                {
                    MessageBox.Show("Add a new brand have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form_Brand_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string _BrandID = textBox_BrandID.Text;

            // MessageBox confirm if you want to delete the phone
            if (MessageBox.Show("Do you want delete a brand?", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            if (brandAction.delete(_BrandID))
            {
                textBox_BrandID.Text = "";
                textBox_BrandName.Text = "";
                dataGridView_Brand.DataSource = brandAction.getAllBrand();
            }
            else
            {
                MessageBox.Show("Delete the brand have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
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
                string _sBrandID = textBox_BrandID.Text;
                string _sBrandName = textBox_BrandName.Text;

                brand = new Brand(_sBrandID, _sBrandName);

                if (brandAction.update(brand))
                {
                    dataGridView_Brand.DataSource = brandAction.getAllBrand();
                }
                else
                {
                    MessageBox.Show("Update the brand have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
