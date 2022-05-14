namespace QLBHTH_PhanDinhDung
{
    partial class frm_qldoanhthu_hai
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
            this.btn_quaylai_hai = new System.Windows.Forms.Button();
            this.btn_xem_hai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_doanhthu_hai = new System.Windows.Forms.DataGridView();
            this.dtp_ngay_hai = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mvn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu_hai)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quaylai_hai
            // 
            this.btn_quaylai_hai.Location = new System.Drawing.Point(434, 153);
            this.btn_quaylai_hai.Name = "btn_quaylai_hai";
            this.btn_quaylai_hai.Size = new System.Drawing.Size(75, 23);
            this.btn_quaylai_hai.TabIndex = 11;
            this.btn_quaylai_hai.Text = "Quay lại";
            this.btn_quaylai_hai.UseVisualStyleBackColor = true;
            this.btn_quaylai_hai.Click += new System.EventHandler(this.btn_quaylai_hai_Click);
            // 
            // btn_xem_hai
            // 
            this.btn_xem_hai.Location = new System.Drawing.Point(309, 153);
            this.btn_xem_hai.Name = "btn_xem_hai";
            this.btn_xem_hai.Size = new System.Drawing.Size(75, 23);
            this.btn_xem_hai.TabIndex = 10;
            this.btn_xem_hai.Text = "Xem";
            this.btn_xem_hai.UseVisualStyleBackColor = true;
            this.btn_xem_hai.Click += new System.EventHandler(this.btn_xem_hai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày";
            // 
            // dgv_doanhthu_hai
            // 
            this.dgv_doanhthu_hai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doanhthu_hai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu_hai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mvn,
            this.mnv,
            this.doanhthu});
            this.dgv_doanhthu_hai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_doanhthu_hai.Location = new System.Drawing.Point(0, 285);
            this.dgv_doanhthu_hai.Name = "dgv_doanhthu_hai";
            this.dgv_doanhthu_hai.Size = new System.Drawing.Size(891, 292);
            this.dgv_doanhthu_hai.TabIndex = 8;
            // 
            // dtp_ngay_hai
            // 
            this.dtp_ngay_hai.CustomFormat = "dd-MM-yyyy";
            this.dtp_ngay_hai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_hai.Location = new System.Drawing.Point(309, 87);
            this.dtp_ngay_hai.Name = "dtp_ngay_hai";
            this.dtp_ngay_hai.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngay_hai.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ DOANH THU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // mvn
            // 
            this.mvn.DataPropertyName = "MaNV";
            this.mvn.HeaderText = "Mã nhân viên";
            this.mvn.Name = "mvn";
            // 
            // mnv
            // 
            this.mnv.DataPropertyName = "TenNV";
            this.mnv.HeaderText = "Tên nhân viên";
            this.mnv.Name = "mnv";
            // 
            // doanhthu
            // 
            this.doanhthu.DataPropertyName = "tongtien";
            this.doanhthu.HeaderText = "Doanh thu trong ngày";
            this.doanhthu.Name = "doanhthu";
            // 
            // frm_qldoanhthu_hai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_quaylai_hai);
            this.Controls.Add(this.btn_xem_hai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_doanhthu_hai);
            this.Controls.Add(this.dtp_ngay_hai);
            this.Controls.Add(this.label1);
            this.Name = "frm_qldoanhthu_hai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_qldoanhthu_hai";
            this.Load += new System.EventHandler(this.frm_qldoanhthu_hai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu_hai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quaylai_hai;
        private System.Windows.Forms.Button btn_xem_hai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_doanhthu_hai;
        private System.Windows.Forms.DateTimePicker dtp_ngay_hai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mvn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhthu;
    }
}