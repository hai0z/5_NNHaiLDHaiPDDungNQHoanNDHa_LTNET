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
    public partial class frm_qlhh_LDHai : Form
    {
        public frm_qlhh_LDHai()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txt_mh_LDHai.Clear();
            cb_lh_LDHai.SelectedIndex = -1;
            txt_th_LDHai.Clear();
            txt_dvt_LDHai.Clear();
            txt_dg_LDHai.Clear();
        }
        private void load() {
            qlbh_dungDataContext qlhh = new qlbh_dungDataContext();
            var mh = qlhh.Hanghoas.Select(p => new {p.Mahang,p.Tenhang,p.Loaihang1.Tenloai,p.DVT,p.Dongia});
            dgv_qlhh_LDHai.DataSource = mh;
            cb_lh_LDHai.DataSource = qlhh.Loaihangs.Select(p => p);
            cb_lh_LDHai.DisplayMember = "Tenloai";
            cb_lh_LDHai.ValueMember = "Maloai";
        }
        private void frm_qlhh_LDHai_Load(object sender, EventArgs e)
        {
            load();
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

        private void btn_them_LDHai_Click(object sender, EventArgs e)
        {
            try
            {
                qlbh_dungDataContext qlhh = new qlbh_dungDataContext();
                Hanghoa hh = new Hanghoa();
                string mh = txt_mh_LDHai.Text;
                string lh = cb_lh_LDHai.SelectedValue.ToString();
                string th = txt_th_LDHai.Text;
                string dvt = txt_dvt_LDHai.Text;
                string dg = txt_dg_LDHai.Text;
                if (mh == "" || th == "" || dvt == "" || dg == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    hh.Mahang = mh;
                    hh.Loaihang = lh;
                    hh.Tenhang = th;
                    hh.DVT = dvt;
                    hh.Dongia = int.Parse(dg);
                    qlhh.Hanghoas.InsertOnSubmit(hh);
                    qlhh.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    clear();
                    load();
                }
            } catch (Exception)
            {
                MessageBox.Show("Trùng mã hàng", "Thông báo");
            }
        }

        private void dgv_qlhh_LDHai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dgv_qlhh_LDHai.CurrentRow.Index;
                txt_mh_LDHai.Text = dgv_qlhh_LDHai.Rows[i].Cells[0].Value.ToString();
                txt_th_LDHai.Text = dgv_qlhh_LDHai.Rows[i].Cells[1].Value.ToString();
                cb_lh_LDHai.Text = dgv_qlhh_LDHai.Rows[i].Cells[2].Value == null ? "" : dgv_qlhh_LDHai.Rows[i].Cells[2].Value.ToString();
                txt_dvt_LDHai.Text = dgv_qlhh_LDHai.Rows[i].Cells[3].Value.ToString();
                txt_dg_LDHai.Text = dgv_qlhh_LDHai.Rows[i].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btn_xoa_LDHai_Click(object sender, EventArgs e)
        {
            try
            {
                qlbh_dungDataContext qlhh = new qlbh_dungDataContext();
                string mh = txt_mh_LDHai.Text;
                var hh = qlhh.Hanghoas.Where(p => p.Mahang == mh).FirstOrDefault();
                qlhh.Hanghoas.DeleteOnSubmit(hh);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                qlhh.SubmitChanges();
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
                string mh = txt_mh_LDHai.Text;
                string lh = cb_lh_LDHai.SelectedValue.ToString();
                string th = txt_th_LDHai.Text;
                string dvt = txt_dvt_LDHai.Text;
                string dg = txt_dg_LDHai.Text;
                if (mh == "" || th == "" || dvt == "" || dg == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
                else
                {
                    var hh = qlkh.Hanghoas.Where(p => p.Mahang == mh).FirstOrDefault();
                    hh.Mahang = mh;
                    hh.Loaihang = lh;
                    hh.Tenhang = th;
                    hh.DVT = dvt;
                    hh.Dongia = int.Parse(dg);
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
    }
}
