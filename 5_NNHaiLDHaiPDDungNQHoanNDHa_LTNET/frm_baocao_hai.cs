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
    public partial class frm_baocao_hai : Form
    {
        public frm_baocao_hai()
        {
            InitializeComponent();
        }

        private void frm_baocao_hai_Load(object sender, EventArgs e)
        {

            this.rp_baocao_hai.RefreshReport();
        }

        private void rp_baocao_hai_Load(object sender, EventArgs e)
        {
            rp_baocao_hai.LocalReport.ReportEmbeddedResource = "QLBHTH_PhanDinhDung.rp_baocao_hai.rdlc";
            qlbh_dungDataContext qlbh = new qlbh_dungDataContext();
            var ds = qlbh.CT_Hoadons.Select(hd => new
            {
                hd.Mahang,
                hd.Hanghoa.Tenhang,
                hd.Dongiaban,
                hd.Soluong,
                hd.SoHD,
                Thanhtien = hd.Dongiaban * hd.Soluong
            }) ;
            ReportDataSource rds = new ReportDataSource("DataSet1", ds);
            rp_baocao_hai.LocalReport.DataSources.Add(rds);
            rp_baocao_hai.RefreshReport();
        }

        private void frm_baocao_hai_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            frm_giaodienchinh_ha gdc = new frm_giaodienchinh_ha(); ;
            gdc.ShowDialog();
        }
    }
}
