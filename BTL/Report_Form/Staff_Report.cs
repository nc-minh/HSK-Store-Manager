using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Report
{
    public partial class Staff_Report : Form
    {
        public Staff_Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer_Staff_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\FITHOU\\Các môn học\\Lập trình hướng sự kiện\\BTL\\BTL\\CrystalReport_Staff.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            crystalReportViewer_Staff.ReportSource = report;
            crystalReportViewer_Staff.RefreshReport();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\FITHOU\\Các môn học\\Lập trình hướng sự kiện\\BTL\\BTL\\CrystalReport_Staff.rpt");

            string constr = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"searchStaff";
            cmd.Parameters.AddWithValue("@sFullName", textBox_Search.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            CrystalReport_SearchTheStaff category = new CrystalReport_SearchTheStaff();
            category.SetDataSource(dataTable);
            crystalReportViewer_Staff.ReportSource = category;
            crystalReportViewer_Staff.Refresh();
        }
    }
}
