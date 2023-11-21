namespace BaiTapCuoiKi
{
    partial class formdanhmucsach
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
            this.txttuadedanhmucsach = new System.Windows.Forms.Label();
            this.comboboxchonloaisach = new System.Windows.Forms.ComboBox();
            this.txtthongtinloaisach = new System.Windows.Forms.Label();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.txtchonloaisach = new System.Windows.Forms.Label();
            this.buttonok = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.columnmasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columntheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columndongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnsoluongcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txttuadedanhmucsach
            // 
            this.txttuadedanhmucsach.AutoSize = true;
            this.txttuadedanhmucsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttuadedanhmucsach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txttuadedanhmucsach.Location = new System.Drawing.Point(310, 0);
            this.txttuadedanhmucsach.Name = "txttuadedanhmucsach";
            this.txttuadedanhmucsach.Size = new System.Drawing.Size(307, 39);
            this.txttuadedanhmucsach.TabIndex = 0;
            this.txttuadedanhmucsach.Text = "DANH MỤC SÁCH";
            this.txttuadedanhmucsach.Click += new System.EventHandler(this.txttuadedanhmucsach_Click);
            // 
            // comboboxchonloaisach
            // 
            this.comboboxchonloaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboboxchonloaisach.FormattingEnabled = true;
            this.comboboxchonloaisach.Location = new System.Drawing.Point(376, 86);
            this.comboboxchonloaisach.Name = "comboboxchonloaisach";
            this.comboboxchonloaisach.Size = new System.Drawing.Size(300, 28);
            this.comboboxchonloaisach.TabIndex = 1;
            this.comboboxchonloaisach.SelectedIndexChanged += new System.EventHandler(this.comboboxchonloaisach_SelectedIndexChanged);
            // 
            // txtthongtinloaisach
            // 
            this.txtthongtinloaisach.AutoSize = true;
            this.txtthongtinloaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthongtinloaisach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtthongtinloaisach.Location = new System.Drawing.Point(50, 250);
            this.txtthongtinloaisach.Name = "txtthongtinloaisach";
            this.txtthongtinloaisach.Size = new System.Drawing.Size(150, 20);
            this.txtthongtinloaisach.TabIndex = 2;
            this.txtthongtinloaisach.Text = "Thông tin loại sách";
            this.txtthongtinloaisach.Click += new System.EventHandler(this.txtthongtinloaisach_Click);
            // 
            // datagridview
            // 
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnmasach,
            this.columntensach,
            this.columntheloai,
            this.columndongia,
            this.columnsoluongcon});
            this.datagridview.Location = new System.Drawing.Point(12, 273);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(920, 216);
            this.datagridview.TabIndex = 8;
            this.datagridview.TabStop = false;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            // 
            // txtchonloaisach
            // 
            this.txtchonloaisach.AutoSize = true;
            this.txtchonloaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtchonloaisach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtchonloaisach.Location = new System.Drawing.Point(250, 89);
            this.txtchonloaisach.Name = "txtchonloaisach";
            this.txtchonloaisach.Size = new System.Drawing.Size(120, 20);
            this.txtchonloaisach.TabIndex = 9;
            this.txtchonloaisach.Text = "Chọn loại sách";
            this.txtchonloaisach.Click += new System.EventHandler(this.txtchonloaisach_Click);
            // 
            // buttonok
            // 
            this.buttonok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonok.Location = new System.Drawing.Point(317, 169);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(100, 50);
            this.buttonok.TabIndex = 10;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonthoat.Location = new System.Drawing.Point(517, 169);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(100, 50);
            this.buttonthoat.TabIndex = 11;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // columnmasach
            // 
            this.columnmasach.HeaderText = "Mã sách";
            this.columnmasach.Name = "columnmasach";
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
            // columnsoluongcon
            // 
            this.columnsoluongcon.HeaderText = "Số lượng còn";
            this.columnsoluongcon.Name = "columnsoluongcon";
            // 
            // formdanhmucsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.txtchonloaisach);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.txtthongtinloaisach);
            this.Controls.Add(this.comboboxchonloaisach);
            this.Controls.Add(this.txttuadedanhmucsach);
            this.Name = "formdanhmucsach";
            this.Text = "Danh mục sách";
            this.Load += new System.EventHandler(this.formdanhmucsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttuadedanhmucsach;
        private System.Windows.Forms.ComboBox comboboxchonloaisach;
        private System.Windows.Forms.Label txtthongtinloaisach;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label txtchonloaisach;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnmasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn columntheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnsoluongcon;
    }
}