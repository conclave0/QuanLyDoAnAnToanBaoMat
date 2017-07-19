namespace WindowsFormsApplication1.GUI
{
    partial class CapNhatDeadline
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
            this.cb_maMH = new System.Windows.Forms.ComboBox();
            this.cb_maDA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_deadline = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // cb_maMH
            // 
            this.cb_maMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maMH.FormattingEnabled = true;
            this.cb_maMH.Location = new System.Drawing.Point(127, 29);
            this.cb_maMH.Name = "cb_maMH";
            this.cb_maMH.Size = new System.Drawing.Size(198, 21);
            this.cb_maMH.TabIndex = 1;
            this.cb_maMH.TextChanged += new System.EventHandler(this.cb_maMH_TextChanged);
            // 
            // cb_maDA
            // 
            this.cb_maDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_maDA.FormattingEnabled = true;
            this.cb_maDA.Location = new System.Drawing.Point(127, 68);
            this.cb_maDA.Name = "cb_maDA";
            this.cb_maDA.Size = new System.Drawing.Size(198, 21);
            this.cb_maDA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đồ án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deadline";
            // 
            // dt_deadline
            // 
            this.dt_deadline.Location = new System.Drawing.Point(127, 103);
            this.dt_deadline.Name = "dt_deadline";
            this.dt_deadline.Size = new System.Drawing.Size(198, 20);
            this.dt_deadline.TabIndex = 5;
            this.dt_deadline.Value = new System.DateTime(2017, 6, 23, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CapNhatDeadline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt_deadline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_maDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_maMH);
            this.Controls.Add(this.label1);
            this.Name = "CapNhatDeadline";
            this.Text = "CapNhatDeadline";
            this.Load += new System.EventHandler(this.CapNhatDeadline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_maMH;
        private System.Windows.Forms.ComboBox cb_maDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_deadline;
        private System.Windows.Forms.Button button1;
    }
}