namespace BankSystemc_
{
    partial class Otp
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
            txtotp = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            lgn = new Button();
            panel6 = new Panel();
            otpverify = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtotp
            // 
            txtotp.BorderStyle = BorderStyle.None;
            txtotp.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            txtotp.ForeColor = Color.FromArgb(0, 117, 214);
            txtotp.Location = new Point(44, 155);
            txtotp.Multiline = true;
            txtotp.Name = "txtotp";
            txtotp.Size = new Size(277, 35);
            txtotp.TabIndex = 7;
            txtotp.TextChanged += txtotp_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(94, 101);
            label1.Name = "label1";
            label1.Size = new Size(153, 22);
            label1.TabIndex = 6;
            label1.Text = "Enter Your OTP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lgn);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(otpverify);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtotp);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(243, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 365);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // lgn
            // 
            lgn.BackColor = Color.White;
            lgn.FlatAppearance.BorderSize = 0;
            lgn.FlatStyle = FlatStyle.Flat;
            lgn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lgn.ForeColor = Color.FromArgb(0, 117, 214);
            lgn.Location = new Point(136, 315);
            lgn.Name = "lgn";
            lgn.Size = new Size(60, 37);
            lgn.TabIndex = 34;
            lgn.Text = "Login";
            lgn.UseVisualStyleBackColor = false;
            lgn.Click += lgn_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 117, 214);
            panel6.Location = new Point(44, 196);
            panel6.Name = "panel6";
            panel6.Size = new Size(275, 1);
            panel6.TabIndex = 33;
            // 
            // otpverify
            // 
            otpverify.BackColor = Color.FromArgb(0, 117, 214);
            otpverify.FlatAppearance.BorderSize = 0;
            otpverify.FlatStyle = FlatStyle.Flat;
            otpverify.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            otpverify.ForeColor = Color.White;
            otpverify.Location = new Point(94, 259);
            otpverify.Name = "otpverify";
            otpverify.Size = new Size(153, 50);
            otpverify.TabIndex = 17;
            otpverify.Text = "Confirm OTP";
            otpverify.UseVisualStyleBackColor = false;
            otpverify.Click += otpverify_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(340, 45);
            label2.TabIndex = 16;
            label2.Text = "OTP Verifacation";
            // 
            // otp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 117, 214);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "otp";
            Text = "otp";
            Load += otp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtotp;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button otpverify;
        private Panel panel6;
        private Button lgn;
    }
}