namespace DentalClinicManag
{
    partial class appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointment));
            panel1 = new Panel();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Time = new DateTimePicker();
            Date = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            TreatmentCb = new ComboBox();
            PatientCb = new ComboBox();
            AppointmentDGV = new DataGridView();
            SearchTb = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 703);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(85, 643);
            label8.Name = "label8";
            label8.Size = new Size(90, 27);
            label8.TabIndex = 16;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 621);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(85, 367);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 10;
            label5.Text = "Prescription";
            label5.Click += label5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 345);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 290);
            label4.Name = "label4";
            label4.Size = new Size(128, 27);
            label4.TabIndex = 8;
            label4.Text = "Treatment";
            label4.Click += label4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 268);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 212);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 6;
            label3.Text = "Patient";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, 49);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 4;
            label2.Text = "Appointment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 19);
            label1.Name = "label1";
            label1.Size = new Size(158, 26);
            label1.TabIndex = 3;
            label1.Text = "Dental Clinic";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-68, -75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DodgerBlue;
            label9.Location = new Point(261, 19);
            label9.Name = "label9";
            label9.Size = new Size(206, 37);
            label9.TabIndex = 5;
            label9.Text = "Appointment";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Time);
            panel2.Controls.Add(Date);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(TreatmentCb);
            panel2.Controls.Add(PatientCb);
            panel2.Location = new Point(261, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(946, 234);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(419, 175);
            button3.Name = "button3";
            button3.Size = new Size(115, 33);
            button3.TabIndex = 28;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(565, 175);
            button2.Name = "button2";
            button2.Size = new Size(115, 33);
            button2.TabIndex = 27;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(254, 175);
            button1.Name = "button1";
            button1.Size = new Size(136, 33);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Time
            // 
            Time.CustomFormat = "";
            Time.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.Format = DateTimePickerFormat.Time;
            Time.Location = new Point(634, 110);
            Time.Name = "Time";
            Time.Size = new Size(250, 32);
            Time.TabIndex = 13;
            // 
            // Date
            // 
            Date.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(634, 34);
            Date.Name = "Date";
            Date.Size = new Size(250, 32);
            Date.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(513, 106);
            label13.Name = "label13";
            label13.Size = new Size(87, 37);
            label13.TabIndex = 10;
            label13.Text = "Time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(513, 30);
            label12.Name = "label12";
            label12.Size = new Size(84, 37);
            label12.TabIndex = 11;
            label12.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(48, 106);
            label11.Name = "label11";
            label11.Size = new Size(165, 37);
            label11.TabIndex = 10;
            label11.Text = "Treatment";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(48, 30);
            label10.Name = "label10";
            label10.Size = new Size(119, 37);
            label10.TabIndex = 9;
            label10.Text = "Patient";
            // 
            // TreatmentCb
            // 
            TreatmentCb.Font = new Font("Century Gothic", 13.8F);
            TreatmentCb.FormattingEnabled = true;
            TreatmentCb.Location = new Point(219, 110);
            TreatmentCb.Name = "TreatmentCb";
            TreatmentCb.Size = new Size(206, 35);
            TreatmentCb.TabIndex = 8;
            // 
            // PatientCb
            // 
            PatientCb.Font = new Font("Century Gothic", 13.8F);
            PatientCb.FormattingEnabled = true;
            PatientCb.Location = new Point(219, 34);
            PatientCb.Name = "PatientCb";
            PatientCb.Size = new Size(206, 35);
            PatientCb.TabIndex = 7;
            PatientCb.SelectedIndexChanged += PatientCb_SelectedIndexChanged;
            // 
            // AppointmentDGV
            // 
            AppointmentDGV.BackgroundColor = Color.White;
            AppointmentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AppointmentDGV.Location = new Point(261, 367);
            AppointmentDGV.Name = "AppointmentDGV";
            AppointmentDGV.RowHeadersWidth = 51;
            AppointmentDGV.Size = new Size(946, 303);
            AppointmentDGV.TabIndex = 7;
            AppointmentDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchTb
            // 
            SearchTb.ForeColor = Color.DodgerBlue;
            SearchTb.Location = new Point(637, 323);
            SearchTb.Name = "SearchTb";
            SearchTb.Size = new Size(168, 27);
            SearchTb.TabIndex = 8;
            SearchTb.Text = "Filter By Patient Name";
            SearchTb.TextChanged += SearchTb_TextChanged;
            // 
            // appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1265, 703);
            Controls.Add(SearchTb);
            Controls.Add(AppointmentDGV);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "appointment";
            Load += appointment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AppointmentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label8;
        private PictureBox pictureBox7;
        private Label label9;
        private Panel panel2;
        private ComboBox PatientCb;
        private Label label10;
        private ComboBox TreatmentCb;
        private DateTimePicker Time;
        private DateTimePicker Date;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button button1;
        private DataGridView AppointmentDGV;
        private TextBox SearchTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Button button2;
    }
}