namespace GUI_Project
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabs1 = new System.Windows.Forms.TabPage();
            this.DesktopSubmit = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabs2 = new System.Windows.Forms.TabPage();
            this.POSSubmit = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabs1.SuspendLayout();
            this.tabs2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabs1);
            this.tabControl1.Controls.Add(this.tabs2);
            this.tabControl1.Location = new System.Drawing.Point(158, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabs1
            // 
            this.tabs1.Controls.Add(this.DesktopSubmit);
            this.tabs1.Controls.Add(this.textBox5);
            this.tabs1.Controls.Add(this.textBox4);
            this.tabs1.Controls.Add(this.textBox3);
            this.tabs1.Controls.Add(this.textBox2);
            this.tabs1.Controls.Add(this.textBox1);
            this.tabs1.Controls.Add(this.label6);
            this.tabs1.Controls.Add(this.label5);
            this.tabs1.Controls.Add(this.label4);
            this.tabs1.Controls.Add(this.label3);
            this.tabs1.Controls.Add(this.label2);
            this.tabs1.Controls.Add(this.label1);
            this.tabs1.Location = new System.Drawing.Point(4, 22);
            this.tabs1.Name = "tabs1";
            this.tabs1.Padding = new System.Windows.Forms.Padding(3);
            this.tabs1.Size = new System.Drawing.Size(367, 352);
            this.tabs1.TabIndex = 0;
            this.tabs1.Text = "Desktop";
            this.tabs1.UseVisualStyleBackColor = true;
            // 
            // DesktopSubmit
            // 
            this.DesktopSubmit.Location = new System.Drawing.Point(155, 283);
            this.DesktopSubmit.Name = "DesktopSubmit";
            this.DesktopSubmit.Size = new System.Drawing.Size(75, 23);
            this.DesktopSubmit.TabIndex = 11;
            this.DesktopSubmit.Text = "Submit";
            this.DesktopSubmit.UseVisualStyleBackColor = true;
            this.DesktopSubmit.Click += new System.EventHandler(this.DesktopSubmit_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zipcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salon Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Or";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Number";
            // 
            // tabs2
            // 
            this.tabs2.Controls.Add(this.POSSubmit);
            this.tabs2.Controls.Add(this.textBox6);
            this.tabs2.Controls.Add(this.textBox7);
            this.tabs2.Controls.Add(this.textBox8);
            this.tabs2.Controls.Add(this.textBox9);
            this.tabs2.Controls.Add(this.textBox10);
            this.tabs2.Controls.Add(this.label7);
            this.tabs2.Controls.Add(this.label8);
            this.tabs2.Controls.Add(this.label9);
            this.tabs2.Controls.Add(this.label10);
            this.tabs2.Controls.Add(this.label11);
            this.tabs2.Controls.Add(this.label12);
            this.tabs2.Location = new System.Drawing.Point(4, 22);
            this.tabs2.Name = "tabs2";
            this.tabs2.Padding = new System.Windows.Forms.Padding(3);
            this.tabs2.Size = new System.Drawing.Size(367, 352);
            this.tabs2.TabIndex = 1;
            this.tabs2.Text = "POS";
            this.tabs2.UseVisualStyleBackColor = true;
            // 
            // POSSubmit
            // 
            this.POSSubmit.Location = new System.Drawing.Point(140, 275);
            this.POSSubmit.Name = "POSSubmit";
            this.POSSubmit.Size = new System.Drawing.Size(75, 23);
            this.POSSubmit.TabIndex = 23;
            this.POSSubmit.Text = "Submit";
            this.POSSubmit.UseVisualStyleBackColor = true;
            this.POSSubmit.Click += new System.EventHandler(this.POSSubmit_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(140, 27);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(140, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(140, 137);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(140, 176);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 21;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(140, 228);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zipcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Salon Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Or";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Salon Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabs1.ResumeLayout(false);
            this.tabs1.PerformLayout();
            this.tabs2.ResumeLayout(false);
            this.tabs2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabs1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabs2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DesktopSubmit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button POSSubmit;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

