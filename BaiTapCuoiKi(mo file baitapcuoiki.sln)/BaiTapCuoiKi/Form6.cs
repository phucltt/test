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
    public partial class formthongkebaocao : Form
    {
        private Form formchucnang;

        public formthongkebaocao(Form formchucnang)
        {
            InitializeComponent();
            this.formchucnang = formchucnang; // Lưu tham chiếu
            this.ControlBox = false;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtthongkebanchay_Click(object sender, EventArgs e)
        {

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            // Tạo một mảng hoặc danh sách chứa dữ liệu tạm thời
            // Dữ liệu này sẽ được thay thế bằng dữ liệu thực từ các form khác trong ứng dụng của bạn
            var danhSachThongKe = new List<Tuple<string, string, string, decimal, int, decimal>>
    {
        // Giả sử thêm một số dữ liệu mẫu
        Tuple.Create("Nguyễn Minh Tài", "Hacker lược sử", "Công nghệ thông tin", 10000m, 1, 10000m),
        Tuple.Create("Trần Lâm Khôi Vỹ", "One piece", "Thiếu nhi", 15000m, 1, 15000m),
        Tuple.Create("Lê Trần Trọng Phúc", "Tư tưởng Hồ Chí Minh", "Chính trị", 20000m, 1, 20000m),
    };

            // Thêm dữ liệu vào DataGridView
            foreach (var item in danhSachThongKe)
            {
                int index = dataGridView.Rows.Add(); // Thêm một hàng mới và lưu index của hàng
                dataGridView.Rows[index].Cells["columnhotenkhachhang"].Value = item.Item1;
                dataGridView.Rows[index].Cells["columntensach"].Value = item.Item2;
                dataGridView.Rows[index].Cells["columntheloai"].Value = item.Item3;
                dataGridView.Rows[index].Cells["columndongia"].Value = item.Item4;
                dataGridView.Rows[index].Cells["columnsoluong"].Value = item.Item5;
                dataGridView.Rows[index].Cells["columnthanhtien"].Value = item.Item6;
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            // Thay đổi nội dung phương thức này để ẩn form hiện tại và hiển thị formchucnang
            this.Hide();
            formchucnang.Show();
        }

        private void txtchonthoigian_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txttuadethongkebaocao_Click(object sender, EventArgs e)
        {

        }
    }
}
