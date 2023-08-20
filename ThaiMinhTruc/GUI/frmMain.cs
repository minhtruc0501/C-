using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiMinhTruc.DAL;
 

namespace ThaiMinhTruc.GUI
{
    public partial class frmMain : Form
    {
        public object Class { get; private set; }

        public frmMain()
        {
            InitializeComponent();
        }

        

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMChatLieu frmDMChatLieu = new FrmDMChatLieu();
            frmDMChatLieu.ShowDialog();
        }

        

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmDMNhanVien frmDMNhanVien = new FrmDMNhanVien();
            frmDMNhanVien.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FrmDMKhachHang frmDMKhachHang  = new FrmDMKhachHang();
            frmDMKhachHang.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            FrmDMHangHoa frm = new FrmDMHangHoa();
            
            frm.ShowDialog();
        }

        

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDonBan frmHoaDonBan = new FrmHoaDonBan();
            frmHoaDonBan.ShowDialog();
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frmTimKiemHD = new frmTimKiemHD();
            frmTimKiemHD.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

       
    }
}
