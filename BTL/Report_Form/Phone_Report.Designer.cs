
namespace BTL.Report
{
    partial class Phone_Report
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
            this.crystalReportViewer_Phone = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.textBox_PhoneModel = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer_Phone
            // 
            this.crystalReportViewer_Phone.ActiveViewIndex = -1;
            this.crystalReportViewer_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Phone.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Phone.Name = "crystalReportViewer_Phone";
            this.crystalReportViewer_Phone.Size = new System.Drawing.Size(1344, 746);
            this.crystalReportViewer_Phone.TabIndex = 0;
            // 
            // textBox_PhoneModel
            // 
            this.textBox_PhoneModel.Location = new System.Drawing.Point(402, 49);
            this.textBox_PhoneModel.Name = "textBox_PhoneModel";
            this.textBox_PhoneModel.Size = new System.Drawing.Size(130, 22);
            this.textBox_PhoneModel.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(551, 49);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Phone_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 746);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox_PhoneModel);
            this.Controls.Add(this.crystalReportViewer_Phone);
            this.Name = "Phone_Report";
            this.Text = "Phone_Report";
            this.Load += new System.EventHandler(this.Phone_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Phone;
        private System.Windows.Forms.TextBox textBox_PhoneModel;
        private System.Windows.Forms.Button btn_Search;
    }
}