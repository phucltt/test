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
    public partial class formnhacungcap : Form
    {
        private Form formchucnang;

        public formnhacungcap(Form formchucnang)
        {
            InitializeComponent();
            this.formchucnang = formchucnang; // Lưu tham chiếu
            this.ControlBox = false;
        }

        private void formnhacungcap_Load(object sender, EventArgs e)
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
                selectedRow.Cells["columnmanhacungcap"].Value = textboxmanhacungcap.Text;
                selectedRow.Cells["columntennhacungcap"].Value = textboxtennhacungcap.Text;
                selectedRow.Cells["columndiachi"].Value = textboxdiachi.Text;
                selectedRow.Cells["columndienthoai"].Value = textboxdienthoai.Text;
                selectedRow.Cells["columnmasothue"].Value = textboxmasothue.Text;
                selectedRow.Cells["columnghichu"].Value = textboxghichu.Text;

                // Xóa thông tin trong các hộp văn bản sau khi cập nhật
                textboxmanhacungcap.Clear();
                textboxtennhacungcap.Clear();
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
                textboxmanhacungcap.Text = selectedRow.Cells["columnmanhacungcap"].Value.ToString();
                textboxtennhacungcap.Text = selectedRow.Cells["columntennhacungcap"].Value.ToString();
                textboxdiachi.Text = selectedRow.Cells["columndiachi"].Value.ToString();
                textboxdienthoai.Text = selectedRow.Cells["columndienthoai"].Value.ToString();
                textboxmasothue.Text = selectedRow.Cells["columnmasothue"].Value.ToString();
                textboxghichu.Text = selectedRow.Cells["columnghichu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private int currentRowIndex = -1;

        private void buttonthem_Click(object sender, EventArgs e)
        {
            // Check if any of the textboxes is not empty
            if (!string.IsNullOrWhiteSpace(textboxmanhacungcap.Text) ||
                !string.IsNullOrWhiteSpace(textboxtennhacungcap.Text) ||
                !string.IsNullOrWhiteSpace(textboxdiachi.Text) ||
                !string.IsNullOrWhiteSpace(textboxdienthoai.Text) ||
                !string.IsNullOrWhiteSpace(textboxmasothue.Text) ||
                !string.IsNullOrWhiteSpace(textboxghichu.Text))
            {
                // Create a new row in the DataGridView
                int n = datagridview.Rows.Add();

                // Populate the row with information from the textboxes
                datagridview.Rows[n].Cells["columnmanhacungcap"].Value = textboxmanhacungcap.Text;
                datagridview.Rows[n].Cells["columntennhacungcap"].Value = textboxtennhacungcap.Text;
                datagridview.Rows[n].Cells["columndiachi"].Value = textboxdiachi.Text;
                datagridview.Rows[n].Cells["columndienthoai"].Value = textboxdienthoai.Text;
                datagridview.Rows[n].Cells["columnmasothue"].Value = textboxmasothue.Text;
                datagridview.Rows[n].Cells["columnghichu"].Value = textboxghichu.Text;

                // Optionally clear the textboxes after adding
                textboxmanhacungcap.Clear();
                textboxtennhacungcap.Clear();
                textboxdiachi.Clear();
                textboxdienthoai.Clear();
                textboxmasothue.Clear();
                textboxghichu.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in at least one field before adding.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtthongtinchitiet_Click(object sender, EventArgs e)
        {

        }

        private void txtthaotac_Click(object sender, EventArgs e)
        {

        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void textboxtennhacungcap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxmanhacungcap_TextChanged(object sender, EventArgs e)
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

        private void txtdiachi_Click(object sender, EventArgs e)
        {

        }

        private void txttennhacungcap_Click(object sender, EventArgs e)
        {

        }

        private void txtmanhacungcap_Click(object sender, EventArgs e)
        {

        }

        private void txtnhacungcap_Click(object sender, EventArgs e)
        {

        }

        private void txttuadenhacungcap_Click(object sender, EventArgs e)
        {

        }
    }
}
