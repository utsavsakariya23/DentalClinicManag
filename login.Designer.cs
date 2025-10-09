namespace DentalClinicManag
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UnameTb = new TextBox();
            UpassTb = new TextBox();
            button1 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 128);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(421, 5);
            label5.Name = "label5";
            label5.Size = new Size(23, 27);
            label5.TabIndex = 4;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(72, 148);
            label1.Name = "label1";
            label1.Size = new Size(309, 26);
            label1.TabIndex = 2;
            label1.Text = "Dental Clinic Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(25, 232);
            label2.Name = "label2";
            label2.Size = new Size(129, 27);
            label2.TabIndex = 3;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(25, 298);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Century Gothic", 13.8F);
            UnameTb.Location = new Point(187, 223);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(224, 36);
            UnameTb.TabIndex = 5;
            // 
            // UpassTb
            // 
            UpassTb.Font = new Font("Century Gothic", 13.8F);
            UpassTb.Location = new Point(187, 289);
            UpassTb.Name = "UpassTb";
            UpassTb.PasswordChar = '*';
            UpassTb.Size = new Size(224, 36);
            UpassTb.TabIndex = 6;
            UpassTb.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumVioletRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(117, 370);
            button1.Name = "button1";
            button1.Size = new Size(207, 43);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(178, 435);
            label4.Name = "label4";
            label4.Size = new Size(84, 26);
            label4.TabIndex = 8;
            label4.Text = "Admin";
            label4.Click += label4_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 494);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(UpassTb);
            Controls.Add(UnameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UnameTb;
        private TextBox UpassTb;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}