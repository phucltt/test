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
    public partial class formchucnang : Form
    {
        public formchucnang()
        {
            InitializeComponent();
            // Disabling the minimize, maximize, and close buttons
            this.ControlBox = false;
        }

        private void formchucnang_Load(object sender, EventArgs e)
        {
            // You could load any initial settings here if needed
        }

        private void buttonthongtinsach_Click(object sender, EventArgs e)
        {
            formthongtinsach formThongTinSach = new formthongtinsach(this);
            formThongTinSach.Show();
            this.Hide();
        }

        private void buttonnhacungcap_Click(object sender, EventArgs e)
        {
            formnhacungcap formNhaCungCap = new formnhacungcap(this);
            formNhaCungCap.Show();
            this.Hide(); // Ẩn form chức năng hiện tại
        }

        private void buttonkhachhang_Click(object sender, EventArgs e)
        {
            formkhachhang formKhachHang = new formkhachhang(this);
            formKhachHang.Show();
            this.Hide(); // Ẩn form chức năng hiện tại
        }

        private void buttonthongkebaocao_Click(object sender, EventArgs e)
        {
            formthongkebaocao formThongKeBaoCao = new formthongkebaocao(this);
            formThongKeBaoCao.Show();
            this.Hide(); // Ẩn form chức năng hiện tại
        }

        private void buttondanhmucsach_Click(object sender, EventArgs e)
        {
            formdanhmucsach formDanhMucSach = new formdanhmucsach(this);
            formDanhMucSach.Show();
            this.Hide(); // Ẩn form chức năng hiện tại
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close(); // This closes the current form, which could be the application if this is the main form.
        }
    }
}
