namespace ResponsiJuniorProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label3 = new Label();
            label4 = new Label();
            dgvData = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 83);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 123);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan   :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(129, 80);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(227, 23);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(129, 120);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(227, 23);
            cbDep.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(55, 181);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(159, 181);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(265, 181);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 21);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 2;
            label3.Text = "Tech Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 8;
            label4.Text = "ID Departemen :";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(16, 222);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(487, 240);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(371, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 136);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 33);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 9;
            label5.Text = "HR : HR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 53);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 10;
            label6.Text = "ENG : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(13, 72);
            label7.Name = "label7";
            label7.Size = new Size(104, 17);
            label7.TabIndex = 11;
            label7.Text = "DEV : Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 90);
            label8.Name = "label8";
            label8.Size = new Size(103, 17);
            label8.TabIndex = 12;
            label8.Text = "PM : Product M";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 109);
            label9.Name = "label9";
            label9.Size = new Size(86, 17);
            label9.TabIndex = 13;
            label9.Text = "FIN : Finance";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 49);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 487);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNama;
        private ComboBox cbDep;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label label3;
        private Label label4;
        private DataGridView dgvData;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
    }
}