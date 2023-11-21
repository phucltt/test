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
    public partial class formthongtinsach : Form
    {
        private Form formchucnang;

        public formthongtinsach(Form formchucnang)
        {
            InitializeComponent();
            this.formchucnang = formchucnang;
            this.ControlBox = false;
        }

        private void formthongtinsach_Load(object sender, EventArgs e)
        {

        }

        private void txttuadethongtinsach_Click(object sender, EventArgs e)
        {

        }

        private void txtthongtinsach_Click(object sender, EventArgs e)
        {

        }

        private void txtmasach_Click(object sender, EventArgs e)
        {

        }

        private void textboxmasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttheloai_Click(object sender, EventArgs e)
        {

        }

        private void txttensach_Click(object sender, EventArgs e)
        {

        }

        private void txttacgia_Click(object sender, EventArgs e)
        {

        }

        private void txtdongia_Click(object sender, EventArgs e)
        {

        }

        private void txtsoluongcon_Click(object sender, EventArgs e)
        {

        }

        private void txtnamxuatban_Click(object sender, EventArgs e)
        {

        }

        private void txtnhaxuatban_Click(object sender, EventArgs e)
        {

        }

        private void textboxtheloai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxtensach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxtacgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxsoluongcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnamxuatban_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnhaxuatban_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxdongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes is not empty
            if (!string.IsNullOrWhiteSpace(textboxmasach.Text) ||
                !string.IsNullOrWhiteSpace(textboxtheloai.Text) ||
                !string.IsNullOrWhiteSpace(textboxtensach.Text) ||
                !string.IsNullOrWhiteSpace(textboxtacgia.Text) ||
                !string.IsNullOrWhiteSpace(textboxdongia.Text) ||
                !string.IsNullOrWhiteSpace(textboxsoluongcon.Text) ||
                !string.IsNullOrWhiteSpace(textboxnamxuatban.Text) ||
                !string.IsNullOrWhiteSpace(textboxnhaxuatban.Text))
            {
                // Create a new row in the DataGridView
                int n = datagridview.Rows.Add();

                // Populate the row with information from the textboxes
                datagridview.Rows[n].Cells["columnmasach"].Value = textboxmasach.Text;
                datagridview.Rows[n].Cells["columntheloai"].Value = textboxtheloai.Text;
                datagridview.Rows[n].Cells["columntensach"].Value = textboxtensach.Text;
                datagridview.Rows[n].Cells["columntacgia"].Value = textboxtacgia.Text;
                datagridview.Rows[n].Cells["columndongia"].Value = textboxdongia.Text;
                datagridview.Rows[n].Cells["columnsoluongcon"].Value = textboxsoluongcon.Text;
                datagridview.Rows[n].Cells["columnnamxuatban"].Value = textboxnamxuatban.Text;
                datagridview.Rows[n].Cells["columnnhaxuatban"].Value = textboxnhaxuatban.Text;

                // Optionally clear the textboxes after adding
                textboxmasach.Clear();
                textboxtheloai.Clear();
                textboxtensach.Clear();
                textboxtacgia.Clear();
                textboxdongia.Clear();
                textboxsoluongcon.Clear();
                textboxnamxuatban.Clear();
                textboxnhaxuatban.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in at least one field before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            // Check if there are any rows in the DataGridView
            if (datagridview.SelectedRows.Count > 0 &&
                !datagridview.Rows[datagridview.SelectedRows[0].Index].IsNewRow)
            {
                // Prompt the user to confirm the deletion
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                             "Confirm Delete!",
                                             MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Remove the selected row from the DataGridView
                    datagridview.Rows.RemoveAt(datagridview.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Biến toàn cục để lưu vị trí hàng đang được chỉnh sửa
        private int currentRowIndex = -1;

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count > 0)
            {
                // Lưu vị trí hàng đang chọn
                currentRowIndex = datagridview.SelectedRows[0].Index;

                // Điền thông tin từ hàng vào các hộp văn bản
                DataGridViewRow selectedRow = datagridview.Rows[currentRowIndex];
                textboxmasach.Text = selectedRow.Cells["columnmasach"].Value.ToString();
                textboxtheloai.Text = selectedRow.Cells["columntheloai"].Value.ToString();
                textboxtensach.Text = selectedRow.Cells["columntensach"].Value.ToString();
                textboxtacgia.Text = selectedRow.Cells["columntacgia"].Value.ToString();
                textboxdongia.Text = selectedRow.Cells["columndongia"].Value.ToString();
                textboxsoluongcon.Text = selectedRow.Cells["columnsoluongcon"].Value.ToString();
                textboxnamxuatban.Text = selectedRow.Cells["columnnamxuatban"].Value.ToString();
                textboxnhaxuatban.Text = selectedRow.Cells["columnnhaxuatban"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn để chỉnh sửa không
            if (currentRowIndex >= 0)
            {
                // Cập nhật thông tin vào hàng đang chọn
                DataGridViewRow selectedRow = datagridview.Rows[currentRowIndex];
                selectedRow.Cells["columnmasach"].Value = textboxmasach.Text;
                selectedRow.Cells["columntheloai"].Value = textboxtheloai.Text;
                selectedRow.Cells["columntensach"].Value = textboxtensach.Text;
                selectedRow.Cells["columntacgia"].Value = textboxtacgia.Text;
                selectedRow.Cells["columndongia"].Value = textboxdongia.Text;
                selectedRow.Cells["columnsoluongcon"].Value = textboxsoluongcon.Text;
                selectedRow.Cells["columnnamxuatban"].Value = textboxnamxuatban.Text;
                selectedRow.Cells["columnnhaxuatban"].Value = textboxnhaxuatban.Text;

                // Xóa thông tin trong các hộp văn bản sau khi cập nhật
                textboxmasach.Clear();
                textboxtheloai.Clear();
                textboxtensach.Clear();
                textboxtacgia.Clear();
                textboxdongia.Clear();
                textboxsoluongcon.Clear();
                textboxnamxuatban.Clear();
                textboxnhaxuatban.Clear();

                // Đặt lại currentRowIndex để không có hàng nào được chọn
                currentRowIndex = -1;
            }
            else
            {
                MessageBox.Show("No row has been selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonthoat_Click(object sender, EventArgs e)
        {
            // Hiển thị lại form chức năng và ẩn form thông tin sách
            this.Hide();
            formchucnang.Show();
        }

        private void txtthaotac_Click(object sender, EventArgs e)
        {

        }

        private void txtthongtinchitiet_Click(object sender, EventArgs e)
        {

        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
