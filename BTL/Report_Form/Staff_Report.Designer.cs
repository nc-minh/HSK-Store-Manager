
namespace BTL.Report
{
    partial class Staff_Report
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
            this.crystalReportViewer_Staff = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer_Staff
            // 
            this.crystalReportViewer_Staff.ActiveViewIndex = -1;
            this.crystalReportViewer_Staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_Staff.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_Staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer_Staff.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer_Staff.Name = "crystalReportViewer_Staff";
            this.crystalReportViewer_Staff.Size = new System.Drawing.Size(1371, 758);
            this.crystalReportViewer_Staff.TabIndex = 0;
            this.crystalReportViewer_Staff.Load += new System.EventHandler(this.crystalReportViewer_Staff_Load);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(505, 59);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(129, 22);
            this.textBox_Search.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(615, 59);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Staff_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 758);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.crystalReportViewer_Staff);
            this.Name = "Staff_Report";
            this.Text = "Staff_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_Staff;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button btn_Search;
    }
}