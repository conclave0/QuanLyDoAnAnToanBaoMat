namespace WindowsFormsApplication1.GUI
{
    partial class ChuyenNhom
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
            this.cb_nhommoi = new System.Windows.Forms.ComboBox();
            this.cb_MaSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_maMH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_maDA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_nhomcu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm muốn chuyển";
            // 
            // cb_nhommoi
            // 
            this.cb_nhommoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhommoi.FormattingEnabled = true;
            this.cb_nhommoi.Location = new System.Drawing.Point(159, 121);
            this.cb_nhommoi.Name = "cb_nhommoi";
            this.cb_nhommoi.Size = new System.Drawing.Size(223, 21);
            this.cb_nhommoi.TabIndex = 1;
            // 
            // cb_MaSV
            // 
            this.cb_MaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaSV.FormattingEnabled = true;
            this.cb_MaSV.Location = new System.Drawing.Point(159, 77);
            this.cb_MaSV.Name = "cb_MaSV";
            this.cb_MaSV.Size = new System.Drawing.Size(223, 21);
            this.cb_MaSV.TabIndex = 3;
            this.cb_MaSV.TextChanged += new System.EventHandler(this.cb_MaSV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên muốn chuyển";
            // 
            // cb_maMH
            // 
            this.cb_maMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maMH.FormattingEnabled = true;
            this.cb_maMH.Location = new System.Drawing.Point(159, 5);
            this.cb_maMH.Name = "cb_maMH";
            this.cb_maMH.Size = new System.Drawing.Size(223, 21);
            this.cb_maMH.TabIndex = 5;
            this.cb_maMH.TextChanged += new System.EventHandler(this.cb_maMH_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học";
            // 
            // cb_maDA
            // 
            this.cb_maDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maDA.FormattingEnabled = true;
            this.cb_maDA.Location = new System.Drawing.Point(159, 41);
            this.cb_maDA.Name = "cb_maDA";
            this.cb_maDA.Size = new System.Drawing.Size(223, 21);
            this.cb_maDA.TabIndex = 7;
            this.cb_maDA.TextChanged += new System.EventHandler(this.cb_maDA_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã đồ án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhóm cũ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "chuyển nhóm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_nhomcu
            // 
            this.tb_nhomcu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nhomcu.Enabled = false;
            this.tb_nhomcu.Location = new System.Drawing.Point(159, 163);
            this.tb_nhomcu.Name = "tb_nhomcu";
            this.tb_nhomcu.Size = new System.Drawing.Size(223, 20);
            this.tb_nhomcu.TabIndex = 11;
            // 
            // ChuyenNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 248);
            this.Controls.Add(this.tb_nhomcu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_maDA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_maMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_MaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_nhommoi);
            this.Controls.Add(this.label1);
            this.Name = "ChuyenNhom";
            this.Text = "ChuyenNhom";
            this.Load += new System.EventHandler(this.ChuyenNhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhommoi;
        private System.Windows.Forms.ComboBox cb_MaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_maMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_maDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_nhomcu;
    }
}