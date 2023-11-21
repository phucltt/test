using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuoiKi
{
    public partial class formdanhmucsach : Form
    {

        private Form formchucnang;

        public formdanhmucsach(Form formchucnang)
        {
            InitializeComponent();
            this.formchucnang = formchucnang; // Lưu tham chiếu
            this.ControlBox = false;
        }

        private void txtthongtinloaisach_Click(object sender, EventArgs e)
        {

        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboboxchonloaisach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttuadedanhmucsach_Click(object sender, EventArgs e)
        {

        }

        private void formdanhmucsach_Load(object sender, EventArgs e)
        {
            {
                // Tạo một danh sách các loại sách
                List<string> loaiSach = new List<string> { "Công nghệ thông tin & lịch sử", "Thiếu nhi", "Chính trị" };

                // Thêm các loại sách vào ComboBox
                foreach (var loai in loaiSach)
                {
                    comboboxchonloaisach.Items.Add(loai);
                }

                // Nếu bạn muốn chọn một mục mặc định
                comboboxchonloaisach.SelectedIndex = 0; // Chọn mục đầu tiên trong danh sách
            }
        }

        private void txtchonloaisach_Click(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            // Giả sử bạn có một form để nhập thông tin sách, hoặc bạn có thể thêm trực tiếp giả dữ liệu
            string maSach = "MS001"; // Giả sử đây là mã sách được nhập
            string tenSach = "Tên Sách"; // Giả sử đây là tên sách được nhập
            string theLoai = comboboxchonloaisach.SelectedItem.ToString(); // Lấy thể loại từ combobox
            string donGia = "50000"; // Giả sử đây là đơn giá được nhập
            string soLuongCon = "10"; // Giả sử đây là số lượng còn được nhập

            // Tạo một mảng chứa thông tin sách
            string[] row = { maSach, tenSach, theLoai, donGia, soLuongCon };

            // Thêm mảng dữ liệu vào DataGridView (đặt tên là datagridview trong ví dụ này)
            datagridview.Rows.Add(row);
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            // Thay đổi nội dung phương thức này để ẩn form hiện tại và hiển thị formchucnang
            this.Hide();
            formchucnang.Show();
        }
    }
}
