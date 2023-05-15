namespace PTBN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hệ số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số a: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số b:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(209, 41);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(282, 22);
            this.a.TabIndex = 3;
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(209, 95);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(282, 22);
            this.b.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(209, 227);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(282, 22);
            this.result.TabIndex = 7;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(414, 378);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(122, 30);
            this.count.TabIndex = 1;
            this.count.Text = "Tính";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(600, 378);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(122, 30);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(237, 378);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(122, 30);
            this.del.TabIndex = 3;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.del);
            this.Controls.Add(this.close);
            this.Controls.Add(this.count);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button del;
    }
}

