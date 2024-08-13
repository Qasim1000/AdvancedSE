namespace BankSystemc_
{
    partial class Mainwindow
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
            components = new System.ComponentModel.Container();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Bauhaus 93", 26F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel1.Location = new Point(141, 138);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(522, 51);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Bank Management System";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Bauhaus 93", 18F);
            guna2HtmlLabel2.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel2.Location = new Point(250, 216);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(126, 36);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Loading :";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-2, 455);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(797, 29);
            progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Bauhaus 93", 16.2F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(465, 220);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 4;
            label1.Text = "0%";
            label1.Click += label1_Click;
            // 
            // mainwindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 117, 214);
            ClientSize = new Size(795, 496);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainwindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainwindow";
            Load += mainwindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}