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
    public partial class frm_giaodienchinh_ha : Form
    {
        public frm_giaodienchinh_ha()
        {
            InitializeComponent();
        }

        private void btn_gttv_ha_Click(object sender, EventArgs e)
        {
            frm_gttv_ha gttv = new frm_gttv_ha();
            this.Hide();
            gttv.ShowDialog();
        }
    }
}
