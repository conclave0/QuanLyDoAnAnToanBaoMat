namespace WindowsFormsApplication1.GUI
{
    partial class DanhSachMonHoc
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
            this.tbDSMH = new System.Windows.Forms.DataGridView();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongMH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbDSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // tbDSMH
            // 
            this.tbDSMH.AllowUserToAddRows = false;
            this.tbDSMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDSMH.Location = new System.Drawing.Point(66, 67);
            this.tbDSMH.Name = "tbDSMH";
            this.tbDSMH.Size = new System.Drawing.Size(669, 332);
            this.tbDSMH.TabIndex = 1;
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(66, 423);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(124, 23);
            this.btnThemMH.TabIndex = 2;
            this.btnThemMH.Text = "Thêm môn học";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng số môn học:";
            // 
            // txtTongMH
            // 
            this.txtTongMH.Enabled = false;
            this.txtTongMH.Location = new System.Drawing.Point(581, 425);
            this.txtTongMH.Name = "txtTongMH";
            this.txtTongMH.Size = new System.Drawing.Size(100, 20);
            this.txtTongMH.TabIndex = 4;
            // 
            // DanhSachMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 467);
            this.Controls.Add(this.txtTongMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.tbDSMH);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.DanhSachMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDSMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbDSMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongMH;
    }
}