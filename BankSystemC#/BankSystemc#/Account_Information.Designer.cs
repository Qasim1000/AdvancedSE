namespace BankSystemc_
{
    partial class Account_Information
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
            dataGridView1 = new DataGridView();
            back = new Button();
            label2 = new Label();
            account = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 308);
            dataGridView1.TabIndex = 16;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(0, 117, 214);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            back.ForeColor = Color.White;
            back.Location = new Point(-3, 453);
            back.Name = "back";
            back.Size = new Size(82, 34);
            back.TabIndex = 20;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 66);
            label2.Name = "label2";
            label2.Size = new Size(175, 22);
            label2.TabIndex = 21;
            label2.Text = "Account Number : ";
            // 
            // account
            // 
            account.BorderStyle = BorderStyle.None;
            account.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            account.ForeColor = Color.FromArgb(0, 117, 214);
            account.Location = new Point(305, 66);
            account.Multiline = true;
            account.Name = "account";
            account.Size = new Size(267, 27);
            account.TabIndex = 30;
            // 
            // Account_Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 117, 214);
            ClientSize = new Size(800, 494);
            Controls.Add(account);
            Controls.Add(label2);
            Controls.Add(back);
            Controls.Add(dataGridView1);
            Name = "Account_Information";
            Text = "Account_Information";
            Load += Account_Information_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button back;
        private Label label2;
        private TextBox account;
    }
}