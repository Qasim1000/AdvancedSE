namespace BankSystemc_
{
    partial class Service
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
            servicedetailed = new TextBox();
            label2 = new Label();
            btnsubmit = new Button();
            back = new Button();
            dataGridView1 = new DataGridView();
            servicetype = new Guna.UI2.WinForms.Guna2ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(97, 17);
            label1.Name = "label1";
            label1.Size = new Size(163, 22);
            label1.TabIndex = 0;
            label1.Text = "Select Service :  ";
            // 
            // servicedetailed
            // 
            servicedetailed.BorderStyle = BorderStyle.None;
            servicedetailed.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            servicedetailed.ForeColor = Color.FromArgb(0, 117, 214);
            servicedetailed.Location = new Point(266, 72);
            servicedetailed.Multiline = true;
            servicedetailed.Name = "servicedetailed";
            servicedetailed.Size = new Size(271, 33);
            servicedetailed.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(97, 83);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 3;
            label2.Text = "Admit Detail : ";
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.FromArgb(0, 117, 214);
            btnsubmit.FlatAppearance.BorderSize = 0;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(312, 140);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(188, 50);
            btnsubmit.TabIndex = 4;
            btnsubmit.Text = "Submit Request";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(0, 117, 214);
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold);
            back.ForeColor = Color.White;
            back.Location = new Point(2, 544);
            back.Name = "back";
            back.Size = new Size(94, 34);
            back.TabIndex = 5;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(720, 267);
            dataGridView1.TabIndex = 6;
            // 
            // servicetype
            // 
            servicetype.BackColor = Color.Transparent;
            servicetype.CustomizableEdges = customizableEdges3;
            servicetype.DrawMode = DrawMode.OwnerDrawFixed;
            servicetype.DropDownStyle = ComboBoxStyle.DropDownList;
            servicetype.FocusedColor = Color.FromArgb(94, 148, 255);
            servicetype.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            servicetype.Font = new Font("Segoe UI", 10F);
            servicetype.ForeColor = Color.FromArgb(68, 88, 112);
            servicetype.ItemHeight = 30;
            servicetype.Location = new Point(266, 17);
            servicetype.Name = "servicetype";
            servicetype.ShadowDecoration.CustomizableEdges = customizableEdges4;
            servicetype.Size = new Size(271, 36);
            servicetype.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            panel1.Location = new Point(266, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 1);
            panel1.TabIndex = 9;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(panel1);
            Controls.Add(servicetype);
            Controls.Add(dataGridView1);
            Controls.Add(back);
            Controls.Add(btnsubmit);
            Controls.Add(label2);
            Controls.Add(servicedetailed);
            Controls.Add(label1);
            Name = "Service";
            Text = "Service";
            Load += Service_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox servicedetailed;
        private Label label2;
        private Button btnsubmit;
        private Button back;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox servicetype;
        private Panel panel1;
    }
}