namespace Tharini_Rajapaksha__00238334__Grifindo_Lanka_Toys
{
    partial class EmployeeLeaveHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLeaveHistory));
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semilight", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(719, 60);
            label4.Name = "label4";
            label4.Size = new Size(369, 46);
            label4.TabIndex = 48;
            label4.Text = "Employee Leave History";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(120, 29);
            label1.Name = "label1";
            label1.Size = new Size(401, 54);
            label1.TabIndex = 46;
            label1.Text = "Grifindo Lanka Toys";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 49;
            label2.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 161);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 50;
            label3.Text = "Start Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(644, 161);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 51;
            label5.Text = "End Date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 52;
            comboBox1.Text = "Select";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(373, 159);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 53;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(720, 159);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 54;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1076, 260);
            dataGridView1.TabIndex = 55;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(815, 482);
            button2.Name = "button2";
            button2.Size = new Size(273, 44);
            button2.TabIndex = 77;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(976, 153);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 78;
            button1.Text = "Show Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmployeeLeaveHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 529);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EmployeeLeaveHistory";
            Text = "EmployeeLeaveHistory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.ComboBox comboBoxLeaveType;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;

    }
}