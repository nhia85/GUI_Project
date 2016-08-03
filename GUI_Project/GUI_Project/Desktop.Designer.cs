namespace GUI_Project
{
    partial class Desktop
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.zipcode = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to continue to Desktop Remote?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salon Number w/ Address";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(345, 218);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(42, 13);
            this.number.TabIndex = 6;
            this.number.Text = "number";
            // 
            // zipcode
            // 
            this.zipcode.AutoSize = true;
            this.zipcode.Location = new System.Drawing.Point(473, 270);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(44, 13);
            this.zipcode.TabIndex = 10;
            this.zipcode.Text = "zipcode";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(357, 270);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(30, 13);
            this.state.TabIndex = 9;
            this.state.Text = "state";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(215, 270);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(44, 13);
            this.address.TabIndex = 8;
            this.address.Text = "address";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(95, 270);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 11;
            this.name.Text = "name";
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.name);
            this.Controls.Add(this.zipcode);
            this.Controls.Add(this.state);
            this.Controls.Add(this.address);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label zipcode;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label name;
    }
}