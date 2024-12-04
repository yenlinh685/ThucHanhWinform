namespace Bai3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbhistoty = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ltbUocso = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnQuanityEven = new System.Windows.Forms.Button();
            this.btnQuanityPrime = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbhistoty);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(374, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cbbhistoty
            // 
            this.cbbhistoty.FormattingEnabled = true;
            this.cbbhistoty.Location = new System.Drawing.Point(0, 103);
            this.cbbhistoty.Margin = new System.Windows.Forms.Padding(4);
            this.cbbhistoty.Name = "cbbhistoty";
            this.cbbhistoty.Size = new System.Drawing.Size(198, 30);
            this.cbbhistoty.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(227, 26);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(4, 36);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(194, 30);
            this.txtInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ltbUocso);
            this.groupBox2.Location = new System.Drawing.Point(478, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(367, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // ltbUocso
            // 
            this.ltbUocso.FormattingEnabled = true;
            this.ltbUocso.ItemHeight = 22;
            this.ltbUocso.Location = new System.Drawing.Point(16, 34);
            this.ltbUocso.Name = "ltbUocso";
            this.ltbUocso.Size = new System.Drawing.Size(269, 114);
            this.ltbUocso.TabIndex = 3;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(478, 275);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(367, 41);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Tổng các ước số";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnQuanityEven
            // 
            this.btnQuanityEven.Location = new System.Drawing.Point(478, 346);
            this.btnQuanityEven.Name = "btnQuanityEven";
            this.btnQuanityEven.Size = new System.Drawing.Size(367, 41);
            this.btnQuanityEven.TabIndex = 4;
            this.btnQuanityEven.Text = "Số lượng các ước số chẵn";
            this.btnQuanityEven.UseVisualStyleBackColor = true;
            this.btnQuanityEven.Click += new System.EventHandler(this.btnQuanityEven_Click);
            // 
            // btnQuanityPrime
            // 
            this.btnQuanityPrime.Location = new System.Drawing.Point(478, 420);
            this.btnQuanityPrime.Name = "btnQuanityPrime";
            this.btnQuanityPrime.Size = new System.Drawing.Size(367, 41);
            this.btnQuanityPrime.TabIndex = 5;
            this.btnQuanityPrime.Text = "Số lượng các ước số nguyên tố";
            this.btnQuanityPrime.UseVisualStyleBackColor = true;
            this.btnQuanityPrime.Click += new System.EventHandler(this.btnQuanityPrime_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(326, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 479);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuanityPrime);
            this.Controls.Add(this.btnQuanityEven);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Combobox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbbhistoty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ltbUocso;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnQuanityEven;
        private System.Windows.Forms.Button btnQuanityPrime;
        private System.Windows.Forms.Button btnExit;
    }
}

