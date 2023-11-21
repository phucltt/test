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
    public partial class formkhachhang : Form
    {
        private Form formchucnang;

        public formkhachhang(Form formchucnang)
        {
            InitializeComponent();
            this.formchucnang = formchucnang; // Lưu tham chiếu
            this.ControlBox = false;
        }

        private void formkhachhang_Load(object sender, EventArgs e)
        {

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

        private int currentRowIndex = -1;

        private void radiobuttonnam_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radiobuttonnu_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txtdanhsachkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void txtthaotac_Click(object sender, EventArgs e)
        {

        }

        private void buttontimkiemtracuu_Click(object sender, EventArgs e)
        {

        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            // Thay đổi nội dung phương thức này để ẩn form hiện tại và hiển thị formchucnang
            this.Hide();
            formchucnang.Show();
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn để chỉnh sửa không
            if (currentRowIndex >= 0)
            {
                // Cập nhật thông tin vào hàng đang chọn
                DataGridViewRow selectedRow = datagridview.Rows[currentRowIndex];
                selectedRow.Cells["columnmakhachhang"].Value = textboxmakhachhang.Text;
                selectedRow.Cells["columnhotenkhachhang"].Value = textboxhotenkhachhang.Text;
                selectedRow.Cells["columndiachi"].Value = textboxdiachi.Text;
                selectedRow.Cells["columndienthoai"].Value = textboxdienthoai.Text;
                selectedRow.Cells["columnmasothue"].Value = textboxmasothue.Text;
                selectedRow.Cells["columnghichu"].Value = textboxghichu.Text;

                // Thêm thông tin phái
                string gender = radiobuttonnam.Checked ? "Nam" : radiobuttonnu.Checked ? "Nữ" : string.Empty;
                selectedRow.Cells["columnphai"].Value = gender;

                // Xóa thông tin trong các hộp văn bản sau khi cập nhật
                textboxmakhachhang.Clear();
                textboxhotenkhachhang.Clear();
                textboxdiachi.Clear();
                textboxdienthoai.Clear();
                textboxmasothue.Clear();
                textboxghichu.Clear();

                // Đặt lại currentRowIndex để không có hàng nào được chọn
                currentRowIndex = -1;
            }
            else
            {
                MessageBox.Show("No row has been selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count > 0)
            {
                // Lưu vị trí hàng đang chọn
                currentRowIndex = datagridview.SelectedRows[0].Index;

                // Điền thông tin từ hàng vào các hộp văn bản
                DataGridViewRow selectedRow = datagridview.Rows[currentRowIndex];
                textboxmakhachhang.Text = selectedRow.Cells["columnmakhachhang"].Value.ToString();
                textboxhotenkhachhang.Text = selectedRow.Cells["columnhotenkhachhang"].Value.ToString();
                textboxdiachi.Text = selectedRow.Cells["columndiachi"].Value.ToString();
                textboxdienthoai.Text = selectedRow.Cells["columndienthoai"].Value.ToString();
                textboxmasothue.Text = selectedRow.Cells["columnmasothue"].Value.ToString();
                textboxghichu.Text = selectedRow.Cells["columnghichu"].Value.ToString();

                // Thêm phần đọc giới tính
                if (selectedRow.Cells["columngioitinh"].Value.ToString() == "Nam")
                {
                    radiobuttonnam.Checked = true;
                }
                else if (selectedRow.Cells["columngioitinh"].Value.ToString() == "Nữ")
                {
                    radiobuttonnu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes is not empty
            if (!string.IsNullOrWhiteSpace(textboxmakhachhang.Text) ||
                !string.IsNullOrWhiteSpace(textboxhotenkhachhang.Text) ||
                !string.IsNullOrWhiteSpace(textboxdiachi.Text) ||
                !string.IsNullOrWhiteSpace(textboxdienthoai.Text) ||
                !string.IsNullOrWhiteSpace(textboxmasothue.Text) ||
                !string.IsNullOrWhiteSpace(textboxghichu.Text))
            {
                // Create a new row in the DataGridView
                int n = datagridview.Rows.Add();

                // Populate the row with information from the textboxes
                datagridview.Rows[n].Cells["columnmakhachhang"].Value = textboxmakhachhang.Text;
                datagridview.Rows[n].Cells["columnhotenkhachhang"].Value = textboxhotenkhachhang.Text;
                datagridview.Rows[n].Cells["columndiachi"].Value = textboxdiachi.Text;
                datagridview.Rows[n].Cells["columndienthoai"].Value = textboxdienthoai.Text;
                datagridview.Rows[n].Cells["columnmasothue"].Value = textboxmasothue.Text;
                datagridview.Rows[n].Cells["columnghichu"].Value = textboxghichu.Text;

                // Get the gender from the radio buttons
                string gender = radiobuttonnam.Checked ? "Nam" : radiobuttonnu.Checked ? "Nữ" : string.Empty;
                datagridview.Rows[n].Cells["columnphai"].Value = gender;

                // Optionally clear the textboxes and the radio buttons after adding
                textboxmakhachhang.Clear();
                textboxhotenkhachhang.Clear();
                textboxdiachi.Clear();
                textboxdienthoai.Clear();
                textboxmasothue.Clear();
                textboxghichu.Clear();
                radiobuttonnam.Checked = false;
                radiobuttonnu.Checked = false;
            }
            else
            {
                MessageBox.Show("Please fill in at least one field before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textboxghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxmasothue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxdienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxhotenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxmakhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtghichu_Click(object sender, EventArgs e)
        {

        }

        private void txtmasothue_Click(object sender, EventArgs e)
        {

        }

        private void txtdienthoai_Click(object sender, EventArgs e)
        {

        }

        private void txtphai_Click(object sender, EventArgs e)
        {

        }

        private void txtdiachi_Click(object sender, EventArgs e)
        {

        }

        private void txthotenkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void txtmakhachhang_Click(object sender, EventArgs e)
        {

        }

        private void txtkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void txttuadekhachhang_Click(object sender, EventArgs e)
        {

        }
    }
}
