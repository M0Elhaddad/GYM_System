namespace GYM_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel3 = new Panel();
            panel2 = new Panel();
            showPassCheck = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txt_Email = new TextBox();
            txt_Pass = new TextBox();
            btn_Login = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_close = new Button();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1109, 631);
            panel3.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(showPassCheck);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_Email);
            panel2.Controls.Add(txt_Pass);
            panel2.Controls.Add(btn_Login);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(429, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 410);
            panel2.TabIndex = 24;
            // 
            // showPassCheck
            // 
            showPassCheck.AutoSize = true;
            showPassCheck.BackgroundImageLayout = ImageLayout.Center;
            showPassCheck.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPassCheck.ForeColor = Color.Black;
            showPassCheck.Location = new Point(54, 284);
            showPassCheck.Name = "showPassCheck";
            showPassCheck.Size = new Size(147, 27);
            showPassCheck.TabIndex = 2;
            showPassCheck.Text = "show password";
            showPassCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 53);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(156, 21);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 6;
            label3.Text = "LOGIN";
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.White;
            txt_Email.Font = new Font("Microsoft Uighur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Email.Location = new Point(54, 143);
            txt_Email.Margin = new Padding(3, 4, 3, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.PlaceholderText = "Enter Email";
            txt_Email.Size = new Size(342, 36);
            txt_Email.TabIndex = 0;
            // 
            // txt_Pass
            // 
            txt_Pass.BackColor = Color.White;
            txt_Pass.Font = new Font("Microsoft Uighur", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Pass.Location = new Point(54, 240);
            txt_Pass.Margin = new Padding(3, 4, 3, 4);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.PlaceholderText = "Enter Password";
            txt_Pass.Size = new Size(342, 37);
            txt_Pass.TabIndex = 1;
            txt_Pass.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Transparent;
            btn_Login.FlatAppearance.BorderColor = Color.White;
            btn_Login.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.Black;
            btn_Login.Location = new Point(125, 352);
            btn_Login.Margin = new Padding(3, 4, 3, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(127, 46);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 204);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 107);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = SystemColors.ActiveCaption;
            btn_close.Location = new Point(1064, 0);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(45, 43);
            btn_close.TabIndex = 5;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 43);
            panel1.TabIndex = 26;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 631);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private CheckBox showPassCheck;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txt_Email;
        private TextBox txt_Pass;
        private Button btn_Login;
        private Label label2;
        private Label label1;
        private Button btn_close;
        private Panel panel1;
    }
}
