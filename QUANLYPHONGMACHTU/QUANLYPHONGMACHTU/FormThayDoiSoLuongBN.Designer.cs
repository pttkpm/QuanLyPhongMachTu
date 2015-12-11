namespace QUANLYPHONGMACHTU
{
    partial class FormThayDoiSoLuongBN
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
            this.tbSoLuongBenhNhan = new System.Windows.Forms.TextBox();
            this.lbSoluongBN = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng bệnh nhân tối đa hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số lượng bệnh nhân tối đa:";
            // 
            // tbSoLuongBenhNhan
            // 
            this.tbSoLuongBenhNhan.Location = new System.Drawing.Point(48, 121);
            this.tbSoLuongBenhNhan.Name = "tbSoLuongBenhNhan";
            this.tbSoLuongBenhNhan.Size = new System.Drawing.Size(100, 20);
            this.tbSoLuongBenhNhan.TabIndex = 2;
            // 
            // lbSoluongBN
            // 
            this.lbSoluongBN.AutoSize = true;
            this.lbSoluongBN.Location = new System.Drawing.Point(221, 47);
            this.lbSoluongBN.Name = "lbSoluongBN";
            this.lbSoluongBN.Size = new System.Drawing.Size(35, 13);
            this.lbSoluongBN.TabIndex = 3;
            this.lbSoluongBN.Text = "label3";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(48, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormThayDoiSoLuongBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 225);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbSoluongBN);
            this.Controls.Add(this.tbSoLuongBenhNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThayDoiSoLuongBN";
            this.Text = "FormThayDoiSoLuongBN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuongBenhNhan;
        private System.Windows.Forms.Label lbSoluongBN;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}