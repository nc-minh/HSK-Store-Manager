using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BTL.Report
{
    public partial class Phone_Report : Form
    {
        public Phone_Report()
        {
            InitializeComponent();
        }

        private void Phone_Report_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\FITHOU\\Các môn học\\Lập trình hướng sự kiện\\BTL\\BTL\\CrystalReport.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            crystalReportViewer_Phone.ReportSource = report;
            crystalReportViewer_Phone.RefreshReport();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\FITHOU\\Các môn học\\Lập trình hướng sự kiện\\BTL\\BTL\\CrystalReport.rpt");

            string constr = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
            SqlConnection sp = new SqlConnection(constr);
            sp.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sp;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = @"searchPhone";
            cmd.Parameters.AddWithValue("@sPhoneModel", textBox_PhoneModel.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            CrystalReport_SearchThePhone category = new CrystalReport_SearchThePhone();
            category.SetDataSource(dataTable);
            crystalReportViewer_Phone.ReportSource = category;
            crystalReportViewer_Phone.Refresh();
        }
    }
}
