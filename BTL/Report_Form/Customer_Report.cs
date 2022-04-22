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

namespace BTL.Report_Form
{
    public partial class Customer_Report : Form
    {
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer_Customer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("F:\\FITHOU\\Các môn học\\Lập trình hướng sự kiện\\BTL\\BTL\\CrystalReport.rpt");
            //report.RecordSelectionFormula = "{tbl_detailOrder.price}";
            crystalReportViewer_Customer.ReportSource = report;
            crystalReportViewer_Customer.RefreshReport();
        }
    }
}
