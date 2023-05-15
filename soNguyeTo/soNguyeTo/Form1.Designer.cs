namespace soNguyeTo
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
            this.text = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.count = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.box.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(39, 48);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(117, 16);
            this.text.TabIndex = 0;
            this.text.Text = "Nhập giá trị tối đa: ";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(209, 42);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(418, 22);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // box
            // 
            this.box.Controls.Add(this.output);
            this.box.Location = new System.Drawing.Point(42, 99);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(585, 257);
            this.box.TabIndex = 2;
            this.box.TabStop = false;
            this.box.Text = "Các số nguyên tố";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(16, 21);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.output.Size = new System.Drawing.Size(553, 220);
            this.output.TabIndex = 0;
            this.output.Text = "";
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(386, 397);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(94, 30);
            this.count.TabIndex = 3;
            this.count.Text = "Tính";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(505, 397);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(94, 30);
            this.close.TabIndex = 4;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(263, 397);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(94, 30);
            this.del.TabIndex = 5;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.del);
            this.Controls.Add(this.close);
            this.Controls.Add(this.count);
            this.Controls.Add(this.box);
            this.Controls.Add(this.input);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button del;
    }
}

