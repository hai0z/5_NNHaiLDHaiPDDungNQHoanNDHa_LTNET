namespace QLBHTH_PhanDinhDung
{
    partial class frm_hoadon_hai
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
            this.rpv_hoadon_hai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpv_hoadon_hai
            // 
            this.rpv_hoadon_hai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_hoadon_hai.Location = new System.Drawing.Point(0, 0);
            this.rpv_hoadon_hai.Name = "rpv_hoadon_hai";
            this.rpv_hoadon_hai.ServerReport.BearerToken = null;
            this.rpv_hoadon_hai.Size = new System.Drawing.Size(1083, 589);
            this.rpv_hoadon_hai.TabIndex = 0;
            this.rpv_hoadon_hai.Load += new System.EventHandler(this.rpv_hoadon_hai_Load);
            // 
            // frm_hoadon_hai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 589);
            this.Controls.Add(this.rpv_hoadon_hai);
            this.Name = "frm_hoadon_hai";
            this.Text = "frm_hoadon_hai";
            this.Load += new System.EventHandler(this.frm_hoadon_hai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_hoadon_hai;
    }
}