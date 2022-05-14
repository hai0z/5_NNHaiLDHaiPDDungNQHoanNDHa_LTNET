namespace QLBHTH_PhanDinhDung
{
    partial class frm_qlmuahang_LDHai
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_quaylai_LDHai = new System.Windows.Forms.Button();
            this.txt_tk_LDHai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sl_LDHai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tsp_LDHai = new System.Windows.Forms.TextBox();
            this.txt_msp_LDHai = new System.Windows.Forms.TextBox();
            this.btn_them_LDHai = new System.Windows.Forms.Button();
            this.dgv_muahang_LDHai = new System.Windows.Forms.DataGridView();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_ttl_LDHai = new System.Windows.Forms.TextBox();
            this.txt_tkd_LDHai = new System.Windows.Forms.TextBox();
            this.txt_tt_LDHai = new System.Windows.Forms.TextBox();
            this.cbx_tkh_LDHai = new System.Windows.Forms.ComboBox();
            this.txt_mhd_LDHai = new System.Windows.Forms.TextBox();
            this.btn_xoa_LDHai = new System.Windows.Forms.Button();
            this.btn_lhd_LDHai = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_giohang_LDHai = new System.Windows.Forms.DataGridView();
            this.mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dataSet11 = new QLBHTH_PhanDinhDung.DataSet1();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muahang_LDHai)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giohang_LDHai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 581);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_quaylai_LDHai);
            this.tabPage1.Controls.Add(this.txt_tk_LDHai);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_sl_LDHai);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_tsp_LDHai);
            this.tabPage1.Controls.Add(this.txt_msp_LDHai);
            this.tabPage1.Controls.Add(this.btn_them_LDHai);
            this.tabPage1.Controls.Add(this.dgv_muahang_LDHai);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_quaylai_LDHai
            // 
            this.btn_quaylai_LDHai.Location = new System.Drawing.Point(656, 419);
            this.btn_quaylai_LDHai.Name = "btn_quaylai_LDHai";
            this.btn_quaylai_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_quaylai_LDHai.TabIndex = 11;
            this.btn_quaylai_LDHai.Text = "Quay lại";
            this.btn_quaylai_LDHai.UseVisualStyleBackColor = true;
            this.btn_quaylai_LDHai.Click += new System.EventHandler(this.btn_quaylai_LDHai_Click);
            // 
            // txt_tk_LDHai
            // 
            this.txt_tk_LDHai.Location = new System.Drawing.Point(883, 74);
            this.txt_tk_LDHai.Name = "txt_tk_LDHai";
            this.txt_tk_LDHai.Size = new System.Drawing.Size(192, 20);
            this.txt_tk_LDHai.TabIndex = 10;
            this.txt_tk_LDHai.TextChanged += new System.EventHandler(this.txt_tk_LDHai_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tìm kiếm sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // txt_sl_LDHai
            // 
            this.txt_sl_LDHai.Location = new System.Drawing.Point(117, 462);
            this.txt_sl_LDHai.Name = "txt_sl_LDHai";
            this.txt_sl_LDHai.Size = new System.Drawing.Size(192, 20);
            this.txt_sl_LDHai.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txt_tsp_LDHai
            // 
            this.txt_tsp_LDHai.Enabled = false;
            this.txt_tsp_LDHai.Location = new System.Drawing.Point(117, 421);
            this.txt_tsp_LDHai.Name = "txt_tsp_LDHai";
            this.txt_tsp_LDHai.Size = new System.Drawing.Size(192, 20);
            this.txt_tsp_LDHai.TabIndex = 3;
            // 
            // txt_msp_LDHai
            // 
            this.txt_msp_LDHai.Enabled = false;
            this.txt_msp_LDHai.Location = new System.Drawing.Point(117, 383);
            this.txt_msp_LDHai.Name = "txt_msp_LDHai";
            this.txt_msp_LDHai.Size = new System.Drawing.Size(192, 20);
            this.txt_msp_LDHai.TabIndex = 2;
            // 
            // btn_them_LDHai
            // 
            this.btn_them_LDHai.Location = new System.Drawing.Point(473, 419);
            this.btn_them_LDHai.Name = "btn_them_LDHai";
            this.btn_them_LDHai.Size = new System.Drawing.Size(75, 23);
            this.btn_them_LDHai.TabIndex = 1;
            this.btn_them_LDHai.Text = "Thêm";
            this.btn_them_LDHai.UseVisualStyleBackColor = true;
            this.btn_them_LDHai.Click += new System.EventHandler(this.btn_them_LDHai_Click);
            // 
            // dgv_muahang_LDHai
            // 
            this.dgv_muahang_LDHai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_muahang_LDHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muahang_LDHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.tenhang,
            this.dvt,
            this.soluong});
            this.dgv_muahang_LDHai.Location = new System.Drawing.Point(6, 120);
            this.dgv_muahang_LDHai.Name = "dgv_muahang_LDHai";
            this.dgv_muahang_LDHai.Size = new System.Drawing.Size(1098, 231);
            this.dgv_muahang_LDHai.TabIndex = 0;
            this.dgv_muahang_LDHai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_muahang_LDHai_CellClick);
            // 
            // mahang
            // 
            this.mahang.DataPropertyName = "Mahang";
            this.mahang.HeaderText = "Mã hàng";
            this.mahang.Name = "mahang";
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "Tenhang";
            this.tenhang.HeaderText = "Tên sản phẩm";
            this.tenhang.Name = "tenhang";
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "DVT";
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.Name = "dvt";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "Dongia";
            this.soluong.HeaderText = "Đơn giá";
            this.soluong.Name = "soluong";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_ttl_LDHai);
            this.tabPage2.Controls.Add(this.txt_tkd_LDHai);
            this.tabPage2.Controls.Add(this.txt_tt_LDHai);
            this.tabPage2.Controls.Add(this.cbx_tkh_LDHai);
            this.tabPage2.Controls.Add(this.txt_mhd_LDHai);
            this.tabPage2.Controls.Add(this.btn_xoa_LDHai);
            this.tabPage2.Controls.Add(this.btn_lhd_LDHai);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgv_giohang_LDHai);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giỏ hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_ttl_LDHai
            // 
            this.txt_ttl_LDHai.Location = new System.Drawing.Point(642, 174);
            this.txt_ttl_LDHai.Name = "txt_ttl_LDHai";
            this.txt_ttl_LDHai.Size = new System.Drawing.Size(239, 20);
            this.txt_ttl_LDHai.TabIndex = 16;
            // 
            // txt_tkd_LDHai
            // 
            this.txt_tkd_LDHai.Location = new System.Drawing.Point(642, 134);
            this.txt_tkd_LDHai.Name = "txt_tkd_LDHai";
            this.txt_tkd_LDHai.Size = new System.Drawing.Size(239, 20);
            this.txt_tkd_LDHai.TabIndex = 15;
            this.txt_tkd_LDHai.TextChanged += new System.EventHandler(this.txt_tkd_LDHai_TextChanged);
            // 
            // txt_tt_LDHai
            // 
            this.txt_tt_LDHai.Location = new System.Drawing.Point(642, 96);
            this.txt_tt_LDHai.Name = "txt_tt_LDHai";
            this.txt_tt_LDHai.ReadOnly = true;
            this.txt_tt_LDHai.Size = new System.Drawing.Size(239, 20);
            this.txt_tt_LDHai.TabIndex = 14;
            // 
            // cbx_tkh_LDHai
            // 
            this.cbx_tkh_LDHai.FormattingEnabled = true;
            this.cbx_tkh_LDHai.Location = new System.Drawing.Point(179, 134);
            this.cbx_tkh_LDHai.Name = "cbx_tkh_LDHai";
            this.cbx_tkh_LDHai.Size = new System.Drawing.Size(239, 21);
            this.cbx_tkh_LDHai.TabIndex = 12;
            // 
            // txt_mhd_LDHai
            // 
            this.txt_mhd_LDHai.Location = new System.Drawing.Point(179, 96);
            this.txt_mhd_LDHai.Name = "txt_mhd_LDHai";
            this.txt_mhd_LDHai.Size = new System.Drawing.Size(239, 20);
            this.txt_mhd_LDHai.TabIndex = 11;
            // 
            // btn_xoa_LDHai
            // 
            this.btn_xoa_LDHai.Location = new System.Drawing.Point(590, 264);
            this.btn_xoa_LDHai.Name = "btn_xoa_LDHai";
            this.btn_xoa_LDHai.Size = new System.Drawing.Size(148, 33);
            this.btn_xoa_LDHai.TabIndex = 9;
            this.btn_xoa_LDHai.Text = "Xoá";
            this.btn_xoa_LDHai.UseVisualStyleBackColor = true;
            this.btn_xoa_LDHai.Click += new System.EventHandler(this.btn_xoa_LDHai_Click);
            // 
            // btn_lhd_LDHai
            // 
            this.btn_lhd_LDHai.Location = new System.Drawing.Point(372, 264);
            this.btn_lhd_LDHai.Name = "btn_lhd_LDHai";
            this.btn_lhd_LDHai.Size = new System.Drawing.Size(148, 33);
            this.btn_lhd_LDHai.TabIndex = 8;
            this.btn_lhd_LDHai.Text = "Lập hoá đơn";
            this.btn_lhd_LDHai.UseVisualStyleBackColor = true;
            this.btn_lhd_LDHai.Click += new System.EventHandler(this.btn_lhd_LDHai_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tiền khách đưa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tổng tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tiền trả lại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã hoá đơn";
            // 
            // dgv_giohang_LDHai
            // 
            this.dgv_giohang_LDHai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_giohang_LDHai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_giohang_LDHai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mh,
            this.tsp,
            this.sl,
            this.dg,
            this.tt});
            this.dgv_giohang_LDHai.Location = new System.Drawing.Point(3, 332);
            this.dgv_giohang_LDHai.Name = "dgv_giohang_LDHai";
            this.dgv_giohang_LDHai.Size = new System.Drawing.Size(1103, 217);
            this.dgv_giohang_LDHai.TabIndex = 1;
            this.dgv_giohang_LDHai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_giohang_LDHai_CellClick);
            // 
            // mh
            // 
            this.mh.HeaderText = "Mã hàng";
            this.mh.Name = "mh";
            // 
            // tsp
            // 
            this.tsp.HeaderText = "Tên sản phẩm";
            this.tsp.Name = "tsp";
            // 
            // sl
            // 
            this.sl.HeaderText = "Số lượng";
            this.sl.Name = "sl";
            // 
            // dg
            // 
            this.dg.HeaderText = "Đơn giá";
            this.dg.Name = "dg";
            // 
            // tt
            // 
            this.tt.HeaderText = "Tổng tiền";
            this.tt.Name = "tt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "GIỎ HÀNG";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_qlmuahang_LDHai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_qlmuahang_LDHai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_qlmuahang_LDHai";
            this.Load += new System.EventHandler(this.frm_qlmuahang_LDHai_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muahang_LDHai)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_giohang_LDHai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button btn_quaylai_LDHai;
        private System.Windows.Forms.TextBox txt_tk_LDHai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sl_LDHai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tsp_LDHai;
        private System.Windows.Forms.TextBox txt_msp_LDHai;
        private System.Windows.Forms.Button btn_them_LDHai;
        private System.Windows.Forms.DataGridView dgv_muahang_LDHai;
        private System.Windows.Forms.TextBox txt_ttl_LDHai;
        private System.Windows.Forms.TextBox txt_tkd_LDHai;
        private System.Windows.Forms.TextBox txt_tt_LDHai;
        private System.Windows.Forms.ComboBox cbx_tkh_LDHai;
        private System.Windows.Forms.TextBox txt_mhd_LDHai;
        private System.Windows.Forms.Button btn_xoa_LDHai;
        private System.Windows.Forms.Button btn_lhd_LDHai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_giohang_LDHai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
    }
}