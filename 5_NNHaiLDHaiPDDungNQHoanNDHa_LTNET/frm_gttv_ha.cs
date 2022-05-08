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
    public partial class frm_gttv_ha : Form
    {
        public frm_gttv_ha()
        {
            InitializeComponent();
        }

        private void frm_gttv_ha_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_giaodienchinh_ha main_form = new frm_giaodienchinh_ha();
            main_form.ShowDialog();
        }
    }
}
