namespace QLBHTH_PhanDinhDung
{
    partial class frm_baocao_hai
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
            this.rp_baocao_hai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp_baocao_hai
            // 
            this.rp_baocao_hai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_baocao_hai.LocalReport.ReportEmbeddedResource = "QLBHTH_PhanDinhDung.rp_baocao_hai.rdlc";
            this.rp_baocao_hai.Location = new System.Drawing.Point(0, 0);
            this.rp_baocao_hai.Name = "rp_baocao_hai";
            this.rp_baocao_hai.ServerReport.BearerToken = null;
            this.rp_baocao_hai.Size = new System.Drawing.Size(877, 538);
            this.rp_baocao_hai.TabIndex = 0;
            this.rp_baocao_hai.Load += new System.EventHandler(this.rp_baocao_hai_Load);
            // 
            // frm_baocao_hai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 538);
            this.Controls.Add(this.rp_baocao_hai);
            this.Name = "frm_baocao_hai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_baocao_hai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_baocao_hai_FormClosed);
            this.Load += new System.EventHandler(this.frm_baocao_hai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_baocao_hai;
    }
}