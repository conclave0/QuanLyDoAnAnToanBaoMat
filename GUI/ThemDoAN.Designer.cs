namespace WindowsFormsApplication1.GUI
{
    partial class ThemDoAN
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_deadline = new System.Windows.Forms.DateTimePicker();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.cb_Monhoc = new System.Windows.Forms.ComboBox();
            this.cb_hinhthuc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đồ án";
            // 
            // txt_tenDA
            // 
            this.txt_tenDA.Location = new System.Drawing.Point(114, 79);
            this.txt_tenDA.Name = "txt_tenDA";
            this.txt_tenDA.Size = new System.Drawing.Size(239, 20);
            this.txt_tenDA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(114, 119);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(239, 20);
            this.txt_soluong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deadline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình thức";
            // 
            // dt_deadline
            // 
            this.dt_deadline.Location = new System.Drawing.Point(114, 167);
            this.dt_deadline.Name = "dt_deadline";
            this.dt_deadline.Size = new System.Drawing.Size(239, 20);
            this.dt_deadline.TabIndex = 10;
            // 
            // btn_dangky
            // 
            this.btn_dangky.Location = new System.Drawing.Point(114, 260);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(239, 39);
            this.btn_dangky.TabIndex = 11;
            this.btn_dangky.Text = "OK";
            this.btn_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // cb_Monhoc
            // 
            this.cb_Monhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Monhoc.FormattingEnabled = true;
            this.cb_Monhoc.Location = new System.Drawing.Point(114, 38);
            this.cb_Monhoc.Name = "cb_Monhoc";
            this.cb_Monhoc.Size = new System.Drawing.Size(239, 21);
            this.cb_Monhoc.TabIndex = 12;
            // 
            // cb_hinhthuc
            // 
            this.cb_hinhthuc.DisplayMember = "0";
            this.cb_hinhthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hinhthuc.FormattingEnabled = true;
            this.cb_hinhthuc.Items.AddRange(new object[] {
            "Cộng Điểm",
            "Cuối Kì"});
            this.cb_hinhthuc.Location = new System.Drawing.Point(114, 209);
            this.cb_hinhthuc.Name = "cb_hinhthuc";
            this.cb_hinhthuc.Size = new System.Drawing.Size(239, 21);
            this.cb_hinhthuc.TabIndex = 13;
            // 
            // ThemDoAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 324);
            this.Controls.Add(this.cb_hinhthuc);
            this.Controls.Add(this.cb_Monhoc);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.dt_deadline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenDA);
            this.Controls.Add(this.label1);
            this.Name = "ThemDoAN";
            this.Text = "ThemDoAN";
            this.Load += new System.EventHandler(this.ThemDoAN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_deadline;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.ComboBox cb_Monhoc;
        private System.Windows.Forms.ComboBox cb_hinhthuc;
    }
}