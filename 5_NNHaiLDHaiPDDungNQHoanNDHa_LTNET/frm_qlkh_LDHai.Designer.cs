namespace QLBHTH_PhanDinhDung
{
    partial class frm_qlkh_LDHai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_qlkh_LDHai = new System.Windows.Forms.DataGridView();
            this.txt_mkh_LDHai = new System.Windows.Forms.TextBox();
            this.txt_tkh_LDHai = new System.Windows.Forms.TextBox();
            this.txt_dc_LDHai = new System.Windows.Forms.TextBox();
            this.txt_quan_LDHai = new System.Windows.Forms.TextBox();
            this.txt_tp_LDHai = new System.Windows.Forms.TextBox();
            this.btn_them_LDHai = new System.Windows.Forms.Button();
            this.btn_sua_LDHai = new System.Windows.Forms.Button();
            this.btn_xoa_LDHai = new System.Windows.Forms.Button();
            this.btn_nhaplai_LDHai = new System.Windows.Forms.Button();
            this.btn_ql_LDHai = new System.Windows.Forms.Button();
            this.mkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlkh_LDHai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thành phố";
            // 
            // dgv_qlkh_LDHai
            // 
            this.dgv_qlkh_LDHai.AllowUserToAddRows = false;
            this.dgv_qlkh_LDHai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlkh_LDHai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_qlkh_LDHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlkh_LDHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mkh,
            this.tkh,
            this.dc,
            this.quan,
            this.tp});
            this.dgv_qlkh_LDHai.Location = new System.Drawing.Point(12, 345);
            this.dgv_qlkh_LDHai.Name = "dgv_qlkh_LDHai";
            this.dgv_qlkh_LDHai.Size = new System.Drawing.Size(877, 179);
            this.dgv_qlkh_LDHai.TabIndex = 6;
            this.dgv_qlkh_LDHai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlkh_LDHai_CellClick);
            // 
            // txt_mkh_LDHai
            // 
            this.txt_mkh_LDHai.Location = new System.Drawing.Point(202, 112);
            this.txt_mkh_LDHai.Name = "txt_mkh_LDHai";
            this.txt_mkh_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_mkh_LDHai.TabIndex = 7;
            // 
            // txt_tkh_LDHai
            // 
            this.txt_tkh_LDHai.Location = new System.Drawing.Point(202, 161);
            this.txt_tkh_LDHai.Name = "txt_tkh_LDHai";
            this.txt_tkh_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_tkh_LDHai.TabIndex = 8;
            // 
            // txt_dc_LDHai
            // 
            this.txt_dc_LDHai.Location = new System.Drawing.Point(202, 214);
            this.txt_dc_LDHai.Name = "txt_dc_LDHai";
            this.txt_dc_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_dc_LDHai.TabIndex = 9;
            // 
            // txt_quan_LDHai
            // 
            this.txt_quan_LDHai.Location = new System.Drawing.Point(593, 112);
            this.txt_quan_LDHai.Name = "txt_quan_LDHai";
            this.txt_quan_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_quan_LDHai.TabIndex = 10;
            // 
            // txt_tp_LDHai
            // 
            this.txt_tp_LDHai.Location = new System.Drawing.Point(593, 164);
            this.txt_tp_LDHai.Name = "txt_tp_LDHai";
            this.txt_tp_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_tp_LDHai.TabIndex = 11;
            // 
            // btn_them_LDHai
            // 
            this.btn_them_LDHai.Location = new System.Drawing.Point(117, 278);
            this.btn_them_LDHai.Name = "btn_them_LDHai";
            this.btn_them_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_them_LDHai.TabIndex = 12;
            this.btn_them_LDHai.Text = "Thêm";
            this.btn_them_LDHai.UseVisualStyleBackColor = true;
            this.btn_them_LDHai.Click += new System.EventHandler(this.btn_them_LDHai_Click);
            // 
            // btn_sua_LDHai
            // 
            this.btn_sua_LDHai.Location = new System.Drawing.Point(276, 278);
            this.btn_sua_LDHai.Name = "btn_sua_LDHai";
            this.btn_sua_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_sua_LDHai.TabIndex = 13;
            this.btn_sua_LDHai.Text = "Sửa";
            this.btn_sua_LDHai.UseVisualStyleBackColor = true;
            this.btn_sua_LDHai.Click += new System.EventHandler(this.btn_sua_LDHai_Click);
            // 
            // btn_xoa_LDHai
            // 
            this.btn_xoa_LDHai.Location = new System.Drawing.Point(435, 278);
            this.btn_xoa_LDHai.Name = "btn_xoa_LDHai";
            this.btn_xoa_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_LDHai.TabIndex = 14;
            this.btn_xoa_LDHai.Text = "Xoá";
            this.btn_xoa_LDHai.UseVisualStyleBackColor = true;
            this.btn_xoa_LDHai.Click += new System.EventHandler(this.btn_xoa_LDHai_Click);
            // 
            // btn_nhaplai_LDHai
            // 
            this.btn_nhaplai_LDHai.Location = new System.Drawing.Point(594, 278);
            this.btn_nhaplai_LDHai.Name = "btn_nhaplai_LDHai";
            this.btn_nhaplai_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_nhaplai_LDHai.TabIndex = 15;
            this.btn_nhaplai_LDHai.Text = "Nhập lại";
            this.btn_nhaplai_LDHai.UseVisualStyleBackColor = true;
            this.btn_nhaplai_LDHai.Click += new System.EventHandler(this.btn_nhaplai_LDHai_Click);
            // 
            // btn_ql_LDHai
            // 
            this.btn_ql_LDHai.Location = new System.Drawing.Point(753, 278);
            this.btn_ql_LDHai.Name = "btn_ql_LDHai";
            this.btn_ql_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_ql_LDHai.TabIndex = 16;
            this.btn_ql_LDHai.Text = "Quay lại";
            this.btn_ql_LDHai.UseVisualStyleBackColor = true;
            this.btn_ql_LDHai.Click += new System.EventHandler(this.btn_ql_LDHai_Click);
            // 
            // mkh
            // 
            this.mkh.DataPropertyName = "MaKH";
            this.mkh.HeaderText = "Mã khách hàng";
            this.mkh.Name = "mkh";
            // 
            // tkh
            // 
            this.tkh.DataPropertyName = "TenKH";
            this.tkh.HeaderText = "Tên khách hàng";
            this.tkh.Name = "tkh";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "Diachi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.Name = "dc";
            // 
            // quan
            // 
            this.quan.DataPropertyName = "Quan";
            this.quan.HeaderText = "Quận";
            this.quan.Name = "quan";
            // 
            // tp
            // 
            this.tp.DataPropertyName = "Thanhpho";
            this.tp.HeaderText = "Thành phố";
            this.tp.Name = "tp";
            // 
            // frm_qlkh_LDHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 536);
            this.Controls.Add(this.btn_ql_LDHai);
            this.Controls.Add(this.btn_nhaplai_LDHai);
            this.Controls.Add(this.btn_xoa_LDHai);
            this.Controls.Add(this.btn_sua_LDHai);
            this.Controls.Add(this.btn_them_LDHai);
            this.Controls.Add(this.txt_tp_LDHai);
            this.Controls.Add(this.txt_quan_LDHai);
            this.Controls.Add(this.txt_dc_LDHai);
            this.Controls.Add(this.txt_tkh_LDHai);
            this.Controls.Add(this.txt_mkh_LDHai);
            this.Controls.Add(this.dgv_qlkh_LDHai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_qlkh_LDHai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Quản Lý Khách Hàng Lê Đức Hải";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_qlkh_LDHai_FormClosed);
            this.Load += new System.EventHandler(this.frm_qlkh_LDHai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlkh_LDHai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_qlkh_LDHai;
        private System.Windows.Forms.TextBox txt_mkh_LDHai;
        private System.Windows.Forms.TextBox txt_tkh_LDHai;
        private System.Windows.Forms.TextBox txt_dc_LDHai;
        private System.Windows.Forms.TextBox txt_quan_LDHai;
        private System.Windows.Forms.TextBox txt_tp_LDHai;
        private System.Windows.Forms.Button btn_them_LDHai;
        private System.Windows.Forms.Button btn_sua_LDHai;
        private System.Windows.Forms.Button btn_xoa_LDHai;
        private System.Windows.Forms.Button btn_nhaplai_LDHai;
        private System.Windows.Forms.Button btn_ql_LDHai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp;
    }
}