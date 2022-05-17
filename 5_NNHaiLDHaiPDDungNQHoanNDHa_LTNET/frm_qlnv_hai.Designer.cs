using System.Drawing;

namespace QLBHTH_PhanDinhDung
{
    partial class frm_qlnv_hai
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
            this.txt_mnv_hai = new System.Windows.Forms.TextBox();
            this.txt_mk_hai = new System.Windows.Forms.TextBox();
            this.btn_sua_hai = new System.Windows.Forms.Button();
            this.dgv_nv_hai = new System.Windows.Forms.DataGridView();
            this.mvn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_dc_hai = new System.Windows.Forms.TextBox();
            this.txt_tennv_hai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_them_hai = new System.Windows.Forms.Button();
            this.btn_xoa_hai = new System.Windows.Forms.Button();
            this.btn_quaylai_hai = new System.Windows.Forms.Button();
            this.btn_nhapLai_hai = new System.Windows.Forms.Button();
            this.cb_quyen_hai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv_hai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txt_mnv_hai
            // 
            this.txt_mnv_hai.Location = new System.Drawing.Point(233, 89);
            this.txt_mnv_hai.Name = "txt_mnv_hai";
            this.txt_mnv_hai.Size = new System.Drawing.Size(201, 20);
            this.txt_mnv_hai.TabIndex = 1;
            // 
            // txt_mk_hai
            // 
            this.txt_mk_hai.Location = new System.Drawing.Point(594, 92);
            this.txt_mk_hai.Name = "txt_mk_hai";
            this.txt_mk_hai.Size = new System.Drawing.Size(241, 20);
            this.txt_mk_hai.TabIndex = 4;
            // 
            // btn_sua_hai
            // 
            this.btn_sua_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_hai.Location = new System.Drawing.Point(283, 291);
            this.btn_sua_hai.Name = "btn_sua_hai";
            this.btn_sua_hai.Size = new System.Drawing.Size(80, 26);
            this.btn_sua_hai.TabIndex = 3;
            this.btn_sua_hai.Text = "Sửa";
            this.btn_sua_hai.UseVisualStyleBackColor = true;
            this.btn_sua_hai.Click += new System.EventHandler(this.btn_sua_hai_Click);
            // 
            // dgv_nv_hai
            // 
            this.dgv_nv_hai.AllowUserToAddRows = false;
            this.dgv_nv_hai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nv_hai.BackgroundColor = System.Drawing.Color.White;
            this.dgv_nv_hai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv_hai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mvn,
            this.tennv,
            this.dc,
            this.mk,
            this.quyen});
            this.dgv_nv_hai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_nv_hai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_nv_hai.Location = new System.Drawing.Point(0, 373);
            this.dgv_nv_hai.Name = "dgv_nv_hai";
            this.dgv_nv_hai.Size = new System.Drawing.Size(939, 224);
            this.dgv_nv_hai.TabIndex = 4;
            this.dgv_nv_hai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nv_hai_CellClick);
            this.dgv_nv_hai.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nv_hai.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            // 
            // mvn
            // 
            this.mvn.DataPropertyName = "MaNV";
            this.mvn.HeaderText = "Mã nhân viên";
            this.mvn.Name = "mvn";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "TenNV";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "Diachi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.Name = "dc";
            // 
            // mk
            // 
            this.mk.DataPropertyName = "Matkhau";
            this.mk.HeaderText = "Mật khẩu";
            this.mk.Name = "mk";
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "Quyen";
            this.quyen.HeaderText = "Quyền";
            this.quyen.Name = "quyen";
            // 
            // txt_dc_hai
            // 
            this.txt_dc_hai.Location = new System.Drawing.Point(233, 194);
            this.txt_dc_hai.Name = "txt_dc_hai";
            this.txt_dc_hai.Size = new System.Drawing.Size(201, 20);
            this.txt_dc_hai.TabIndex = 3;
            // 
            // txt_tennv_hai
            // 
            this.txt_tennv_hai.Location = new System.Drawing.Point(233, 141);
            this.txt_tennv_hai.Name = "txt_tennv_hai";
            this.txt_tennv_hai.Size = new System.Drawing.Size(201, 20);
            this.txt_tennv_hai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quyền";
            // 
            // btn_them_hai
            // 
            this.btn_them_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_hai.Location = new System.Drawing.Point(121, 291);
            this.btn_them_hai.Name = "btn_them_hai";
            this.btn_them_hai.Size = new System.Drawing.Size(80, 26);
            this.btn_them_hai.TabIndex = 6;
            this.btn_them_hai.Text = "Thêm";
            this.btn_them_hai.UseVisualStyleBackColor = true;
            this.btn_them_hai.Click += new System.EventHandler(this.btn_them_hai_Click);
            // 
            // btn_xoa_hai
            // 
            this.btn_xoa_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_hai.Location = new System.Drawing.Point(449, 291);
            this.btn_xoa_hai.Name = "btn_xoa_hai";
            this.btn_xoa_hai.Size = new System.Drawing.Size(80, 26);
            this.btn_xoa_hai.TabIndex = 3;
            this.btn_xoa_hai.Text = "Xoá";
            this.btn_xoa_hai.UseVisualStyleBackColor = true;
            this.btn_xoa_hai.Click += new System.EventHandler(this.btn_xoa_hai_Click);
            // 
            // btn_quaylai_hai
            // 
            this.btn_quaylai_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quaylai_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai_hai.Location = new System.Drawing.Point(777, 291);
            this.btn_quaylai_hai.Name = "btn_quaylai_hai";
            this.btn_quaylai_hai.Size = new System.Drawing.Size(80, 26);
            this.btn_quaylai_hai.TabIndex = 3;
            this.btn_quaylai_hai.Text = "Quay Lại";
            this.btn_quaylai_hai.UseVisualStyleBackColor = true;
            this.btn_quaylai_hai.Click += new System.EventHandler(this.btn_quaylai_hai_Click);
            // 
            // btn_nhapLai_hai
            // 
            this.btn_nhapLai_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhapLai_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapLai_hai.Location = new System.Drawing.Point(607, 291);
            this.btn_nhapLai_hai.Name = "btn_nhapLai_hai";
            this.btn_nhapLai_hai.Size = new System.Drawing.Size(80, 26);
            this.btn_nhapLai_hai.TabIndex = 3;
            this.btn_nhapLai_hai.Text = "Nhập Lại";
            this.btn_nhapLai_hai.UseVisualStyleBackColor = true;
            this.btn_nhapLai_hai.Click += new System.EventHandler(this.btn_nhapLai_hai_Click);
            // 
            // cb_quyen_hai
            // 
            this.cb_quyen_hai.FormattingEnabled = true;
            this.cb_quyen_hai.ItemHeight = 13;
            this.cb_quyen_hai.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản  lý"});
            this.cb_quyen_hai.Location = new System.Drawing.Point(594, 148);
            this.cb_quyen_hai.Name = "cb_quyen_hai";
            this.cb_quyen_hai.Size = new System.Drawing.Size(241, 21);
            this.cb_quyen_hai.TabIndex = 6;
            this.cb_quyen_hai.SelectedIndexChanged += new System.EventHandler(this.cb_quyen_hai_SelectedIndexChanged);
            // 
            // frm_qlnv_hai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 597);
            this.Controls.Add(this.cb_quyen_hai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_nv_hai);
            this.Controls.Add(this.btn_them_hai);
            this.Controls.Add(this.btn_nhapLai_hai);
            this.Controls.Add(this.btn_quaylai_hai);
            this.Controls.Add(this.btn_xoa_hai);
            this.Controls.Add(this.btn_sua_hai);
            this.Controls.Add(this.txt_dc_hai);
            this.Controls.Add(this.txt_mk_hai);
            this.Controls.Add(this.txt_tennv_hai);
            this.Controls.Add(this.txt_mnv_hai);
            this.Controls.Add(this.label1);
            this.Name = "frm_qlnv_hai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_qlnv_hai";
            this.Load += new System.EventHandler(this.frm_qlnv_hai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv_hai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mnv_hai;
        private System.Windows.Forms.TextBox txt_mk_hai;
        private System.Windows.Forms.Button btn_sua_hai;
        private System.Windows.Forms.DataGridView dgv_nv_hai;
        private System.Windows.Forms.TextBox txt_dc_hai;
        private System.Windows.Forms.TextBox txt_tennv_hai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_them_hai;
        private System.Windows.Forms.Button btn_xoa_hai;
        private System.Windows.Forms.Button btn_quaylai_hai;
        private System.Windows.Forms.Button btn_nhapLai_hai;
        private System.Windows.Forms.ComboBox cb_quyen_hai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mvn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
    }
}