namespace QUANLYPHONGMACHTU
{
    partial class FormThayDoiDonGiaThuoc
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
            this.cbDanhSachThuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDonGiaHienTai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDonGiaMoi = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDanhSachThuoc
            // 
            this.cbDanhSachThuoc.FormattingEnabled = true;
            this.cbDanhSachThuoc.Location = new System.Drawing.Point(119, 38);
            this.cbDanhSachThuoc.Name = "cbDanhSachThuoc";
            this.cbDanhSachThuoc.Size = new System.Drawing.Size(121, 21);
            this.cbDanhSachThuoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá hiện tại:";
            // 
            // lbDonGiaHienTai
            // 
            this.lbDonGiaHienTai.AutoSize = true;
            this.lbDonGiaHienTai.Location = new System.Drawing.Point(152, 74);
            this.lbDonGiaHienTai.Name = "lbDonGiaHienTai";
            this.lbDonGiaHienTai.Size = new System.Drawing.Size(35, 13);
            this.lbDonGiaHienTai.TabIndex = 3;
            this.lbDonGiaHienTai.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập đơn giá thuốc mới:";
            // 
            // tbDonGiaMoi
            // 
            this.tbDonGiaMoi.Location = new System.Drawing.Point(155, 107);
            this.tbDonGiaMoi.Name = "tbDonGiaMoi";
            this.tbDonGiaMoi.Size = new System.Drawing.Size(100, 20);
            this.tbDonGiaMoi.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(187, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 156);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormThayDoiDonGiaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbDonGiaMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDonGiaHienTai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDanhSachThuoc);
            this.Name = "FormThayDoiDonGiaThuoc";
            this.Text = "FormThayDoiDonGiaThuoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDanhSachThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDonGiaHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDonGiaMoi;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}