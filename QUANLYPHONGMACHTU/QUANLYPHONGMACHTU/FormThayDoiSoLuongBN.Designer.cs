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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThayDoiSoLuongBN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoLuongBenhNhan = new System.Windows.Forms.TextBox();
            this.lbSoluongBN = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng bệnh nhân tối đa hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số lượng bệnh nhân tối đa:";
            // 
            // tbSoLuongBenhNhan
            // 
            this.tbSoLuongBenhNhan.Location = new System.Drawing.Point(66, 159);
            this.tbSoLuongBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoLuongBenhNhan.Name = "tbSoLuongBenhNhan";
            this.tbSoLuongBenhNhan.Size = new System.Drawing.Size(148, 25);
            this.tbSoLuongBenhNhan.TabIndex = 2;
            // 
            // lbSoluongBN
            // 
            this.lbSoluongBN.AutoSize = true;
            this.lbSoluongBN.Location = new System.Drawing.Point(332, 61);
            this.lbSoluongBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoluongBN.Name = "lbSoluongBN";
            this.lbSoluongBN.Size = new System.Drawing.Size(52, 17);
            this.lbSoluongBN.TabIndex = 3;
            this.lbSoluongBN.Text = "label3";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::QUANLYPHONGMACHTU.Properties.Resources.deletered;
            this.btnCancel.Location = new System.Drawing.Point(265, 211);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 39);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QUANLYPHONGMACHTU.Properties.Resources.check;
            this.button1.Location = new System.Drawing.Point(66, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "OK";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormThayDoiSoLuongBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 294);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSoluongBN);
            this.Controls.Add(this.tbSoLuongBenhNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThayDoiSoLuongBN";
            this.Text = "Thay đổi số lượng bệnh nhân";
            this.Load += new System.EventHandler(this.FormThayDoiSoLuongBN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuongBenhNhan;
        private System.Windows.Forms.Label lbSoluongBN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}