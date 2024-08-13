namespace BankSystemc_
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            email = new TextBox();
            name = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            log = new Button();
            label4 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            createaccount = new Button();
            password = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Dock = DockStyle.Fill;
           // pictureBox1.Image = BankSystemc.Properties.Resources.i;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1111, 627);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(email);
            panel4.Controls.Add(name);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(log);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(createaccount);
            panel4.Controls.Add(password);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(334, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(405, 556);
            panel4.TabIndex = 17;
            panel4.Paint += panel4_Paint_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 491);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 12;
            label5.Text = "Don't Have Account?";
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            email.ForeColor = Color.FromArgb(0, 117, 214);
            email.Location = new Point(72, 283);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(267, 27);
            email.TabIndex = 3;
            // 
            // name
            // 
            name.BorderStyle = BorderStyle.None;
            name.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            name.ForeColor = Color.FromArgb(0, 117, 214);
            name.Location = new Point(72, 196);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(267, 27);
            name.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            panel1.Location = new Point(72, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 1);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            panel2.Location = new Point(72, 316);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 1);
            panel2.TabIndex = 9;
            // 
            // log
            // 
            log.BackColor = Color.FromArgb(0, 117, 214);
            log.FlatAppearance.BorderSize = 0;
            log.FlatStyle = FlatStyle.Flat;
            log.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log.ForeColor = Color.White;
            log.Location = new Point(72, 437);
            log.Name = "log";
            log.Size = new Size(267, 41);
            log.TabIndex = 6;
            log.Text = "LOG IN";
            log.UseVisualStyleBackColor = false;
            log.Click += log_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(131, 50);
            label4.Name = "label4";
            label4.Size = new Size(141, 45);
            label4.TabIndex = 11;
            label4.Text = "LOG IN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.Location = new Point(72, 407);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 1);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(72, 338);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(72, 248);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // createaccount
            // 
            createaccount.BackColor = Color.White;
            createaccount.FlatAppearance.BorderSize = 0;
            createaccount.FlatStyle = FlatStyle.Flat;
            createaccount.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            createaccount.ForeColor = Color.FromArgb(0, 117, 214);
            createaccount.Location = new Point(225, 484);
            createaccount.Name = "createaccount";
            createaccount.Size = new Size(75, 33);
            createaccount.TabIndex = 7;
            createaccount.Text = " SignUp";
            createaccount.UseVisualStyleBackColor = false;
            createaccount.Click += createaccount_Click_1;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            password.ForeColor = Color.FromArgb(0, 117, 214);
            password.Location = new Point(72, 374);
            password.Multiline = true;
            password.Name = "password";
            password.Size = new Size(267, 27);
            password.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(72, 158);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 0;
            label1.Text = "Name : ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1111, 627);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel4;
        private TextBox email;
        private TextBox name;
        private Panel panel1;
        private Panel panel2;
        private Button log;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Button createaccount;
        private TextBox password;
        private Label label1;
        private Label label5;
    }
}