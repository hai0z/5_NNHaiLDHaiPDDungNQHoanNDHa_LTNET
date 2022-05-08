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
    public partial class frm_qlkh_LDHai : Form
    {
        public frm_qlkh_LDHai()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txt_mkh_LDHai.Clear();
            txt_tkh_LDHai.Clear();
            txt_dc_LDHai.Clear();
            txt_quan_LDHai.Clear();
            txt_tp_LDHai.Clear();
        }
        private void load()
        {
            qlbh_dungDataContext qlkh = new qlbh_dungDataContext();
            var kh = qlkh.Khachhangs.Select(p => p);
            dgv_qlkh_LDHai.DataSource = kh;
            
        }
        private void frm_qlkh_LDHai_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btn_them_LDHai_Click(object sender, EventArgs e)
        {
            try
            {
                qlbh_dungDataContext qlkh = new qlbh_dungDataContext();
                Khachhang kh = new Khachhang();
                string mkh = txt_mkh_LDHai.Text;
                string tenkh = txt_tkh_LDHai.Text;
                string dc = txt_dc_LDHai.Text;
                string quan = txt_quan_LDHai.Text;
                string tp = txt_tp_LDHai.Text;
                if (mkh == "" || tenkh == "" || dc == "" || quan == "" || tp == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                } else
                {
                    kh.MaKH = mkh;
                    kh.TenKH = tenkh;
                    kh.Diachi = dc;
                    kh.Quan = quan;
                    kh.ThanhPho = tp;
                    qlkh.Khachhangs.InsertOnSubmit(kh);
                    qlkh.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    load();
                }
                } catch(Exception ex)
            {
                MessageBox.Show("Trùng mã khách hàng.", "Thông báo");
            }
        }

        private void btn_ql_LDHai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_giaodienchinh_ha gdc = new frm_giaodienchinh_ha();
            gdc.ShowDialog();
        }

        private void btn_nhaplai_LDHai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgv_qlkh_LDHai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int i = dgv_qlkh_LDHai.CurrentRow.Index;
                txt_mkh_LDHai.Text = dgv_qlkh_LDHai.Rows[i].Cells[0].Value.ToString();
                txt_tkh_LDHai.Text = dgv_qlkh_LDHai.Rows[i].Cells[1].Value.ToString();
                txt_dc_LDHai.Text = dgv_qlkh_LDHai.Rows[i].Cells[2].Value.ToString();
                txt_quan_LDHai.Text = dgv_qlkh_LDHai.Rows[i].Cells[3].Value.ToString();
                txt_tp_LDHai.Text = dgv_qlkh_LDHai.Rows[i].Cells[4].Value.ToString();
            } catch (Exception ex)
            {
            }
        }

        private void btn_xoa_LDHai_Click(object sender, EventArgs e)
        {
            try
            {
                qlbh_dungDataContext qlkh = new qlbh_dungDataContext();
                string mkh = txt_mkh_LDHai.Text;
                var kh = qlkh.Khachhangs.Where(p => p.MaKH == mkh).FirstOrDefault();
                qlkh.Khachhangs.DeleteOnSubmit(kh);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                qlkh.SubmitChanges();
                clear();
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
            }

        }

        private void btn_sua_LDHai_Click(object sender, EventArgs e)
        {
            try
            {
                qlbh_dungDataContext qlkh = new qlbh_dungDataContext();
                string mkh = txt_mkh_LDHai.Text;
                string tenkh = txt_tkh_LDHai.Text;
                string dc = txt_dc_LDHai.Text;
                string quan = txt_quan_LDHai.Text;
                string tp = txt_tp_LDHai.Text;
                if (mkh == "" || tenkh == "" || dc == "" || quan == "" || tp == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                } else
                {
                    var kh = qlkh.Khachhangs.Where(p => p.MaKH == mkh).FirstOrDefault();
                    kh.MaKH = txt_mkh_LDHai.Text;
                    kh.TenKH = txt_tkh_LDHai.Text;
                    kh.Diachi = txt_dc_LDHai.Text;
                    kh.Quan = txt_quan_LDHai.Text;
                    kh.ThanhPho = txt_tp_LDHai.Text;
                    qlkh.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    clear();
                    load();
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void frm_qlkh_LDHai_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
