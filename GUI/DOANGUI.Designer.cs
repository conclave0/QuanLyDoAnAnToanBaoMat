namespace WindowsFormsApplication1.GUI
{
    partial class DOANGUI
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
            this.btn_show = new System.Windows.Forms.Button();
            this.gridview_doan = new System.Windows.Forms.DataGridView();
            this.btn_dangkydoan = new System.Windows.Forms.Button();
            this.txt_rows_doan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_capnhat_sl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemChiTietMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaThongTinMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaNgayKetThucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capNhatMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demMonTheoTrangThaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_doan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(12, 304);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(836, 41);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // gridview_doan
            // 
            this.gridview_doan.AllowUserToAddRows = false;
            this.gridview_doan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_doan.Location = new System.Drawing.Point(12, 80);
            this.gridview_doan.Name = "gridview_doan";
            this.gridview_doan.Size = new System.Drawing.Size(836, 201);
            this.gridview_doan.TabIndex = 1;
            // 
            // btn_dangkydoan
            // 
            this.btn_dangkydoan.Location = new System.Drawing.Point(12, 366);
            this.btn_dangkydoan.Name = "btn_dangkydoan";
            this.btn_dangkydoan.Size = new System.Drawing.Size(125, 41);
            this.btn_dangkydoan.TabIndex = 2;
            this.btn_dangkydoan.Text = "Đăng ký đồ án";
            this.btn_dangkydoan.UseVisualStyleBackColor = true;
            this.btn_dangkydoan.Click += new System.EventHandler(this.btn_dangkydoan_Click);
            // 
            // txt_rows_doan
            // 
            this.txt_rows_doan.Enabled = false;
            this.txt_rows_doan.Location = new System.Drawing.Point(104, 35);
            this.txt_rows_doan.Name = "txt_rows_doan";
            this.txt_rows_doan.Size = new System.Drawing.Size(219, 20);
            this.txt_rows_doan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số lượng đồ án";
            // 
            // bt_capnhat_sl
            // 
            this.bt_capnhat_sl.Location = new System.Drawing.Point(156, 366);
            this.bt_capnhat_sl.Name = "bt_capnhat_sl";
            this.bt_capnhat_sl.Size = new System.Drawing.Size(126, 41);
            this.bt_capnhat_sl.TabIndex = 5;
            this.bt_capnhat_sl.Text = "Cập nhật số lượng";
            this.bt_capnhat_sl.UseVisualStyleBackColor = true;
            this.bt_capnhat_sl.Click += new System.EventHandler(this.bt_capnhat_sl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chuyển nhóm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Đăng ký nhóm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cập nhật deadline đồ án";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "Setting transaction";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(645, 425);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 38);
            this.button7.TabIndex = 17;
            this.button7.Text = "Thêm sinh viên vào môn học";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(458, 425);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 38);
            this.button6.TabIndex = 16;
            this.button6.Text = "Tăng sinh viên cho môn học";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 425);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 38);
            this.button5.TabIndex = 15;
            this.button5.Text = "Thêm SV";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(156, 425);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(126, 38);
            this.button8.TabIndex = 14;
            this.button8.Text = "Tìm kiếm SV";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 425);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 38);
            this.button9.TabIndex = 13;
            this.button9.Text = "Quản lý môn học";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemMonHocToolStripMenuItem,
            this.suaThongTinMonHocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemMonHocToolStripMenuItem
            // 
            this.xemMonHocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTietMonToolStripMenuItem,
            this.demMonTheoTrangThaiToolStripMenuItem});
            this.xemMonHocToolStripMenuItem.Name = "xemMonHocToolStripMenuItem";
            this.xemMonHocToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.xemMonHocToolStripMenuItem.Text = "Xem Môn Học";
            this.xemMonHocToolStripMenuItem.Click += new System.EventHandler(this.xemMonHocToolStripMenuItem_Click);
            // 
            // xemChiTietMonToolStripMenuItem
            // 
            this.xemChiTietMonToolStripMenuItem.Name = "xemChiTietMonToolStripMenuItem";
            this.xemChiTietMonToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.xemChiTietMonToolStripMenuItem.Text = "Xem Chi Tiết Môn";
            this.xemChiTietMonToolStripMenuItem.Click += new System.EventHandler(this.xemChiTietMonToolStripMenuItem_Click);
            // 
            // suaThongTinMonHocToolStripMenuItem
            // 
            this.suaThongTinMonHocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suaNgayKetThucToolStripMenuItem,
            this.capNhatMonHocToolStripMenuItem});
            this.suaThongTinMonHocToolStripMenuItem.Name = "suaThongTinMonHocToolStripMenuItem";
            this.suaThongTinMonHocToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.suaThongTinMonHocToolStripMenuItem.Text = "Sửa Thông Tin Môn Học";
            // 
            // suaNgayKetThucToolStripMenuItem
            // 
            this.suaNgayKetThucToolStripMenuItem.Name = "suaNgayKetThucToolStripMenuItem";
            this.suaNgayKetThucToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.suaNgayKetThucToolStripMenuItem.Text = "Tăng Ngày Kết Thúc";
            this.suaNgayKetThucToolStripMenuItem.Click += new System.EventHandler(this.suaNgayKetThucToolStripMenuItem_Click);
            // 
            // capNhatMonHocToolStripMenuItem
            // 
            this.capNhatMonHocToolStripMenuItem.Name = "capNhatMonHocToolStripMenuItem";
            this.capNhatMonHocToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.capNhatMonHocToolStripMenuItem.Text = "Cập Nhật Môn Học";
            this.capNhatMonHocToolStripMenuItem.Click += new System.EventHandler(this.capNhatMonHocToolStripMenuItem_Click);
            // 
            // demMonTheoTrangThaiToolStripMenuItem
            // 
            this.demMonTheoTrangThaiToolStripMenuItem.Name = "demMonTheoTrangThaiToolStripMenuItem";
            this.demMonTheoTrangThaiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.demMonTheoTrangThaiToolStripMenuItem.Text = "Đếm Môn Theo Trạng Thái";
            this.demMonTheoTrangThaiToolStripMenuItem.Click += new System.EventHandler(this.demMonTheoTrangThaiToolStripMenuItem_Click);
            // 
            // DOANGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 475);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_capnhat_sl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rows_doan);
            this.Controls.Add(this.btn_dangkydoan);
            this.Controls.Add(this.gridview_doan);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DOANGUI";
            this.Text = "DOANGUI";
            ((System.ComponentModel.ISupportInitialize)(this.gridview_doan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.DataGridView gridview_doan;
        private System.Windows.Forms.Button btn_dangkydoan;
        private System.Windows.Forms.TextBox txt_rows_doan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_capnhat_sl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemMonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemChiTietMonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaThongTinMonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaNgayKetThucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capNhatMonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demMonTheoTrangThaiToolStripMenuItem;
    }
}