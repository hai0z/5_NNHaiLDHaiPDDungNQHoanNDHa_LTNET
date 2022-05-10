using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLBHTH_PhanDinhDung
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLBHTH_PhanDinhDung.Report1.rdlc";

            //load data source
            qlbh_dungDataContext qlbh = new qlbh_dungDataContext();
            var ds = qlbh.Hanghoas.Select(x => x).Join(qlbh.CT_Hoadons, hh => hh.Mahang, cthd => cthd.Mahang, (hh, cthd) => new
            {

                cthd.Soluong,
                hh.Tenhang,
                cthd.Dongiaban,
                cthd.SoHD,
            }).Join(qlbh.Hoadons, hh => hh.SoHD, hd => hd.SoHD, (hh, hd) => new {hh.Tenhang, hd.Ngayban,hd.MaNV,hd.MaKH });
                ReportDataSource rds = new ReportDataSource("DataSet1", ds);
            foreach (var item in ds)
            {
                Console.WriteLine(item.Tenhang);
            }
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

        }
    }
}
