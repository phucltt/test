namespace BaiTapCuoiKi
{
    partial class formthongkebaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttuadethongkebaocao = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtchonthoigian = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonok = new System.Windows.Forms.Button();
            this.txtthongkebanchay = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.columnhotenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columndongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txttuadethongkebaocao
            // 
            this.txttuadethongkebaocao.AutoSize = true;
            this.txttuadethongkebaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttuadethongkebaocao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txttuadethongkebaocao.Location = new System.Drawing.Point(270, 10);
            this.txttuadethongkebaocao.Name = "txttuadethongkebaocao";
            this.txttuadethongkebaocao.Size = new System.Drawing.Size(359, 39);
            this.txttuadethongkebaocao.TabIndex = 0;
            this.txttuadethongkebaocao.Text = "THỐNG KÊ BÁO CÁO";
            this.txttuadethongkebaocao.Click += new System.EventHandler(this.txttuadethongkebaocao_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dateTimePicker.Location = new System.Drawing.Point(380, 76);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // txtchonthoigian
            // 
            this.txtchonthoigian.AutoSize = true;
            this.txtchonthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtchonthoigian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtchonthoigian.Location = new System.Drawing.Point(253, 77);
            this.txtchonthoigian.Name = "txtchonthoigian";
            this.txtchonthoigian.Size = new System.Drawing.Size(121, 20);
            this.txtchonthoigian.TabIndex = 2;
            this.txtchonthoigian.Text = "Chọn thời gian:";
            this.txtchonthoigian.Click += new System.EventHandler(this.txtchonthoigian_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnhotenkhachhang,
            this.columntensach,
            this.columntheloai,
            this.columndongia,
            this.columnsoluong,
            this.columnthanhtien});
            this.dataGridView.Location = new System.Drawing.Point(12, 139);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(920, 350);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonok
            // 
            this.buttonok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonok.Location = new System.Drawing.Point(586, 61);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(75, 50);
            this.buttonok.TabIndex = 4;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // txtthongkebanchay
            // 
            this.txtthongkebanchay.AutoSize = true;
            this.txtthongkebanchay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthongkebanchay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtthongkebanchay.Location = new System.Drawing.Point(8, 91);
            this.txtthongkebanchay.Name = "txtthongkebanchay";
            this.txtthongkebanchay.Size = new System.Drawing.Size(149, 20);
            this.txtthongkebanchay.TabIndex = 5;
            this.txtthongkebanchay.Text = "Thống kê bán chạy";
            this.txtthongkebanchay.Click += new System.EventHandler(this.txtthongkebanchay_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonthoat.Location = new System.Drawing.Point(667, 61);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(75, 50);
            this.buttonthoat.TabIndex = 6;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // columnhotenkhachhang
            // 
            this.columnhotenkhachhang.HeaderText = "Họ tên khách hàng";
            this.columnhotenkhachhang.Name = "columnhotenkhachhang";
            // 
            // columntensach
            // 
            this.columntensach.HeaderText = "Tên sách";
            this.columntensach.Name = "columntensach";
            // 
            // columntheloai
            // 
            this.columntheloai.HeaderText = "Thể loại";
            this.columntheloai.Name = "columntheloai";
            // 
            // columndongia
            // 
            this.columndongia.HeaderText = "Đơn giá";
            this.columndongia.Name = "columndongia";
            // 
            // columnsoluong
            // 
            this.columnsoluong.HeaderText = "Số lượng";
            this.columnsoluong.Name = "columnsoluong";
            // 
            // columnthanhtien
            // 
            this.columnthanhtien.HeaderText = "Thành tiền";
            this.columnthanhtien.Name = "columnthanhtien";
            // 
            // formthongkebaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.txtthongkebanchay);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtchonthoigian);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txttuadethongkebaocao);
            this.Name = "formthongkebaocao";
            this.Text = "Thống kê báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttuadethongkebaocao;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label txtchonthoigian;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Label txtthongkebanchay;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnhotenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnthanhtien;
    }
}