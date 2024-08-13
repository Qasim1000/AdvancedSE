namespace BankSystemc_
{
    partial class Financial_Transactions
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
            DepsoitCash = new Button();
            Withdrawcash = new Button();
            Transfercash = new Button();
            button5 = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            balanced = new TextBox();
            label3 = new Label();
            accountd = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            label11 = new Label();
            balancet = new TextBox();
            label4 = new Label();
            taccountt = new TextBox();
            label5 = new Label();
            accountt = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            balancew = new TextBox();
            label10 = new Label();
            label9 = new Label();
            accountw = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DepsoitCash
            // 
            DepsoitCash.BackColor = Color.FromArgb(0, 117, 214);
            DepsoitCash.FlatStyle = FlatStyle.Flat;
            DepsoitCash.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            DepsoitCash.ForeColor = Color.White;
            DepsoitCash.Location = new Point(251, 209);
            DepsoitCash.Name = "DepsoitCash";
            DepsoitCash.Size = new Size(119, 43);
            DepsoitCash.TabIndex = 3;
            DepsoitCash.Text = "Deposit Cash";
            DepsoitCash.UseVisualStyleBackColor = false;
            DepsoitCash.Click += DepsoitCash_Click;
            // 
            // Withdrawcash
            // 
            Withdrawcash.BackColor = Color.FromArgb(0, 117, 214);
            Withdrawcash.FlatAppearance.BorderSize = 0;
            Withdrawcash.FlatStyle = FlatStyle.Flat;
            Withdrawcash.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            Withdrawcash.ForeColor = Color.White;
            Withdrawcash.Location = new Point(335, 208);
            Withdrawcash.Name = "Withdrawcash";
            Withdrawcash.Size = new Size(135, 41);
            Withdrawcash.TabIndex = 4;
            Withdrawcash.Text = "WithDraw";
            Withdrawcash.UseVisualStyleBackColor = false;
            Withdrawcash.Click += withdrawButton_Click;
            // 
            // Transfercash
            // 
            Transfercash.BackColor = Color.FromArgb(0, 117, 214);
            Transfercash.FlatStyle = FlatStyle.Flat;
            Transfercash.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            Transfercash.ForeColor = Color.White;
            Transfercash.Location = new Point(221, 290);
            Transfercash.Name = "Transfercash";
            Transfercash.Size = new Size(170, 41);
            Transfercash.TabIndex = 5;
            Transfercash.Text = "Transfer Funds";
            Transfercash.UseVisualStyleBackColor = false;
            Transfercash.Click += transferButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 117, 214);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(10, 671);
            button5.Name = "button5";
            button5.Size = new Size(94, 39);
            button5.TabIndex = 7;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(balanced);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(accountd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DepsoitCash);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 268);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 117, 214);
            panel6.Location = new Point(207, 198);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 1);
            panel6.TabIndex = 32;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 117, 214);
            panel5.Location = new Point(207, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 1);
            panel5.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(171, 13);
            label2.Name = "label2";
            label2.Size = new Size(178, 45);
            label2.TabIndex = 15;
            label2.Text = "DEPOSIT";
            label2.Click += label2_Click;
            // 
            // balanced
            // 
            balanced.BorderStyle = BorderStyle.None;
            balanced.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            balanced.ForeColor = Color.FromArgb(0, 117, 214);
            balanced.Location = new Point(207, 156);
            balanced.Multiline = true;
            balanced.Name = "balanced";
            balanced.Size = new Size(263, 36);
            balanced.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(79, 165);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 8;
            label3.Text = "Balance";
            // 
            // accountd
            // 
            accountd.BorderStyle = BorderStyle.None;
            accountd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            accountd.ForeColor = Color.FromArgb(0, 117, 214);
            accountd.Location = new Point(207, 97);
            accountd.Multiline = true;
            accountd.Name = "accountd";
            accountd.Size = new Size(263, 35);
            accountd.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(79, 97);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 4;
            label1.Text = " Account";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(balancet);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(taccountt);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(accountt);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(Transfercash);
            panel3.Location = new Point(10, 295);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 383);
            panel3.TabIndex = 10;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(0, 117, 214);
            panel11.Location = new Point(266, 276);
            panel11.Name = "panel11";
            panel11.Size = new Size(263, 1);
            panel11.TabIndex = 33;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 117, 214);
            panel10.Location = new Point(266, 216);
            panel10.Name = "panel10";
            panel10.Size = new Size(263, 1);
            panel10.TabIndex = 32;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 117, 214);
            panel9.Location = new Point(266, 155);
            panel9.Name = "panel9";
            panel9.Size = new Size(263, 1);
            panel9.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(0, 117, 214);
            label11.Location = new Point(198, 17);
            label11.Name = "label11";
            label11.Size = new Size(211, 45);
            label11.TabIndex = 16;
            label11.Text = "TRANSFER ";
            // 
            // balancet
            // 
            balancet.BorderStyle = BorderStyle.None;
            balancet.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            balancet.ForeColor = Color.FromArgb(0, 117, 214);
            balancet.Location = new Point(266, 228);
            balancet.Multiline = true;
            balancet.Name = "balancet";
            balancet.Size = new Size(263, 42);
            balancet.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(91, 237);
            label4.Name = "label4";
            label4.Size = new Size(82, 22);
            label4.TabIndex = 14;
            label4.Text = "Balance";
            // 
            // taccountt
            // 
            taccountt.BorderStyle = BorderStyle.None;
            taccountt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            taccountt.ForeColor = Color.FromArgb(0, 117, 214);
            taccountt.Location = new Point(266, 168);
            taccountt.Multiline = true;
            taccountt.Name = "taccountt";
            taccountt.Size = new Size(263, 42);
            taccountt.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(91, 182);
            label5.Name = "label5";
            label5.Size = new Size(112, 22);
            label5.TabIndex = 12;
            label5.Text = "To Account";
            // 
            // accountt
            // 
            accountt.BorderStyle = BorderStyle.None;
            accountt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            accountt.ForeColor = Color.FromArgb(0, 117, 214);
            accountt.Location = new Point(266, 105);
            accountt.Multiline = true;
            accountt.Name = "accountt";
            accountt.Size = new Size(263, 44);
            accountt.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveBorder;
            label6.Location = new Point(91, 104);
            label6.Name = "label6";
            label6.Size = new Size(133, 22);
            label6.TabIndex = 10;
            label6.Text = "From Account";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(balancew);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(Withdrawcash);
            panel4.Controls.Add(accountw);
            panel4.Location = new Point(586, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(736, 265);
            panel4.TabIndex = 11;
            panel4.Paint += panel4_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 117, 214);
            panel8.Location = new Point(449, 188);
            panel8.Name = "panel8";
            panel8.Size = new Size(263, 1);
            panel8.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 117, 214);
            panel7.Location = new Point(449, 122);
            panel7.Name = "panel7";
            panel7.Size = new Size(263, 1);
            panel7.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveBorder;
            label8.Location = new Point(187, 162);
            label8.Name = "label8";
            label8.Size = new Size(82, 22);
            label8.TabIndex = 16;
            label8.Text = "Balance";
            // 
            // balancew
            // 
            balancew.BorderStyle = BorderStyle.None;
            balancew.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            balancew.ForeColor = Color.FromArgb(0, 117, 214);
            balancew.Location = new Point(449, 145);
            balancew.Multiline = true;
            balancew.Name = "balancew";
            balancew.Size = new Size(263, 39);
            balancew.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(0, 117, 214);
            label10.Location = new Point(187, 13);
            label10.Name = "label10";
            label10.Size = new Size(228, 45);
            label10.TabIndex = 17;
            label10.Text = "WITHDRAW";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveBorder;
            label9.Location = new Point(187, 94);
            label9.Name = "label9";
            label9.Size = new Size(82, 22);
            label9.TabIndex = 10;
            label9.Text = "Account";
            // 
            // accountw
            // 
            accountw.BorderStyle = BorderStyle.None;
            accountw.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            accountw.ForeColor = Color.FromArgb(0, 117, 214);
            accountw.Location = new Point(449, 77);
            accountw.Multiline = true;
            accountw.Name = "accountw";
            accountw.Size = new Size(263, 39);
            accountw.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 117, 214);
            label7.Location = new Point(293, 6);
            label7.Name = "label7";
            label7.Size = new Size(177, 45);
            label7.TabIndex = 14;
            label7.Text = "HISTORY";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(586, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 383);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(719, 298);
            dataGridView1.TabIndex = 15;
            // 
            // Financial_Transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 117, 214);
            ClientSize = new Size(1334, 722);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button5);
            Name = "Financial_Transactions";
            Text = "Financial_Transactions";
            Load += Financial_Transactions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button DepsoitCash;
        private Button Withdrawcash;
        private Button Transfercash;
        private Button button5;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private TextBox accountd;
        private Label label1;
        private TextBox balanced;
        private Label label3;
        private TextBox balancet;
        private Label label4;
        private TextBox taccountt;
        private Label label5;
        private TextBox accountt;
        private Label label6;
        private TextBox balancew;
        private Label label7;
        private TextBox accountw;
        private Label label9;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label2;
        private Label label11;
        private Label label10;
        private Panel panel6;
        private Panel panel5;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
    }
}