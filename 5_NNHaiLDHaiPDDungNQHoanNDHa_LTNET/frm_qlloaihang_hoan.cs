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
    public partial class frm_qlloaihang_hoan : Form
    {
        public frm_qlloaihang_hoan()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            qlbh_dungDataContext qllh = new qlbh_dungDataContext();
            var lh = qllh.Loaihangs.Select(p => p);
            dgv_loaihang_hoan.DataSource = lh;
        }
        private void btn_them_hoan_Click(object sender, EventArgs e)
        {
            qlbh_dungDataContext qllh = new qlbh_dungDataContext();
            string maloaihang = txt_mahang_hoan.Text;
            string tenhang = txt_tenhang_hoan.Text;
            if(maloaihang.Trim()== "" || tenhang.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                try
                {
                    Loaihang loaihang = new Loaihang();
                    loaihang.Maloai = maloaihang;
                    loaihang.Tenloai = tenhang;
                    qllh.Loaihangs.InsertOnSubmit(loaihang);
                    qllh.SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loaddata();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void frm_qlloaihang_hoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgv_loaihang_hoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_loaihang_hoan.CurrentRow.Index;
            txt_mahang_hoan.Text = dgv_loaihang_hoan.Rows[i].Cells[0].Value.ToString();
            txt_tenhang_hoan.Text = dgv_loaihang_hoan.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_sua_hoan_Click(object sender, EventArgs e)
        {
            qlbh_dungDataContext qllh = new qlbh_dungDataContext();
            var loaihang = qllh.Loaihangs.Select(lh => lh).Where(lh => lh.Maloai.Equals(txt_mahang_hoan.Text)).SingleOrDefault();
            if(loaihang != null)
            {
                loaihang.Maloai = txt_mahang_hoan.Text;
                loaihang.Tenloai = txt_tenhang_hoan.Text;
                qllh.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                loaddata();
            }
        }
        private void btn_nhaplai_hoan_Click(object sender, EventArgs e)
        {
            txt_mahang_hoan.Clear();
            txt_tenhang_hoan.Clear();
        }
        private void btn_xoa_hoan_Click(object sender, EventArgs e)
        {
            qlbh_dungDataContext qllh = new qlbh_dungDataContext();
            var loaihang = qllh.Loaihangs.Select(lh => lh).Where(lh => lh.Maloai.Equals(txt_mahang_hoan.Text)).SingleOrDefault();
            if( loaihang != null)
            {
                qllh.Loaihangs.DeleteOnSubmit(loaihang);
                qllh.SubmitChanges();
                MessageBox.Show("Xoá thành công", "Thông báo");
                loaddata();
                btn_nhaplai_hoan_Click(sender,e);
            }
        }

        private void btn_quaylai_hoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_giaodienchinh_ha gdc = new frm_giaodienchinh_ha();
            gdc.ShowDialog();
        }
    }
}
