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
    public partial class frm_qlnv_hai : Form
    {
        public frm_qlnv_hai()
        {
            InitializeComponent();
        }

        private void load()
        {
            qlbh_dungDataContext qlnv = new qlbh_dungDataContext();
            var nhanvienList = qlnv.Nhanviens.Select(nv => new {
                nv.MaNV,
                nv.TenNV,
                nv.Diachi,
                nv.Matkhau,
                Quyen = nv.Quyen == true ? "Quản lý" : "Nhân viên"
            }).ToList();
            dgv_nv_hai.DataSource = nhanvienList;
        }
        private void frm_qlnv_hai_Load(object sender, EventArgs e)
        {
            load();
            cb_quyen_hai.SelectedIndex = 0;
        }

        private void btn_them_hai_Click(object sender, EventArgs e)
        {
            qlbh_dungDataContext qlnv = new qlbh_dungDataContext();
            Nhanvien nv = new Nhanvien();
            string manv = txt_mnv_hai.Text.ToString();
            string hoten = txt_tennv_hai.Text.ToString();
            string dc = txt_dc_hai.Text.ToString();
            string mk = txt_mk_hai.Text.ToString();
            string quyen = cb_quyen_hai.SelectedItem.ToString();
            bool q;
            if(quyen == "Nhân viên")
            {
                q = false;
            }
            else
            {
                q = true;
            }
            if(manv.Trim() == "" || hoten.Trim() ==" "|| dc.Trim() ==""|| mk.Trim() =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                nv.MaNV = manv;
                nv.TenNV = hoten;
                nv.Diachi = dc;
                nv.Matkhau = mk;
                nv.Quyen = q;
                qlnv.Nhanviens.InsertOnSubmit(nv);
                qlnv.SubmitChanges();
                MessageBox.Show("Thêm thành công ", "Thông báo");
                load();
            }

        }

        private void cb_quyen_hai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_sua_hai_Click(object sender, EventArgs e)
        {
            qlbh_dungDataContext qlnv = new qlbh_dungDataContext();
            string manv = txt_mnv_hai.Text.ToString();
            Nhanvien nv = qlnv.Nhanviens.Select(nhanvien => nhanvien).Where(nhanvien => nhanvien.MaNV.Equals(manv)).SingleOrDefault();
            string hoten = txt_tennv_hai.Text.ToString();
            string dc = txt_dc_hai.Text.ToString();
            string mk = txt_mk_hai.Text.ToString();
            string quyen = cb_quyen_hai.SelectedItem.ToString();
            bool q;
            if (quyen == "Nhân viên")
            {
                q = false;
            }
            else
            {
                q = true;
            }
            if (manv.Trim() == "" || hoten.Trim() == " " || dc.Trim() == "" || mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");

            }
            else
            {
                nv.MaNV = manv;
                nv.TenNV = hoten;
                nv.Diachi = dc;
                nv.Matkhau = mk;
                nv.Quyen = q;
                qlnv.SubmitChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                load();
            }
        }

        private void dgv_nv_hai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_nv_hai.CurrentRow.Index;
            txt_mnv_hai.Text = dgv_nv_hai.Rows[i].Cells[0].Value.ToString();
            txt_tennv_hai.Text = dgv_nv_hai.Rows[i].Cells[1].Value.ToString();
            txt_dc_hai.Text = dgv_nv_hai.Rows[i].Cells[2].Value.ToString();
            txt_mk_hai.Text = dgv_nv_hai.Rows[i].Cells[3].Value.ToString();
            var quyen = dgv_nv_hai.Rows[i].Cells[4].Value.ToString();
            if(quyen == "Nhân viên")
            {
                cb_quyen_hai.SelectedIndex = 0;
            }
            else
            {
                cb_quyen_hai.SelectedIndex = 1;
            }

        }

        private void btn_xoa_hai_Click(object sender, EventArgs e)
        {
            qlbh_dungDataContext qlnv = new qlbh_dungDataContext();
            string manv = txt_mnv_hai.Text.ToString();
            Nhanvien nv = qlnv.Nhanviens.Select(nhanvien => nhanvien).Where(nhanvien => nhanvien.MaNV.Equals(manv)).SingleOrDefault();
            if(nv!= null)
            {
                qlnv.Nhanviens.DeleteOnSubmit(nv);
                qlnv.SubmitChanges();
                MessageBox.Show("Xoá thành công", "Thông báo");
                load();
                btn_nhapLai_hai_Click(sender, e);
            }
        }

        private void btn_nhapLai_hai_Click(object sender, EventArgs e)
        {
            txt_dc_hai.Clear();
            txt_mk_hai.Clear();
            txt_mnv_hai.Clear();
            txt_tennv_hai.Clear();
            cb_quyen_hai.SelectedIndex = -1;
        }

        private void btn_quaylai_hai_Click(object sender, EventArgs e)
        {
            Hide();
            frm_giaodienchinh_ha gdc = new frm_giaodienchinh_ha();
            gdc.ShowDialog();
        }


    }
}
