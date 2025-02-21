namespace GYM_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pl_Containar = new Panel();
            panel1 = new Panel();
            btn_close = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_Logout = new Button();
            btn_Category = new Button();
            btn_Users = new Button();
            btn_GetProduct = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pl_Containar
            // 
            pl_Containar.BackColor = Color.FromArgb(0, 0, 20);
            pl_Containar.Dock = DockStyle.Bottom;
            pl_Containar.Location = new Point(0, 116);
            pl_Containar.Margin = new Padding(3, 4, 3, 4);
            pl_Containar.Name = "pl_Containar";
            pl_Containar.Size = new Size(1109, 515);
            pl_Containar.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 20);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 47);
            panel1.TabIndex = 35;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.FromArgb(0, 0, 20);
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btn_close.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.ForeColor = SystemColors.ActiveCaption;
            btn_close.Location = new Point(1064, 0);
            btn_close.Margin = new Padding(3, 4, 3, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(45, 47);
            btn_close.TabIndex = 26;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 20);
            label2.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(519, 5);
            label2.Name = "label2";
            label2.Size = new Size(134, 40);
            label2.TabIndex = 25;
            label2.Text = "Hulk GYM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 20);
            label1.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 33);
            label1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 20);
            panel2.Controls.Add(btn_Logout);
            panel2.Controls.Add(btn_Category);
            panel2.Controls.Add(btn_Users);
            panel2.Controls.Add(btn_GetProduct);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 47);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 69);
            panel2.TabIndex = 36;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.FromArgb(0, 0, 20);
            btn_Logout.Dock = DockStyle.Right;
            btn_Logout.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_Logout.ForeColor = SystemColors.ActiveCaption;
            btn_Logout.Location = new Point(880, 0);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(229, 69);
            btn_Logout.TabIndex = 28;
            btn_Logout.Text = "LogOut";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_Category
            // 
            btn_Category.BackColor = Color.FromArgb(0, 0, 20);
            btn_Category.Dock = DockStyle.Left;
            btn_Category.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_Category.FlatStyle = FlatStyle.Flat;
            btn_Category.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_Category.ForeColor = SystemColors.ActiveCaption;
            btn_Category.Location = new Point(458, 0);
            btn_Category.Margin = new Padding(3, 4, 3, 4);
            btn_Category.Name = "btn_Category";
            btn_Category.Size = new Size(229, 69);
            btn_Category.TabIndex = 27;
            btn_Category.Text = "Categories";
            btn_Category.UseVisualStyleBackColor = false;
            // 
            // btn_Users
            // 
            btn_Users.BackColor = Color.FromArgb(0, 0, 20);
            btn_Users.Dock = DockStyle.Left;
            btn_Users.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_Users.FlatStyle = FlatStyle.Flat;
            btn_Users.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_Users.ForeColor = SystemColors.ActiveCaption;
            btn_Users.Location = new Point(229, 0);
            btn_Users.Margin = new Padding(3, 4, 3, 4);
            btn_Users.Name = "btn_Users";
            btn_Users.Size = new Size(229, 69);
            btn_Users.TabIndex = 26;
            btn_Users.Text = "Users";
            btn_Users.UseVisualStyleBackColor = false;
            // 
            // btn_GetProduct
            // 
            btn_GetProduct.BackColor = Color.FromArgb(0, 0, 20);
            btn_GetProduct.Dock = DockStyle.Left;
            btn_GetProduct.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_GetProduct.FlatStyle = FlatStyle.Flat;
            btn_GetProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_GetProduct.ForeColor = SystemColors.ActiveCaption;
            btn_GetProduct.Location = new Point(0, 0);
            btn_GetProduct.Margin = new Padding(3, 4, 3, 4);
            btn_GetProduct.Name = "btn_GetProduct";
            btn_GetProduct.Size = new Size(229, 69);
            btn_GetProduct.TabIndex = 25;
            btn_GetProduct.Text = "Trainee";
            btn_GetProduct.UseVisualStyleBackColor = false;
            btn_GetProduct.Click += btn_GetProduct_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 631);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pl_Containar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pl_Containar;
        private Panel panel1;
        private Button btn_close;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btn_Logout;
        private Button btn_Category;
        private Button btn_Users;
        private Button btn_GetProduct;
    }
}