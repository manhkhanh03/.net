namespace WindowsFormsApp3
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Point_y3 = new System.Windows.Forms.TextBox();
            this.Point_y2 = new System.Windows.Forms.TextBox();
            this.Point_y1 = new System.Windows.Forms.TextBox();
            this.Point_x3 = new System.Windows.Forms.TextBox();
            this.Point_x2 = new System.Windows.Forms.TextBox();
            this.Point_x1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kq_dienTich = new System.Windows.Forms.TextBox();
            this.kq_chuvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Point_y3);
            this.groupBox1.Controls.Add(this.Point_y2);
            this.groupBox1.Controls.Add(this.Point_y1);
            this.groupBox1.Controls.Add(this.Point_x3);
            this.groupBox1.Controls.Add(this.Point_x2);
            this.groupBox1.Controls.Add(this.Point_x1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu....";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Point_y3
            // 
            this.Point_y3.Location = new System.Drawing.Point(442, 118);
            this.Point_y3.Name = "Point_y3";
            this.Point_y3.Size = new System.Drawing.Size(169, 22);
            this.Point_y3.TabIndex = 8;
            this.Point_y3.TextChanged += new System.EventHandler(this.Point_y3_TextChanged);
            // 
            // Point_y2
            // 
            this.Point_y2.Location = new System.Drawing.Point(442, 82);
            this.Point_y2.Name = "Point_y2";
            this.Point_y2.Size = new System.Drawing.Size(169, 22);
            this.Point_y2.TabIndex = 7;
            this.Point_y2.TextChanged += new System.EventHandler(this.Point_y2_TextChanged);
            // 
            // Point_y1
            // 
            this.Point_y1.Location = new System.Drawing.Point(442, 41);
            this.Point_y1.Name = "Point_y1";
            this.Point_y1.Size = new System.Drawing.Size(169, 22);
            this.Point_y1.TabIndex = 6;
            this.Point_y1.TextChanged += new System.EventHandler(this.Point_y1_TextChanged);
            // 
            // Point_x3
            // 
            this.Point_x3.Location = new System.Drawing.Point(250, 118);
            this.Point_x3.Name = "Point_x3";
            this.Point_x3.Size = new System.Drawing.Size(169, 22);
            this.Point_x3.TabIndex = 5;
            this.Point_x3.TextChanged += new System.EventHandler(this.Point_x3_TextChanged);
            // 
            // Point_x2
            // 
            this.Point_x2.Location = new System.Drawing.Point(250, 82);
            this.Point_x2.Name = "Point_x2";
            this.Point_x2.Size = new System.Drawing.Size(169, 22);
            this.Point_x2.TabIndex = 4;
            this.Point_x2.TextChanged += new System.EventHandler(this.Point_x2_TextChanged);
            // 
            // Point_x1
            // 
            this.Point_x1.Location = new System.Drawing.Point(250, 41);
            this.Point_x1.Name = "Point_x1";
            this.Point_x1.Size = new System.Drawing.Size(169, 22);
            this.Point_x1.TabIndex = 3;
            this.Point_x1.TextChanged += new System.EventHandler(this.Point_x1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tọa độ điểm C(x3, y3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tọa độ điểm B(x2, y2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tọa độ điểm A(x1, y1)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kq_dienTich);
            this.groupBox2.Controls.Add(this.kq_chuvi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(44, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // kq_dienTich
            // 
            this.kq_dienTich.BackColor = System.Drawing.SystemColors.Control;
            this.kq_dienTich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kq_dienTich.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kq_dienTich.Location = new System.Drawing.Point(250, 83);
            this.kq_dienTich.Name = "kq_dienTich";
            this.kq_dienTich.ReadOnly = true;
            this.kq_dienTich.Size = new System.Drawing.Size(361, 22);
            this.kq_dienTich.TabIndex = 11;
            this.kq_dienTich.TextChanged += new System.EventHandler(this.kq_dienTich_TextChanged);
            // 
            // kq_chuvi
            // 
            this.kq_chuvi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kq_chuvi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.kq_chuvi.Location = new System.Drawing.Point(250, 41);
            this.kq_chuvi.Name = "kq_chuvi";
            this.kq_chuvi.ReadOnly = true;
            this.kq_chuvi.Size = new System.Drawing.Size(361, 22);
            this.kq_chuvi.TabIndex = 9;
            this.kq_chuvi.TextChanged += new System.EventHandler(this.kq_chuvi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diện tích tam giác ABC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chu vi tam giác ABC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delete);
            this.groupBox3.Controls.Add(this.end);
            this.groupBox3.Controls.Add(this.count);
            this.groupBox3.Location = new System.Drawing.Point(44, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính toán....";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(275, 55);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 28);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(540, 55);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(97, 28);
            this.end.TabIndex = 1;
            this.end.Text = "Kết thúc";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(403, 55);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(97, 28);
            this.count.TabIndex = 0;
            this.count.Text = "Tính";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Point_y3;
        private System.Windows.Forms.TextBox Point_y2;
        private System.Windows.Forms.TextBox Point_y1;
        private System.Windows.Forms.TextBox Point_x3;
        private System.Windows.Forms.TextBox Point_x2;
        private System.Windows.Forms.TextBox Point_x1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kq_dienTich;
        private System.Windows.Forms.TextBox kq_chuvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button count;
    }
}

