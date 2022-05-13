using Microsoft.Reporting.WinForms;
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
    public partial class frm_hoadon_hai : Form
    {
        public frm_hoadon_hai()
        {
            InitializeComponent();
        }
        string mahoadon;
        public frm_hoadon_hai(string mahoadon)
        {
            this.mahoadon = mahoadon;
            InitializeComponent();
        }
        private void frm_hoadon_hai_Load(object sender, EventArgs e)
        {

            this.rpv_hoadon_hai.RefreshReport();
        }

        private void rpv_hoadon_hai_Load(object sender, EventArgs e)
        {
            rpv_hoadon_hai.LocalReport.ReportEmbeddedResource = "QLBHTH_PhanDinhDung.rp_hoadon_hai.rdlc";
            qlbh_dungDataContext qlbh = new qlbh_dungDataContext();
            var ds = qlbh.CT_Hoadons.Select(cthd => new
            {
                cthd.SoHD,
                cthd.Hanghoa.Tenhang,
                cthd.Soluong,
                cthd.Dongiaban,
                cthd.Hoadon.Ngayban,
                cthd.Hoadon.Khachhang.TenKH,
                cthd.Hanghoa.DVT,
                cthd.Hoadon.Nhanvien.TenNV,
                Thanhtien = cthd.Soluong * cthd.Dongiaban
            }).Where(hd => hd.SoHD == mahoadon);
            ReportDataSource rds = new ReportDataSource("DataSet1", ds);
            rpv_hoadon_hai.LocalReport.DataSources.Add(rds);
        }
    }
}
