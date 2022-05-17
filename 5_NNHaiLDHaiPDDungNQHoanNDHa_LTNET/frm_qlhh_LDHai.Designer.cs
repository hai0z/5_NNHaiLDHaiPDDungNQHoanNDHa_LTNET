using System.Drawing;

namespace QLBHTH_PhanDinhDung
{
    partial class frm_qlhh_LDHai
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
            this.dgv_qlhh_LDHai = new System.Windows.Forms.DataGridView();
            this.Mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_dg_LDHai = new System.Windows.Forms.TextBox();
            this.txt_dvt_LDHai = new System.Windows.Forms.TextBox();
            this.txt_th_LDHai = new System.Windows.Forms.TextBox();
            this.txt_mh_LDHai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_lh_LDHai = new System.Windows.Forms.ComboBox();
            this.btn_ql_LDHai = new System.Windows.Forms.Button();
            this.btn_nhaplai_LDHai = new System.Windows.Forms.Button();
            this.btn_xoa_LDHai = new System.Windows.Forms.Button();
            this.btn_sua_LDHai = new System.Windows.Forms.Button();
            this.btn_them_LDHai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlhh_LDHai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÀNG HOÁ";
            // 
            // dgv_qlhh_LDHai
            // 
            this.dgv_qlhh_LDHai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlhh_LDHai.BackgroundColor = System.Drawing.Color.White;
            this.dgv_qlhh_LDHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlhh_LDHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahang,
            this.Tenhang,
            this.TenLoai,
            this.DVT,
            this.DG});
            this.dgv_qlhh_LDHai.Location = new System.Drawing.Point(12, 288);
            this.dgv_qlhh_LDHai.Name = "dgv_qlhh_LDHai";
            this.dgv_qlhh_LDHai.Size = new System.Drawing.Size(892, 221);
            this.dgv_qlhh_LDHai.TabIndex = 6;
            this.dgv_qlhh_LDHai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlhh_LDHai_CellClick);
            this.dgv_qlhh_LDHai.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_qlhh_LDHai.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            // 
            // Mahang
            // 
            this.Mahang.DataPropertyName = "Mahang";
            this.Mahang.HeaderText = "Mã hàng";
            this.Mahang.Name = "Mahang";
            // 
            // Tenhang
            // 
            this.Tenhang.DataPropertyName = "Tenhang";
            this.Tenhang.HeaderText = "Tên Hàng";
            this.Tenhang.Name = "Tenhang";
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên loại hàng";
            this.TenLoai.Name = "TenLoai";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // DG
            // 
            this.DG.DataPropertyName = "Dongia";
            this.DG.HeaderText = "Đơn giá";
            this.DG.Name = "DG";
            // 
            // txt_dg_LDHai
            // 
            this.txt_dg_LDHai.Location = new System.Drawing.Point(547, 148);
            this.txt_dg_LDHai.Name = "txt_dg_LDHai";
            this.txt_dg_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_dg_LDHai.TabIndex = 5;
            // 
            // txt_dvt_LDHai
            // 
            this.txt_dvt_LDHai.Location = new System.Drawing.Point(547, 96);
            this.txt_dvt_LDHai.Name = "txt_dvt_LDHai";
            this.txt_dvt_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_dvt_LDHai.TabIndex = 4;
            // 
            // txt_th_LDHai
            // 
            this.txt_th_LDHai.Location = new System.Drawing.Point(156, 198);
            this.txt_th_LDHai.Name = "txt_th_LDHai";
            this.txt_th_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_th_LDHai.TabIndex = 3;
            // 
            // txt_mh_LDHai
            // 
            this.txt_mh_LDHai.Location = new System.Drawing.Point(156, 96);
            this.txt_mh_LDHai.Name = "txt_mh_LDHai";
            this.txt_mh_LDHai.Size = new System.Drawing.Size(236, 20);
            this.txt_mh_LDHai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loại hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hàng";
            // 
            // cb_lh_LDHai
            // 
            this.cb_lh_LDHai.FormattingEnabled = true;
            this.cb_lh_LDHai.Location = new System.Drawing.Point(156, 144);
            this.cb_lh_LDHai.Name = "cb_lh_LDHai";
            this.cb_lh_LDHai.Size = new System.Drawing.Size(236, 21);
            this.cb_lh_LDHai.TabIndex = 2;
            // 
            // btn_ql_LDHai
            // 
            this.btn_ql_LDHai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ql_LDHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ql_LDHai.Location = new System.Drawing.Point(742, 242);
            this.btn_ql_LDHai.Name = "btn_ql_LDHai";
            this.btn_ql_LDHai.Size = new System.Drawing.Size(81, 28);
            this.btn_ql_LDHai.TabIndex = 10;
            this.btn_ql_LDHai.Text = "Quay lại";
            this.btn_ql_LDHai.UseVisualStyleBackColor = true;
            this.btn_ql_LDHai.Click += new System.EventHandler(this.btn_ql_LDHai_Click);
            // 
            // btn_nhaplai_LDHai
            // 
            this.btn_nhaplai_LDHai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhaplai_LDHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai_LDHai.Location = new System.Drawing.Point(583, 242);
            this.btn_nhaplai_LDHai.Name = "btn_nhaplai_LDHai";
            this.btn_nhaplai_LDHai.Size = new System.Drawing.Size(81, 28);
            this.btn_nhaplai_LDHai.TabIndex = 9;
            this.btn_nhaplai_LDHai.Text = "Nhập lại";
            this.btn_nhaplai_LDHai.UseVisualStyleBackColor = true;
            this.btn_nhaplai_LDHai.Click += new System.EventHandler(this.btn_nhaplai_LDHai_Click);
            // 
            // btn_xoa_LDHai
            // 
            this.btn_xoa_LDHai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa_LDHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_LDHai.Location = new System.Drawing.Point(424, 242);
            this.btn_xoa_LDHai.Name = "btn_xoa_LDHai";
            this.btn_xoa_LDHai.Size = new System.Drawing.Size(81, 28);
            this.btn_xoa_LDHai.TabIndex = 8;
            this.btn_xoa_LDHai.Text = "Xoá";
            this.btn_xoa_LDHai.UseVisualStyleBackColor = true;
            this.btn_xoa_LDHai.Click += new System.EventHandler(this.btn_xoa_LDHai_Click);
            // 
            // btn_sua_LDHai
            // 
            this.btn_sua_LDHai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua_LDHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_LDHai.Location = new System.Drawing.Point(265, 242);
            this.btn_sua_LDHai.Name = "btn_sua_LDHai";
            this.btn_sua_LDHai.Size = new System.Drawing.Size(81, 28);
            this.btn_sua_LDHai.TabIndex = 7;
            this.btn_sua_LDHai.Text = "Sửa";
            this.btn_sua_LDHai.UseVisualStyleBackColor = true;
            this.btn_sua_LDHai.Click += new System.EventHandler(this.btn_sua_LDHai_Click);
            // 
            // btn_them_LDHai
            // 
            this.btn_them_LDHai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them_LDHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_LDHai.Location = new System.Drawing.Point(106, 242);
            this.btn_them_LDHai.Name = "btn_them_LDHai";
            this.btn_them_LDHai.Size = new System.Drawing.Size(81, 28);
            this.btn_them_LDHai.TabIndex = 6;
            this.btn_them_LDHai.Text = "Thêm";
            this.btn_them_LDHai.UseVisualStyleBackColor = true;
            this.btn_them_LDHai.Click += new System.EventHandler(this.btn_them_LDHai_Click);
            // 
            // frm_qlhh_LDHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 521);
            this.Controls.Add(this.btn_ql_LDHai);
            this.Controls.Add(this.btn_nhaplai_LDHai);
            this.Controls.Add(this.btn_xoa_LDHai);
            this.Controls.Add(this.btn_sua_LDHai);
            this.Controls.Add(this.btn_them_LDHai);
            this.Controls.Add(this.cb_lh_LDHai);
            this.Controls.Add(this.txt_dg_LDHai);
            this.Controls.Add(this.txt_dvt_LDHai);
            this.Controls.Add(this.txt_th_LDHai);
            this.Controls.Add(this.txt_mh_LDHai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_qlhh_LDHai);
            this.Controls.Add(this.label1);
            this.Name = "frm_qlhh_LDHai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form quản lý hàng hoá Lê Đức Hải";
            this.Load += new System.EventHandler(this.frm_qlhh_LDHai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlhh_LDHai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_qlhh_LDHai;
        private System.Windows.Forms.TextBox txt_dg_LDHai;
        private System.Windows.Forms.TextBox txt_dvt_LDHai;
        private System.Windows.Forms.TextBox txt_th_LDHai;
        private System.Windows.Forms.TextBox txt_mh_LDHai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_lh_LDHai;
        private System.Windows.Forms.Button btn_ql_LDHai;
        private System.Windows.Forms.Button btn_nhaplai_LDHai;
        private System.Windows.Forms.Button btn_xoa_LDHai;
        private System.Windows.Forms.Button btn_sua_LDHai;
        private System.Windows.Forms.Button btn_them_LDHai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
    }
}