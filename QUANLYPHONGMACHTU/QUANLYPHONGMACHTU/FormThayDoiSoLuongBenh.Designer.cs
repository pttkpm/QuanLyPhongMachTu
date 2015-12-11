namespace QUANLYPHONGMACHTU
{
    partial class FormThayDoiSoLuongBenh
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbSoluongBenh = new System.Windows.Forms.Label();
            this.tbSoLuongBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(72, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lbSoluongBenh
            // 
            this.lbSoluongBenh.AutoSize = true;
            this.lbSoluongBenh.Location = new System.Drawing.Point(245, 37);
            this.lbSoluongBenh.Name = "lbSoluongBenh";
            this.lbSoluongBenh.Size = new System.Drawing.Size(35, 13);
            this.lbSoluongBenh.TabIndex = 9;
            this.lbSoluongBenh.Text = "label3";
            // 
            // tbSoLuongBenh
            // 
            this.tbSoLuongBenh.Location = new System.Drawing.Point(72, 111);
            this.tbSoLuongBenh.Name = "tbSoLuongBenh";
            this.tbSoLuongBenh.Size = new System.Drawing.Size(100, 20);
            this.tbSoLuongBenh.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập số lượng bệnh nhân tối đa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng loại bệnh tối đa hiện tại:";
            // 
            // FormThayDoiSoLuongBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbSoluongBenh);
            this.Controls.Add(this.tbSoLuongBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThayDoiSoLuongBenh";
            this.Text = "FormThayDoiSoLuongBenh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbSoluongBenh;
        private System.Windows.Forms.TextBox tbSoLuongBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}