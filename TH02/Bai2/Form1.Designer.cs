namespace Bai2
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
            this.radioBtnPhilipine = new System.Windows.Forms.RadioButton();
            this.radioBtnItalian = new System.Windows.Forms.RadioButton();
            this.radioBtnUSA = new System.Windows.Forms.RadioButton();
            this.radiobtnVietnam = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flagPtb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPtb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnPhilipine);
            this.groupBox1.Controls.Add(this.radioBtnItalian);
            this.groupBox1.Controls.Add(this.radioBtnUSA);
            this.groupBox1.Controls.Add(this.radiobtnVietnam);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Country";
            // 
            // radioBtnPhilipine
            // 
            this.radioBtnPhilipine.AutoSize = true;
            this.radioBtnPhilipine.Location = new System.Drawing.Point(3, 122);
            this.radioBtnPhilipine.Name = "radioBtnPhilipine";
            this.radioBtnPhilipine.Size = new System.Drawing.Size(103, 26);
            this.radioBtnPhilipine.TabIndex = 3;
            this.radioBtnPhilipine.TabStop = true;
            this.radioBtnPhilipine.Text = "Philipine";
            this.radioBtnPhilipine.UseVisualStyleBackColor = true;
            // 
            // radioBtnItalian
            // 
            this.radioBtnItalian.AutoSize = true;
            this.radioBtnItalian.Location = new System.Drawing.Point(3, 90);
            this.radioBtnItalian.Name = "radioBtnItalian";
            this.radioBtnItalian.Size = new System.Drawing.Size(81, 26);
            this.radioBtnItalian.TabIndex = 2;
            this.radioBtnItalian.TabStop = true;
            this.radioBtnItalian.Text = "Italian";
            this.radioBtnItalian.UseVisualStyleBackColor = true;
            // 
            // radioBtnUSA
            // 
            this.radioBtnUSA.AutoSize = true;
            this.radioBtnUSA.Location = new System.Drawing.Point(3, 58);
            this.radioBtnUSA.Name = "radioBtnUSA";
            this.radioBtnUSA.Size = new System.Drawing.Size(69, 26);
            this.radioBtnUSA.TabIndex = 1;
            this.radioBtnUSA.TabStop = true;
            this.radioBtnUSA.Text = "USA";
            this.radioBtnUSA.UseVisualStyleBackColor = true;
            // 
            // radiobtnVietnam
            // 
            this.radiobtnVietnam.AutoSize = true;
            this.radiobtnVietnam.Location = new System.Drawing.Point(3, 26);
            this.radiobtnVietnam.Name = "radiobtnVietnam";
            this.radiobtnVietnam.Size = new System.Drawing.Size(100, 26);
            this.radiobtnVietnam.TabIndex = 0;
            this.radiobtnVietnam.TabStop = true;
            this.radiobtnVietnam.Text = "VietNam";
            this.radiobtnVietnam.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(130, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "COUNTRY FLAGS";
            // 
            // flagPtb
            // 
            this.flagPtb.Location = new System.Drawing.Point(376, 182);
            this.flagPtb.Name = "flagPtb";
            this.flagPtb.Size = new System.Drawing.Size(270, 163);
            this.flagPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagPtb.TabIndex = 4;
            this.flagPtb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 519);
            this.Controls.Add(this.flagPtb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagPtb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnItalian;
        private System.Windows.Forms.RadioButton radioBtnUSA;
        private System.Windows.Forms.RadioButton radiobtnVietnam;
        private System.Windows.Forms.RadioButton radioBtnPhilipine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox flagPtb;
    }
}

