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
    public partial class frm_qldoanhthu_hai : Form
    {
        public frm_qldoanhthu_hai()
        {
            InitializeComponent();
        }

        private void load(DateTime date)
        {
            qlbh_dungDataContext qlbh = new qlbh_dungDataContext();
            var ds = qlbh.CT_Hoadons.Select(nhanvien => new
            {
                nhanvien.Hoadon.Nhanvien.TenNV,
                nhanvien.Hoadon.Nhanvien.MaNV,
                nhanvien.Hoadon.Ngayban,
                Thanhtien = nhanvien.Soluong * nhanvien.Dongiaban

            }).Where(nv => nv.Ngayban == date);

            var doanhthu = ds.GroupBy(x => x.MaNV).SelectMany(y => y.Select(z => new
            {
                TenNV = z.TenNV,
                MaNV = z.MaNV,
                tongtien = y.Sum(s=> s.Thanhtien),
            })).Distinct();

            if(doanhthu.ToArray().Length == 0)
            {

                label3.Visible = true;
                label3.Text = "Chưa có doanh thu";
                label4.Visible = false;
                dgv_doanhthu_hai.Visible = false;
            }
            else
            {
                int tongtien = 0;
                foreach(var item in doanhthu)
                {
                    tongtien += int.Parse(item.tongtien.ToString());
                }
                dgv_doanhthu_hai.DataSource = doanhthu;
                dgv_doanhthu_hai.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                label4.Text = $"Tổng doanh thu: {tongtien}";
            }
        }
        private void btn_xem_hai_Click(object sender, EventArgs e)
        {
            load(dtp_ngay_hai.Value);
        }

        private void frm_qldoanhthu_hai_Load(object sender, EventArgs e)
        {
            load(DateTime.Now);
        }

        private void btn_quaylai_hai_Click(object sender, EventArgs e)
        {
            Hide();
            frm_giaodienchinh_ha gdc = new frm_giaodienchinh_ha();
            gdc.ShowDialog();
        }
    }
}
