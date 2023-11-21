namespace BaiTapCuoiKi
{
    partial class formkhachhang
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
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.columnmakhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnhotenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columndienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnphai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columndiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnmasothue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdanhsachkhachhang = new System.Windows.Forms.Label();
            this.txtthaotac = new System.Windows.Forms.Label();
            this.buttontimkiemtracuu = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.textboxghichu = new System.Windows.Forms.TextBox();
            this.textboxmasothue = new System.Windows.Forms.TextBox();
            this.textboxdienthoai = new System.Windows.Forms.TextBox();
            this.textboxdiachi = new System.Windows.Forms.TextBox();
            this.textboxhotenkhachhang = new System.Windows.Forms.TextBox();
            this.textboxmakhachhang = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.Label();
            this.txtmasothue = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.Label();
            this.txthotenkhachhang = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.Label();
            this.txtkhachhang = new System.Windows.Forms.Label();
            this.txttuadekhachhang = new System.Windows.Forms.Label();
            this.txtphai = new System.Windows.Forms.Label();
            this.radiobuttonnam = new System.Windows.Forms.RadioButton();
            this.radiobuttonnu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnmakhachhang,
            this.columnhotenkhachhang,
            this.columndienthoai,
            this.columnphai,
            this.columndiachi,
            this.columnmasothue,
            this.columnghichu});
            this.datagridview.Location = new System.Drawing.Point(12, 279);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(920, 216);
            this.datagridview.TabIndex = 56;
            this.datagridview.TabStop = false;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            // 
            // columnmakhachhang
            // 
            this.columnmakhachhang.HeaderText = "Mã khách hàng";
            this.columnmakhachhang.Name = "columnmakhachhang";
            // 
            // columnhotenkhachhang
            // 
            this.columnhotenkhachhang.HeaderText = "Họ tên khách hàng";
            this.columnhotenkhachhang.Name = "columnhotenkhachhang";
            // 
            // columndienthoai
            // 
            this.columndienthoai.HeaderText = "Điện thoại";
            this.columndienthoai.Name = "columndienthoai";
            // 
            // columnphai
            // 
            this.columnphai.HeaderText = "Phái";
            this.columnphai.Name = "columnphai";
            // 
            // columndiachi
            // 
            this.columndiachi.HeaderText = "Địa chỉ";
            this.columndiachi.Name = "columndiachi";
            // 
            // columnmasothue
            // 
            this.columnmasothue.HeaderText = "Mã số thuế";
            this.columnmasothue.Name = "columnmasothue";
            // 
            // columnghichu
            // 
            this.columnghichu.HeaderText = "Ghi chú";
            this.columnghichu.Name = "columnghichu";
            // 
            // txtdanhsachkhachhang
            // 
            this.txtdanhsachkhachhang.AutoSize = true;
            this.txtdanhsachkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdanhsachkhachhang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdanhsachkhachhang.Location = new System.Drawing.Point(50, 256);
            this.txtdanhsachkhachhang.Name = "txtdanhsachkhachhang";
            this.txtdanhsachkhachhang.Size = new System.Drawing.Size(180, 20);
            this.txtdanhsachkhachhang.TabIndex = 54;
            this.txtdanhsachkhachhang.Text = "Danh sách khách hàng";
            this.txtdanhsachkhachhang.Click += new System.EventHandler(this.txtdanhsachkhachhang_Click);
            // 
            // txtthaotac
            // 
            this.txtthaotac.AutoSize = true;
            this.txtthaotac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthaotac.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtthaotac.Location = new System.Drawing.Point(50, 206);
            this.txtthaotac.Name = "txtthaotac";
            this.txtthaotac.Size = new System.Drawing.Size(74, 20);
            this.txtthaotac.TabIndex = 51;
            this.txtthaotac.Text = "Thao tác";
            this.txtthaotac.Click += new System.EventHandler(this.txtthaotac_Click);
            // 
            // buttontimkiemtracuu
            // 
            this.buttontimkiemtracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttontimkiemtracuu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttontimkiemtracuu.Location = new System.Drawing.Point(173, 206);
            this.buttontimkiemtracuu.Name = "buttontimkiemtracuu";
            this.buttontimkiemtracuu.Size = new System.Drawing.Size(121, 50);
            this.buttontimkiemtracuu.TabIndex = 62;
            this.buttontimkiemtracuu.Text = "Tìm kiếm-Tra cứu";
            this.buttontimkiemtracuu.UseVisualStyleBackColor = true;
            this.buttontimkiemtracuu.Click += new System.EventHandler(this.buttontimkiemtracuu_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthoat.Location = new System.Drawing.Point(724, 206);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(100, 50);
            this.buttonthoat.TabIndex = 61;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttonluu
            // 
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonluu.ForeColor = System.Drawing.Color.Blue;
            this.buttonluu.Location = new System.Drawing.Point(618, 206);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(100, 50);
            this.buttonluu.TabIndex = 60;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonsua.ForeColor = System.Drawing.Color.Yellow;
            this.buttonsua.Location = new System.Drawing.Point(512, 206);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(100, 50);
            this.buttonsua.TabIndex = 59;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonxoa.ForeColor = System.Drawing.Color.Red;
            this.buttonxoa.Location = new System.Drawing.Point(406, 206);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(100, 50);
            this.buttonxoa.TabIndex = 58;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthem.ForeColor = System.Drawing.Color.Green;
            this.buttonthem.Location = new System.Drawing.Point(300, 206);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(100, 50);
            this.buttonthem.TabIndex = 57;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // textboxghichu
            // 
            this.textboxghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxghichu.Location = new System.Drawing.Point(606, 144);
            this.textboxghichu.Name = "textboxghichu";
            this.textboxghichu.Size = new System.Drawing.Size(300, 45);
            this.textboxghichu.TabIndex = 55;
            this.textboxghichu.TextChanged += new System.EventHandler(this.textboxghichu_TextChanged);
            // 
            // textboxmasothue
            // 
            this.textboxmasothue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxmasothue.Location = new System.Drawing.Point(606, 112);
            this.textboxmasothue.Name = "textboxmasothue";
            this.textboxmasothue.Size = new System.Drawing.Size(300, 26);
            this.textboxmasothue.TabIndex = 53;
            this.textboxmasothue.TextChanged += new System.EventHandler(this.textboxmasothue_TextChanged);
            // 
            // textboxdienthoai
            // 
            this.textboxdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxdienthoai.Location = new System.Drawing.Point(606, 76);
            this.textboxdienthoai.Name = "textboxdienthoai";
            this.textboxdienthoai.Size = new System.Drawing.Size(300, 26);
            this.textboxdienthoai.TabIndex = 52;
            this.textboxdienthoai.TextChanged += new System.EventHandler(this.textboxdienthoai_TextChanged);
            // 
            // textboxdiachi
            // 
            this.textboxdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxdiachi.Location = new System.Drawing.Point(173, 169);
            this.textboxdiachi.Name = "textboxdiachi";
            this.textboxdiachi.Size = new System.Drawing.Size(300, 26);
            this.textboxdiachi.TabIndex = 50;
            this.textboxdiachi.TextChanged += new System.EventHandler(this.textboxdiachi_TextChanged);
            // 
            // textboxhotenkhachhang
            // 
            this.textboxhotenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxhotenkhachhang.Location = new System.Drawing.Point(173, 112);
            this.textboxhotenkhachhang.Name = "textboxhotenkhachhang";
            this.textboxhotenkhachhang.Size = new System.Drawing.Size(300, 26);
            this.textboxhotenkhachhang.TabIndex = 49;
            this.textboxhotenkhachhang.TextChanged += new System.EventHandler(this.textboxhotenkhachhang_TextChanged);
            // 
            // textboxmakhachhang
            // 
            this.textboxmakhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxmakhachhang.Location = new System.Drawing.Point(173, 76);
            this.textboxmakhachhang.Name = "textboxmakhachhang";
            this.textboxmakhachhang.Size = new System.Drawing.Size(300, 26);
            this.textboxmakhachhang.TabIndex = 41;
            this.textboxmakhachhang.TextChanged += new System.EventHandler(this.textboxmakhachhang_TextChanged);
            // 
            // txtghichu
            // 
            this.txtghichu.AutoSize = true;
            this.txtghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtghichu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtghichu.Location = new System.Drawing.Point(508, 144);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(67, 20);
            this.txtghichu.TabIndex = 48;
            this.txtghichu.Text = "Ghi chú";
            this.txtghichu.Click += new System.EventHandler(this.txtghichu_Click);
            // 
            // txtmasothue
            // 
            this.txtmasothue.AutoSize = true;
            this.txtmasothue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmasothue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtmasothue.Location = new System.Drawing.Point(508, 115);
            this.txtmasothue.Name = "txtmasothue";
            this.txtmasothue.Size = new System.Drawing.Size(92, 20);
            this.txtmasothue.TabIndex = 47;
            this.txtmasothue.Text = "Mã số thuế";
            this.txtmasothue.Click += new System.EventHandler(this.txtmasothue_Click);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.AutoSize = true;
            this.txtdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdienthoai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdienthoai.Location = new System.Drawing.Point(508, 79);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(84, 20);
            this.txtdienthoai.TabIndex = 46;
            this.txtdienthoai.Text = "Điện thoại";
            this.txtdienthoai.Click += new System.EventHandler(this.txtdienthoai_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.AutoSize = true;
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdiachi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdiachi.Location = new System.Drawing.Point(25, 175);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(61, 20);
            this.txtdiachi.TabIndex = 45;
            this.txtdiachi.Text = "Địa chỉ";
            this.txtdiachi.Click += new System.EventHandler(this.txtdiachi_Click);
            // 
            // txthotenkhachhang
            // 
            this.txthotenkhachhang.AutoSize = true;
            this.txthotenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txthotenkhachhang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txthotenkhachhang.Location = new System.Drawing.Point(25, 115);
            this.txthotenkhachhang.Name = "txthotenkhachhang";
            this.txthotenkhachhang.Size = new System.Drawing.Size(149, 20);
            this.txthotenkhachhang.TabIndex = 44;
            this.txthotenkhachhang.Text = "Họ tên khách hàng";
            this.txthotenkhachhang.Click += new System.EventHandler(this.txthotenkhachhang_Click);
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.AutoSize = true;
            this.txtmakhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmakhachhang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtmakhachhang.Location = new System.Drawing.Point(25, 79);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(122, 20);
            this.txtmakhachhang.TabIndex = 43;
            this.txtmakhachhang.Text = "Mã khách hàng";
            this.txtmakhachhang.Click += new System.EventHandler(this.txtmakhachhang_Click);
            // 
            // txtkhachhang
            // 
            this.txtkhachhang.AutoSize = true;
            this.txtkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtkhachhang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtkhachhang.Location = new System.Drawing.Point(50, 50);
            this.txtkhachhang.Name = "txtkhachhang";
            this.txtkhachhang.Size = new System.Drawing.Size(97, 20);
            this.txtkhachhang.TabIndex = 42;
            this.txtkhachhang.Text = "Khách hàng";
            this.txtkhachhang.Click += new System.EventHandler(this.txtkhachhang_Click);
            // 
            // txttuadekhachhang
            // 
            this.txttuadekhachhang.AutoSize = true;
            this.txttuadekhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttuadekhachhang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txttuadekhachhang.Location = new System.Drawing.Point(320, 10);
            this.txttuadekhachhang.Name = "txttuadekhachhang";
            this.txttuadekhachhang.Size = new System.Drawing.Size(246, 39);
            this.txttuadekhachhang.TabIndex = 40;
            this.txttuadekhachhang.Text = "KHÁCH HÀNG";
            this.txttuadekhachhang.Click += new System.EventHandler(this.txttuadekhachhang_Click);
            // 
            // txtphai
            // 
            this.txtphai.AutoSize = true;
            this.txtphai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtphai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtphai.Location = new System.Drawing.Point(25, 144);
            this.txtphai.Name = "txtphai";
            this.txtphai.Size = new System.Drawing.Size(42, 20);
            this.txtphai.TabIndex = 45;
            this.txtphai.Text = "Phái";
            this.txtphai.Click += new System.EventHandler(this.txtphai_Click);
            // 
            // radiobuttonnam
            // 
            this.radiobuttonnam.AutoSize = true;
            this.radiobuttonnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radiobuttonnam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radiobuttonnam.Location = new System.Drawing.Point(173, 142);
            this.radiobuttonnam.Name = "radiobuttonnam";
            this.radiobuttonnam.Size = new System.Drawing.Size(62, 24);
            this.radiobuttonnam.TabIndex = 63;
            this.radiobuttonnam.TabStop = true;
            this.radiobuttonnam.Text = "Nam";
            this.radiobuttonnam.UseVisualStyleBackColor = true;
            this.radiobuttonnam.CheckedChanged += new System.EventHandler(this.radiobuttonnam_CheckedChanged);
            // 
            // radiobuttonnu
            // 
            this.radiobuttonnu.AutoSize = true;
            this.radiobuttonnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radiobuttonnu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radiobuttonnu.Location = new System.Drawing.Point(327, 142);
            this.radiobuttonnu.Name = "radiobuttonnu";
            this.radiobuttonnu.Size = new System.Drawing.Size(48, 24);
            this.radiobuttonnu.TabIndex = 63;
            this.radiobuttonnu.TabStop = true;
            this.radiobuttonnu.Text = "Nữ";
            this.radiobuttonnu.UseVisualStyleBackColor = true;
            this.radiobuttonnu.CheckedChanged += new System.EventHandler(this.radiobuttonnu_CheckedChanged);
            // 
            // formkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.radiobuttonnu);
            this.Controls.Add(this.radiobuttonnam);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.txtdanhsachkhachhang);
            this.Controls.Add(this.txtthaotac);
            this.Controls.Add(this.buttontimkiemtracuu);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.textboxghichu);
            this.Controls.Add(this.textboxmasothue);
            this.Controls.Add(this.textboxdienthoai);
            this.Controls.Add(this.textboxdiachi);
            this.Controls.Add(this.textboxhotenkhachhang);
            this.Controls.Add(this.textboxmakhachhang);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtmasothue);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtphai);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txthotenkhachhang);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.txtkhachhang);
            this.Controls.Add(this.txttuadekhachhang);
            this.Name = "formkhachhang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.formkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.Label txtdanhsachkhachhang;
        private System.Windows.Forms.Label txtthaotac;
        private System.Windows.Forms.Button buttontimkiemtracuu;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.TextBox textboxghichu;
        private System.Windows.Forms.TextBox textboxmasothue;
        private System.Windows.Forms.TextBox textboxdienthoai;
        private System.Windows.Forms.TextBox textboxdiachi;
        private System.Windows.Forms.TextBox textboxhotenkhachhang;
        private System.Windows.Forms.TextBox textboxmakhachhang;
        private System.Windows.Forms.Label txtghichu;
        private System.Windows.Forms.Label txtmasothue;
        private System.Windows.Forms.Label txtdienthoai;
        private System.Windows.Forms.Label txtdiachi;
        private System.Windows.Forms.Label txthotenkhachhang;
        private System.Windows.Forms.Label txtmakhachhang;
        private System.Windows.Forms.Label txtkhachhang;
        private System.Windows.Forms.Label txttuadekhachhang;
        private System.Windows.Forms.Label txtphai;
        private System.Windows.Forms.RadioButton radiobuttonnam;
        private System.Windows.Forms.RadioButton radiobuttonnu;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnmakhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnhotenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnphai;
        private System.Windows.Forms.DataGridViewTextBoxColumn columndiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnmasothue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnghichu;
    }
}