using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiMinhTruc.GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThaiMinhTruc
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-QHN6DLG;Initial Catalog=Quanlybanhang2;User ID=sa;Password=sa");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From TaiKhoan where TaiKhoan='" + tbLogin.Text + "'and MatKhau='" + tbPassword.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                frmMain f = new frmMain();
                f.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui nhập đầy đủ tài khoản mật khẩu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDMNhanVien frmDMNhanVien = new FrmDMNhanVien();
            frmDMNhanVien.ShowDialog();
        }
    }
    
}
