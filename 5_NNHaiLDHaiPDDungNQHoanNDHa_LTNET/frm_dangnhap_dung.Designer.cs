namespace QLBHTH_PhanDinhDung
{
    partial class frm_dangnhap_dung
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
            this.lb_mnv_dung = new System.Windows.Forms.Label();
            this.lb_mk_dung = new System.Windows.Forms.Label();
            this.btn_dn_dung = new System.Windows.Forms.Button();
            this.btn_exit_dung = new System.Windows.Forms.Button();
            this.txt_mnv_dung = new System.Windows.Forms.TextBox();
            this.txt_pass_dung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_error_dung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_mnv_dung
            // 
            this.lb_mnv_dung.AutoSize = true;
            this.lb_mnv_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mnv_dung.Location = new System.Drawing.Point(168, 130);
            this.lb_mnv_dung.Name = "lb_mnv_dung";
            this.lb_mnv_dung.Size = new System.Drawing.Size(103, 20);
            this.lb_mnv_dung.TabIndex = 0;
            this.lb_mnv_dung.Text = "Hải đẹp trai";
            // 
            // lb_mk_dung
            // 
            this.lb_mk_dung.AutoSize = true;
            this.lb_mk_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk_dung.Location = new System.Drawing.Point(168, 197);
            this.lb_mk_dung.Name = "lb_mk_dung";
            this.lb_mk_dung.Size = new System.Drawing.Size(79, 20);
            this.lb_mk_dung.TabIndex = 1;
            this.lb_mk_dung.Text = "Mật khẩu ";
            // 
            // btn_dn_dung
            // 
            this.btn_dn_dung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dn_dung.Location = new System.Drawing.Point(289, 271);
            this.btn_dn_dung.Name = "btn_dn_dung";
            this.btn_dn_dung.Size = new System.Drawing.Size(75, 23);
            this.btn_dn_dung.TabIndex = 2;
            this.btn_dn_dung.Text = "Đăng nhập";
            this.btn_dn_dung.UseVisualStyleBackColor = true;
            this.btn_dn_dung.Click += new System.EventHandler(this.btn_dn_dung_Click);
            // 
            // btn_exit_dung
            // 
            this.btn_exit_dung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit_dung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit_dung.Location = new System.Drawing.Point(464, 271);
            this.btn_exit_dung.Name = "btn_exit_dung";
            this.btn_exit_dung.Size = new System.Drawing.Size(75, 23);
            this.btn_exit_dung.TabIndex = 3;
            this.btn_exit_dung.Text = "Thoát";
            this.btn_exit_dung.UseVisualStyleBackColor = true;
            this.btn_exit_dung.Click += new System.EventHandler(this.btn_exit_dung_Click);
            // 
            // txt_mnv_dung
            // 
            this.txt_mnv_dung.Location = new System.Drawing.Point(289, 130);
            this.txt_mnv_dung.Multiline = true;
            this.txt_mnv_dung.Name = "txt_mnv_dung";
            this.txt_mnv_dung.Size = new System.Drawing.Size(250, 25);
            this.txt_mnv_dung.TabIndex = 4;
            // 
            // txt_pass_dung
            // 
            this.txt_pass_dung.Location = new System.Drawing.Point(289, 196);
            this.txt_pass_dung.Multiline = true;
            this.txt_pass_dung.Name = "txt_pass_dung";
            this.txt_pass_dung.PasswordChar = '*';
            this.txt_pass_dung.Size = new System.Drawing.Size(250, 25);
            this.txt_pass_dung.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG TẠP HÓA";
            // 
            // lb_error_dung
            // 
            this.lb_error_dung.AutoSize = true;
            this.lb_error_dung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_dung.ForeColor = System.Drawing.Color.Red;
            this.lb_error_dung.Location = new System.Drawing.Point(289, 239);
            this.lb_error_dung.Name = "lb_error_dung";
            this.lb_error_dung.Size = new System.Drawing.Size(51, 20);
            this.lb_error_dung.TabIndex = 7;
            this.lb_error_dung.Text = "label2";
            this.lb_error_dung.Visible = false;
            // 
            // frm_dangnhap_dung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_error_dung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass_dung);
            this.Controls.Add(this.txt_mnv_dung);
            this.Controls.Add(this.btn_exit_dung);
            this.Controls.Add(this.btn_dn_dung);
            this.Controls.Add(this.lb_mk_dung);
            this.Controls.Add(this.lb_mnv_dung);
            this.Name = "frm_dangnhap_dung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập _ Phan Đình Dũng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_mnv_dung;
        private System.Windows.Forms.Label lb_mk_dung;
        private System.Windows.Forms.Button btn_dn_dung;
        private System.Windows.Forms.Button btn_exit_dung;
        private System.Windows.Forms.TextBox txt_mnv_dung;
        private System.Windows.Forms.TextBox txt_pass_dung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_error_dung;
    }
}

