namespace Bai1
{
    partial class ConfigForm
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
            this.rdoWindow = new System.Windows.Forms.RadioButton();
            this.rdoSA = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttenmay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quyền kết nối";
            // 
            // rdoWindow
            // 
            this.rdoWindow.AutoSize = true;
            this.rdoWindow.Location = new System.Drawing.Point(261, 103);
            this.rdoWindow.Name = "rdoWindow";
            this.rdoWindow.Size = new System.Drawing.Size(114, 20);
            this.rdoWindow.TabIndex = 1;
            this.rdoWindow.TabStop = true;
            this.rdoWindow.Tag = "WD";
            this.rdoWindow.Text = "Quyền window";
            this.rdoWindow.UseVisualStyleBackColor = true;
            // 
            // rdoSA
            // 
            this.rdoSA.AutoSize = true;
            this.rdoSA.Location = new System.Drawing.Point(261, 146);
            this.rdoSA.Name = "rdoSA";
            this.rdoSA.Size = new System.Drawing.Size(117, 20);
            this.rdoSA.TabIndex = 2;
            this.rdoSA.TabStop = true;
            this.rdoSA.Tag = "account";
            this.rdoSA.Text = "Quyền account";
            this.rdoSA.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(467, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 250);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPW);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(14, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(417, 47);
            this.panel5.TabIndex = 4;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(109, 11);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(292, 30);
            this.txtPW.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUN);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(14, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 47);
            this.panel4.TabIndex = 3;
            // 
            // txtUN
            // 
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.Location = new System.Drawing.Point(109, 11);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(292, 30);
            this.txtUN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtdata);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(14, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 47);
            this.panel2.TabIndex = 2;
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(109, 11);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(292, 30);
            this.txtdata.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên data";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttenmay);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 47);
            this.panel3.TabIndex = 1;
            // 
            // txttenmay
            // 
            this.txttenmay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenmay.Location = new System.Drawing.Point(109, 11);
            this.txttenmay.Name = "txttenmay";
            this.txttenmay.Size = new System.Drawing.Size(292, 30);
            this.txttenmay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên máy/IP";
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(969, 113);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(133, 47);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Cấu hình";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 382);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoSA);
            this.Controls.Add(this.rdoWindow);
            this.Controls.Add(this.label1);
            this.Name = "ConfigForm";
            this.Text = "Form cấu hình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoWindow;
        private System.Windows.Forms.RadioButton rdoSA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttenmay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfig;
    }
}