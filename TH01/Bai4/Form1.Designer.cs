namespace Bai4
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnChia = new System.Windows.Forms.RadioButton();
            this.radiobtnNhan = new System.Windows.Forms.RadioButton();
            this.radiobtnTru = new System.Windows.Forms.RadioButton();
            this.radiobtnCong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSo1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(122, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 51);
            this.panel1.TabIndex = 1;
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(120, 15);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(595, 30);
            this.txtSo1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSo2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(122, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 51);
            this.panel2.TabIndex = 2;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(120, 15);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(595, 30);
            this.txtSo2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnChia);
            this.groupBox1.Controls.Add(this.radiobtnNhan);
            this.groupBox1.Controls.Add(this.radiobtnTru);
            this.groupBox1.Controls.Add(this.radiobtnCong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // radiobtnChia
            // 
            this.radiobtnChia.AutoSize = true;
            this.radiobtnChia.Location = new System.Drawing.Point(584, 38);
            this.radiobtnChia.Name = "radiobtnChia";
            this.radiobtnChia.Size = new System.Drawing.Size(70, 27);
            this.radiobtnChia.TabIndex = 5;
            this.radiobtnChia.TabStop = true;
            this.radiobtnChia.Text = "Chia";
            this.radiobtnChia.UseVisualStyleBackColor = true;
            // 
            // radiobtnNhan
            // 
            this.radiobtnNhan.AutoSize = true;
            this.radiobtnNhan.Location = new System.Drawing.Point(375, 38);
            this.radiobtnNhan.Name = "radiobtnNhan";
            this.radiobtnNhan.Size = new System.Drawing.Size(75, 27);
            this.radiobtnNhan.TabIndex = 4;
            this.radiobtnNhan.TabStop = true;
            this.radiobtnNhan.Text = "Nhân";
            this.radiobtnNhan.UseVisualStyleBackColor = true;
            // 
            // radiobtnTru
            // 
            this.radiobtnTru.AutoSize = true;
            this.radiobtnTru.Location = new System.Drawing.Point(194, 38);
            this.radiobtnTru.Name = "radiobtnTru";
            this.radiobtnTru.Size = new System.Drawing.Size(63, 27);
            this.radiobtnTru.TabIndex = 1;
            this.radiobtnTru.TabStop = true;
            this.radiobtnTru.Text = "Trừ";
            this.radiobtnTru.UseVisualStyleBackColor = true;
            // 
            // radiobtnCong
            // 
            this.radiobtnCong.AutoSize = true;
            this.radiobtnCong.Location = new System.Drawing.Point(15, 38);
            this.radiobtnCong.Name = "radiobtnCong";
            this.radiobtnCong.Size = new System.Drawing.Size(75, 27);
            this.radiobtnCong.TabIndex = 0;
            this.radiobtnCong.TabStop = true;
            this.radiobtnCong.Text = "Cộng";
            this.radiobtnCong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết quả:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(229, 329);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(608, 30);
            this.txtResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(918, 405);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Phép tính";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnTru;
        private System.Windows.Forms.RadioButton radiobtnCong;
        private System.Windows.Forms.RadioButton radiobtnChia;
        private System.Windows.Forms.RadioButton radiobtnNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
    }
}

