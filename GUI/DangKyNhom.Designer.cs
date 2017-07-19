namespace WindowsFormsApplication1.GUI
{
    partial class DangKyNhom
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.cb_doan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nhom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_masv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.Location = new System.Drawing.Point(106, 30);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(121, 22);
            this.cb_monhoc.TabIndex = 1;
            this.cb_monhoc.TextChanged += new System.EventHandler(this.cb_monhoc_TextChanged);
            // 
            // cb_doan
            // 
            this.cb_doan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doan.FormattingEnabled = true;
            this.cb_doan.Location = new System.Drawing.Point(106, 78);
            this.cb_doan.Name = "cb_doan";
            this.cb_doan.Size = new System.Drawing.Size(121, 22);
            this.cb_doan.TabIndex = 3;
            this.cb_doan.TextChanged += new System.EventHandler(this.cb_doan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đồ án";
            // 
            // cb_nhom
            // 
            this.cb_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhom.FormattingEnabled = true;
            this.cb_nhom.Location = new System.Drawing.Point(106, 124);
            this.cb_nhom.Name = "cb_nhom";
            this.cb_nhom.Size = new System.Drawing.Size(121, 22);
            this.cb_nhom.TabIndex = 5;
            this.cb_nhom.TextChanged += new System.EventHandler(this.cb_nhom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhóm";
            // 
            // cb_masv
            // 
            this.cb_masv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_masv.FormattingEnabled = true;
            this.cb_masv.Location = new System.Drawing.Point(106, 167);
            this.cb_masv.Name = "cb_masv";
            this.cb_masv.Size = new System.Drawing.Size(121, 22);
            this.cb_masv.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã sinh viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangKyNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_masv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_nhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_doan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_monhoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DangKyNhom";
            this.Text = "DangKyNhom";
            this.Load += new System.EventHandler(this.DangKyNhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private System.Windows.Forms.ComboBox cb_doan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_masv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}