using System.Drawing;

namespace QLBHTH_PhanDinhDung
{
    partial class frm_qlhoadon_hai
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
            this.txt_mahoadon_hai = new System.Windows.Forms.TextBox();
            this.dgv_hoadon_hai = new System.Windows.Forms.DataGridView();
            this.sohd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_xem_hai = new System.Windows.Forms.Button();
            this.btn_quaylai_hai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon_hai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(313, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HOÁ ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hoá đơn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_mahoadon_hai
            // 
            this.txt_mahoadon_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahoadon_hai.Location = new System.Drawing.Point(352, 120);
            this.txt_mahoadon_hai.Name = "txt_mahoadon_hai";
            this.txt_mahoadon_hai.Size = new System.Drawing.Size(243, 22);
            this.txt_mahoadon_hai.TabIndex = 2;
            this.txt_mahoadon_hai.TextChanged += new System.EventHandler(this.txt_mahoadon_hai_TextChanged);
            // 
            // dgv_hoadon_hai
            // 
            this.dgv_hoadon_hai.AllowUserToResizeColumns = false;
            this.dgv_hoadon_hai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon_hai.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoadon_hai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon_hai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sohd,
            this.ngayban,
            this.tennv,
            this.tkh});
            this.dgv_hoadon_hai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_hoadon_hai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_hoadon_hai.Location = new System.Drawing.Point(0, 278);
            this.dgv_hoadon_hai.Name = "dgv_hoadon_hai";
            this.dgv_hoadon_hai.Size = new System.Drawing.Size(892, 264);
            this.dgv_hoadon_hai.TabIndex = 3;
            this.dgv_hoadon_hai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_hai_CellClick);
            this.dgv_hoadon_hai.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hoadon_hai.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            // 
            // sohd
            // 
            this.sohd.DataPropertyName = "SoHD";
            this.sohd.HeaderText = "Số hoá đơn";
            this.sohd.Name = "sohd";
            // 
            // ngayban
            // 
            this.ngayban.DataPropertyName = "Ngayban";
            this.ngayban.HeaderText = "Ngày bán";
            this.ngayban.Name = "ngayban";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "TenNV";
            this.tennv.HeaderText = "Tên nhân viên";
            this.tennv.Name = "tennv";
            // 
            // tkh
            // 
            this.tkh.DataPropertyName = "TenKH";
            this.tkh.HeaderText = "Tên khách hàng";
            this.tkh.Name = "tkh";
            // 
            // btn_xem_hai
            // 
            this.btn_xem_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xem_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem_hai.Location = new System.Drawing.Point(339, 179);
            this.btn_xem_hai.Name = "btn_xem_hai";
            this.btn_xem_hai.Size = new System.Drawing.Size(88, 27);
            this.btn_xem_hai.TabIndex = 4;
            this.btn_xem_hai.Text = "Xem chi tiết";
            this.btn_xem_hai.UseVisualStyleBackColor = true;
            this.btn_xem_hai.Click += new System.EventHandler(this.btn_xem_hai_Click);
            // 
            // btn_quaylai_hai
            // 
            this.btn_quaylai_hai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quaylai_hai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai_hai.Location = new System.Drawing.Point(507, 179);
            this.btn_quaylai_hai.Name = "btn_quaylai_hai";
            this.btn_quaylai_hai.Size = new System.Drawing.Size(88, 27);
            this.btn_quaylai_hai.TabIndex = 4;
            this.btn_quaylai_hai.Text = "Quay lại";
            this.btn_quaylai_hai.UseVisualStyleBackColor = true;
            this.btn_quaylai_hai.Click += new System.EventHandler(this.btn_quaylai_hai_Click);
            // 
            // frm_qlhoadon_hai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 542);
            this.Controls.Add(this.btn_quaylai_hai);
            this.Controls.Add(this.btn_xem_hai);
            this.Controls.Add(this.dgv_hoadon_hai);
            this.Controls.Add(this.txt_mahoadon_hai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_qlhoadon_hai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_qlhoadon_hai";
            this.Load += new System.EventHandler(this.frm_qlhoadon_hai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon_hai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahoadon_hai;
        private System.Windows.Forms.DataGridView dgv_hoadon_hai;
        private System.Windows.Forms.Button btn_xem_hai;
        private System.Windows.Forms.Button btn_quaylai_hai;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tkh;
    }
}