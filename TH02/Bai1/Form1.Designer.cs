namespace Bai1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBatDau = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(116, 214);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(103, 32);
            this.btnBatDau.TabIndex = 0;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(355, 214);
            this.btnDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(103, 32);
            this.btnDung.TabIndex = 1;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // lblDongHo
            // 
            this.lblDongHo.AutoSize = true;
            this.lblDongHo.Location = new System.Drawing.Point(258, 99);
            this.lblDongHo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(0, 22);
            this.lblDongHo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(648, 357);
            this.Controls.Add(this.lblDongHo);
            this.Controls.Add(this.btnDung);
            this.Controls.Add(this.btnBatDau);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Đồng hồ đếm ngược";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label lblDongHo;
    }
}

