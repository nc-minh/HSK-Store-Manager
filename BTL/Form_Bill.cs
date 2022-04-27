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
    public partial class Form_Bill : Form
    {
        public Form_Bill()
        {
            InitializeComponent();
        }

        BrandAction brandAction;
        Bill.BillAction billAction;

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            billAction = new Bill.BillAction();
            try
            {
                dataGridView_Bill.DataSource = billAction.getAllBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
