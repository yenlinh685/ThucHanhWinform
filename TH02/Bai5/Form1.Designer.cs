namespace Bai5
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
            this.PhoneBookTrv = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNamebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LastNametxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstNametxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneBookTrv
            // 
            this.PhoneBookTrv.Location = new System.Drawing.Point(12, 12);
            this.PhoneBookTrv.Name = "PhoneBookTrv";
            this.PhoneBookTrv.Size = new System.Drawing.Size(444, 540);
            this.PhoneBookTrv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNamebtn);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(487, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AddNamebtn
            // 
            this.AddNamebtn.Location = new System.Drawing.Point(255, 228);
            this.AddNamebtn.Name = "AddNamebtn";
            this.AddNamebtn.Size = new System.Drawing.Size(170, 51);
            this.AddNamebtn.TabIndex = 3;
            this.AddNamebtn.Text = "Add Name";
            this.AddNamebtn.UseVisualStyleBackColor = true;
            this.AddNamebtn.Click += new System.EventHandler(this.AddNamebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LastNametxb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 75);
            this.panel2.TabIndex = 2;
            // 
            // LastNametxb
            // 
            this.LastNametxb.Location = new System.Drawing.Point(17, 28);
            this.LastNametxb.Name = "LastNametxb";
            this.LastNametxb.Size = new System.Drawing.Size(372, 30);
            this.LastNametxb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FirstNametxb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 75);
            this.panel1.TabIndex = 0;
            // 
            // FirstNametxb
            // 
            this.FirstNametxb.Location = new System.Drawing.Point(17, 28);
            this.FirstNametxb.Name = "FirstNametxb";
            this.FirstNametxb.Size = new System.Drawing.Size(372, 30);
            this.FirstNametxb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(742, 367);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(170, 51);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 570);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PhoneBookTrv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView PhoneBookTrv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FirstNametxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LastNametxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNamebtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

