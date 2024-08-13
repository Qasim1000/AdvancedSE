namespace BankSystemc_
{
    partial class Delete
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
            button2 = new Button();
            panel1 = new Panel();
            label11 = new Label();
            panel5 = new Panel();
            button1 = new Button();
            accountnumber = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 117, 214);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(105, 401);
            button2.Name = "button2";
            button2.Size = new Size(94, 44);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(accountnumber);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(105, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 351);
            panel1.TabIndex = 33;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(0, 117, 214);
            label11.Location = new Point(209, 46);
            label11.Name = "label11";
            label11.Size = new Size(146, 45);
            label11.TabIndex = 37;
            label11.Text = "DELETE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 117, 214);
            panel5.Location = new Point(167, 174);
            panel5.Name = "panel5";
            panel5.Size = new Size(296, 1);
            panel5.TabIndex = 36;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(234, 215);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 35;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // accountnumber
            // 
            accountnumber.BorderStyle = BorderStyle.None;
            accountnumber.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            accountnumber.ForeColor = Color.FromArgb(0, 117, 214);
            accountnumber.Location = new Point(184, 146);
            accountnumber.Name = "accountnumber";
            accountnumber.Size = new Size(308, 21);
            accountnumber.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(62, 153);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 33;
            label1.Text = "Account :";
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 117, 214);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Name = "Delete";
            Text = "Delete";
            Load += Delete_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Panel panel1;
        private Panel panel5;
        private Button button1;
        private Label label1;
        private Label label11;
        public TextBox accountnumber;
    }
}