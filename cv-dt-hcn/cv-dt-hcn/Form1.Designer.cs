namespace cv_dt_hcn
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCD = new System.Windows.Forms.TextBox();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chiều dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập chiều rộng";
            // 
            // txtCD
            // 
            this.txtCD.Location = new System.Drawing.Point(306, 74);
            this.txtCD.Name = "txtCD";
            this.txtCD.Size = new System.Drawing.Size(137, 22);
            this.txtCD.TabIndex = 2;
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(306, 149);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(137, 22);
            this.txtCR.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chu vi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Diện tích";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(306, 236);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(137, 22);
            this.txtCV.TabIndex = 7;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(306, 326);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(137, 22);
            this.txtDT.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Giải";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 56);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kết thúc";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.txtCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nhập chiều dài ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCD;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

