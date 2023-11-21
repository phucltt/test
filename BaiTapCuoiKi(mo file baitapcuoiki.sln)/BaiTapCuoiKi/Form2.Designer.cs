namespace BaiTapCuoiKi
{
    partial class formchucnang
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
            this.buttonthongtinsach = new System.Windows.Forms.Button();
            this.buttonnhacungcap = new System.Windows.Forms.Button();
            this.buttonkhachhang = new System.Windows.Forms.Button();
            this.buttonthongkebaocao = new System.Windows.Forms.Button();
            this.buttondanhmucsach = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonthongtinsach
            // 
            this.buttonthongtinsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthongtinsach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonthongtinsach.Location = new System.Drawing.Point(100, 25);
            this.buttonthongtinsach.Name = "buttonthongtinsach";
            this.buttonthongtinsach.Size = new System.Drawing.Size(200, 100);
            this.buttonthongtinsach.TabIndex = 1;
            this.buttonthongtinsach.Text = "Thông tin sách";
            this.buttonthongtinsach.UseVisualStyleBackColor = true;
            this.buttonthongtinsach.Click += new System.EventHandler(this.buttonthongtinsach_Click);
            // 
            // buttonnhacungcap
            // 
            this.buttonnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonnhacungcap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonnhacungcap.Location = new System.Drawing.Point(500, 25);
            this.buttonnhacungcap.Name = "buttonnhacungcap";
            this.buttonnhacungcap.Size = new System.Drawing.Size(200, 100);
            this.buttonnhacungcap.TabIndex = 2;
            this.buttonnhacungcap.Text = "Nhà cung cấp";
            this.buttonnhacungcap.UseVisualStyleBackColor = true;
            this.buttonnhacungcap.Click += new System.EventHandler(this.buttonnhacungcap_Click);
            // 
            // buttonkhachhang
            // 
            this.buttonkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonkhachhang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonkhachhang.Location = new System.Drawing.Point(100, 175);
            this.buttonkhachhang.Name = "buttonkhachhang";
            this.buttonkhachhang.Size = new System.Drawing.Size(200, 100);
            this.buttonkhachhang.TabIndex = 3;
            this.buttonkhachhang.Text = "Khách hàng";
            this.buttonkhachhang.UseVisualStyleBackColor = true;
            this.buttonkhachhang.Click += new System.EventHandler(this.buttonkhachhang_Click);
            // 
            // buttonthongkebaocao
            // 
            this.buttonthongkebaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthongkebaocao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonthongkebaocao.Location = new System.Drawing.Point(500, 175);
            this.buttonthongkebaocao.Name = "buttonthongkebaocao";
            this.buttonthongkebaocao.Size = new System.Drawing.Size(200, 100);
            this.buttonthongkebaocao.TabIndex = 4;
            this.buttonthongkebaocao.Text = "Thống kê báo cáo";
            this.buttonthongkebaocao.UseVisualStyleBackColor = true;
            this.buttonthongkebaocao.Click += new System.EventHandler(this.buttonthongkebaocao_Click);
            // 
            // buttondanhmucsach
            // 
            this.buttondanhmucsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttondanhmucsach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttondanhmucsach.Location = new System.Drawing.Point(100, 325);
            this.buttondanhmucsach.Name = "buttondanhmucsach";
            this.buttondanhmucsach.Size = new System.Drawing.Size(200, 100);
            this.buttondanhmucsach.TabIndex = 5;
            this.buttondanhmucsach.Text = "Danh mục sách";
            this.buttondanhmucsach.UseVisualStyleBackColor = true;
            this.buttondanhmucsach.Click += new System.EventHandler(this.buttondanhmucsach_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonthoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonthoat.Location = new System.Drawing.Point(500, 325);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(200, 100);
            this.buttonthoat.TabIndex = 6;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // formchucnang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttondanhmucsach);
            this.Controls.Add(this.buttonthongkebaocao);
            this.Controls.Add(this.buttonkhachhang);
            this.Controls.Add(this.buttonnhacungcap);
            this.Controls.Add(this.buttonthongtinsach);
            this.Name = "formchucnang";
            this.Text = "Chức năng";
            this.Load += new System.EventHandler(this.formchucnang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonthongtinsach;
        private System.Windows.Forms.Button buttonnhacungcap;
        private System.Windows.Forms.Button buttonkhachhang;
        private System.Windows.Forms.Button buttonthongkebaocao;
        private System.Windows.Forms.Button buttondanhmucsach;
        private System.Windows.Forms.Button buttonthoat;
    }
}