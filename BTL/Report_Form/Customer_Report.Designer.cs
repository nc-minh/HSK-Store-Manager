
namespace BTL.Report_Form
{
    partial class Customer_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer_Customer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer_Customer
            // 
            this.crystalReportViewer_Customer.ActiveViewIndex = -1;
            this.crystalReportViewer_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Customer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Customer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Customer.Name = "crystalReportViewer_Customer";
            this.crystalReportViewer_Customer.Size = new System.Drawing.Size(1386, 749);
            this.crystalReportViewer_Customer.TabIndex = 0;
            this.crystalReportViewer_Customer.Load += new System.EventHandler(this.crystalReportViewer_Customer_Load);
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 749);
            this.Controls.Add(this.crystalReportViewer_Customer);
            this.Name = "Customer_Report";
            this.Text = "Customer_Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Customer;
    }
}