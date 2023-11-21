using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuoiKi
{
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
            // Special requirement implementation:
            this.ControlBox = false; // This hides the minimize, maximize, and close buttons.
        }

        private void formdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtdangnhap_Click(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_Click(object sender, EventArgs e)
        {

        }

        private void textboxtendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void textboxmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttondongy_Click(object sender, EventArgs e)
        {
            if (textboxtendangnhap.Text == "admin" && textboxmatkhau.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                formchucnang form2 = new formchucnang();
                this.Hide();
                form2.ShowDialog(); // Modal, will block further code execution until it's closed
                                    // this.Show(); // Remove this line to prevent the login form from showing again after closing formchucnang
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại!");
            }
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            textboxtendangnhap.Clear();
            textboxmatkhau.Clear();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
