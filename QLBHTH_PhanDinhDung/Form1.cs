using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHTH_PhanDinhDung
{
    public partial class frm_dangnhap_dung : Form
    {
        public frm_dangnhap_dung()
        {
            InitializeComponent();
        }

        private void btn_dn_dung_Click(object sender, EventArgs e)
        {
            try
            {
                qlbh_dungDataContext dangnhap = new qlbh_dungDataContext();
                int mnv = int.Parse(txt_mnv_dung.Text.ToString());
                string password = txt_pass_dung.Text;
                var q = dangnhap.Nhanviens.Select(p => new { p.MaNV, p.Matkhau, p.Quyen }).Where(p => p.MaNV == mnv && p.Matkhau == password).SingleOrDefault();
                if (q != null)
                {
                    bool role = (bool)q.Quyen;
                    Program.role = role;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sai mã nhân viên hoặc mật khẩu", "Lỗi");
                }
            }
            catch (Exception)
            {
                lb_error_dung.Visible = true;
                lb_error_dung.Text = "Vui lòng nhập đầy đủ thông tin";
            }


        }

        private void btn_exit_dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
