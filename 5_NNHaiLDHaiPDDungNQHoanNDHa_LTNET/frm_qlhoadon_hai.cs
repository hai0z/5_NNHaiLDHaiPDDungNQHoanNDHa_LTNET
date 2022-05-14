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
    public partial class frm_qlhoadon_hai : Form
    {
        public frm_qlhoadon_hai()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void load()
        {
            qlbh_dungDataContext qlbh = new qlbh_dungDataContext();
            var hoadon = qlbh.Hoadons.Select(hd => new { hd.SoHD, hd.Ngayban, hd.Nhanvien.TenNV, hd.Khachhang.TenKH });
            dgv_hoadon_hai.DataSource = hoadon;
        }
        private void btn_xem_hai_Click(object sender, EventArgs e)
        {
            frm_hoadon_hai hd = new frm_hoadon_hai(txt_mahoadon_hai.Text);
            hd.ShowDialog();
        }

        private void frm_qlhoadon_hai_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_quaylai_hai_Click(object sender, EventArgs e)
        {
            Hide();
            frm_giaodienchinh_ha gdc = new frm_giaodienchinh_ha(); ;
            gdc.ShowDialog();
        }

        private void dgv_hoadon_hai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_hoadon_hai.CurrentRow.Index;
            txt_mahoadon_hai.Text = dgv_hoadon_hai.Rows[i].Cells[0].Value.ToString();
        }
    }
}
