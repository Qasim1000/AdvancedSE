namespace BankSystemc_
{
    partial class PaymentMethord
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            detail = new TextBox();
            label2 = new Label();
            amount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            datetime = new DateTimePicker();
            Submit = new Button();
            Back = new Button();
            dataGridView1 = new DataGridView();
            acn = new TextBox();
            label5 = new Label();
            type = new Guna.UI2.WinForms.Guna2ComboBox();
            panel3 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(104, 68);
            label1.Name = "label1";
            label1.Size = new Size(61, 22);
            label1.TabIndex = 0;
            label1.Text = "Type ";
            // 
            // detail
            // 
            detail.BorderStyle = BorderStyle.None;
            detail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            detail.ForeColor = Color.FromArgb(0, 117, 214);
            detail.Location = new Point(304, 111);
            detail.Multiline = true;
            detail.Name = "detail";
            detail.Size = new Size(310, 36);
            detail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(103, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 2;
            label2.Text = "Detail";
            // 
            // amount
            // 
            amount.BorderStyle = BorderStyle.None;
            amount.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            amount.ForeColor = Color.FromArgb(0, 117, 214);
            amount.Location = new Point(304, 167);
            amount.Multiline = true;
            amount.Name = "amount";
            amount.Size = new Size(310, 36);
            amount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(103, 186);
            label3.Name = "label3";
            label3.Size = new Size(77, 22);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(103, 276);
            label4.Name = "label4";
            label4.Size = new Size(132, 22);
            label4.TabIndex = 6;
            label4.Text = "Set DateTime";
            // 
            // datetime
            // 
            datetime.Location = new Point(304, 271);
            datetime.Name = "datetime";
            datetime.Size = new Size(310, 27);
            datetime.TabIndex = 7;
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(0, 117, 214);
            Submit.FlatAppearance.BorderSize = 0;
            Submit.FlatStyle = FlatStyle.Flat;
            Submit.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            Submit.ForeColor = Color.White;
            Submit.Location = new Point(356, 314);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 38);
            Submit.TabIndex = 8;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += button1_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(0, 117, 214);
            Back.FlatAppearance.BorderSize = 0;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            Back.ForeColor = Color.White;
            Back.Location = new Point(12, 552);
            Back.Name = "Back";
            Back.Size = new Size(94, 39);
            Back.TabIndex = 9;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(849, 210);
            dataGridView1.TabIndex = 10;
            // 
            // acn
            // 
            acn.BorderStyle = BorderStyle.None;
            acn.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            acn.ForeColor = Color.FromArgb(0, 117, 214);
            acn.Location = new Point(304, 217);
            acn.Multiline = true;
            acn.Name = "acn";
            acn.Size = new Size(310, 36);
            acn.TabIndex = 13;
            acn.TextChanged += acn_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(103, 232);
            label5.Name = "label5";
            label5.Size = new Size(157, 22);
            label5.TabIndex = 12;
            label5.Text = "Account Number";
            label5.Click += label5_Click;
            // 
            // type
            // 
            type.BackColor = Color.Transparent;
            type.CustomizableEdges = customizableEdges3;
            type.DrawMode = DrawMode.OwnerDrawFixed;
            type.DropDownStyle = ComboBoxStyle.DropDownList;
            type.FocusedColor = Color.FromArgb(94, 148, 255);
            type.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            type.Font = new Font("Segoe UI", 10F);
            type.ForeColor = Color.FromArgb(68, 88, 112);
            type.ItemHeight = 30;
            type.Location = new Point(304, 54);
            type.Name = "type";
            type.ShadowDecoration.CustomizableEdges = customizableEdges4;
            type.Size = new Size(310, 36);
            type.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.Location = new Point(304, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 1);
            panel3.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Location = new Point(306, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 1);
            panel1.TabIndex = 34;
            // 
            // PaymentMethord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 592);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(type);
            Controls.Add(acn);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(Back);
            Controls.Add(Submit);
            Controls.Add(datetime);
            Controls.Add(label4);
            Controls.Add(amount);
            Controls.Add(label3);
            Controls.Add(detail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PaymentMethord";
            Text = "PaymentMethord";
            Load += PaymentMethord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox detail;
        private Label label2;
        private TextBox amount;
        private Label label3;
        private Label label4;
        private DateTimePicker datetime;
        private Button Submit;
        private Button Back;
        private DataGridView dataGridView1;
        private TextBox acn;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox type;
        private Panel panel3;
        private Panel panel1;
    }
}