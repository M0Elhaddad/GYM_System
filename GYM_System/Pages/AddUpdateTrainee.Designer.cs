namespace GYM_System.Pages
{
    partial class AddUpdateTrainee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmb_Exercise = new ComboBox();
            btn_Update = new Button();
            btn_Add = new Button();
            txt_Age = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label_Name = new Label();
            txt_TraineeName = new TextBox();
            lab_Type = new Label();
            label1 = new Label();
            cmb_Subscribtion = new ComboBox();
            label4 = new Label();
            dt_Expire = new DateTimePicker();
            Phone = new Label();
            txt_Phone = new TextBox();
            dt_Subscription = new DateTimePicker();
            label3 = new Label();
            name_validation = new Label();
            age_validation = new Label();
            phone_validation = new Label();
            SuspendLayout();
            // 
            // cmb_Exercise
            // 
            cmb_Exercise.BackColor = Color.White;
            cmb_Exercise.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Exercise.ForeColor = SystemColors.ControlText;
            cmb_Exercise.FormattingEnabled = true;
            cmb_Exercise.Location = new Point(25, 330);
            cmb_Exercise.Margin = new Padding(3, 4, 3, 4);
            cmb_Exercise.Name = "cmb_Exercise";
            cmb_Exercise.Size = new Size(342, 36);
            cmb_Exercise.TabIndex = 94;
            // 
            // btn_Update
            // 
            btn_Update.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_Update.ForeColor = SystemColors.ActiveCaption;
            btn_Update.Location = new Point(896, 307);
            btn_Update.Margin = new Padding(3, 4, 3, 4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(151, 55);
            btn_Update.TabIndex = 93;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_Add.ForeColor = SystemColors.ActiveCaption;
            btn_Add.Location = new Point(896, 360);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(151, 55);
            btn_Add.TabIndex = 92;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_Age
            // 
            txt_Age.Font = new Font("Microsoft Tai Le", 13.8F);
            txt_Age.Location = new Point(25, 225);
            txt_Age.Margin = new Padding(3, 4, 3, 4);
            txt_Age.MaxLength = 2;
            txt_Age.Name = "txt_Age";
            txt_Age.PlaceholderText = "Enter Age";
            txt_Age.Size = new Size(342, 37);
            txt_Age.TabIndex = 91;
            txt_Age.KeyPress += txt_Age_KeyPress;
            txt_Age.KeyUp += txt_Age_KeyUp;
            txt_Age.Leave += txt_Age_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(25, 183);
            label5.Name = "label5";
            label5.Size = new Size(69, 38);
            label5.TabIndex = 90;
            label5.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(25, 288);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 89;
            label2.Text = "Type of Exercise";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label_Name.ForeColor = SystemColors.ActiveCaption;
            label_Name.Location = new Point(25, 71);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(95, 38);
            label_Name.TabIndex = 88;
            label_Name.Text = "Name";
            // 
            // txt_TraineeName
            // 
            txt_TraineeName.Font = new Font("Microsoft Tai Le", 13.8F);
            txt_TraineeName.Location = new Point(25, 113);
            txt_TraineeName.Margin = new Padding(3, 4, 3, 4);
            txt_TraineeName.MaxLength = 50;
            txt_TraineeName.Name = "txt_TraineeName";
            txt_TraineeName.PlaceholderText = "Enter Trainee Name";
            txt_TraineeName.Size = new Size(342, 37);
            txt_TraineeName.TabIndex = 87;
            txt_TraineeName.KeyUp += txt_TraineeName_KeyUp;
            txt_TraineeName.Leave += txt_TraineeName_Leave;
            // 
            // lab_Type
            // 
            lab_Type.AutoSize = true;
            lab_Type.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lab_Type.ForeColor = SystemColors.ActiveCaption;
            lab_Type.Location = new Point(461, 18);
            lab_Type.Name = "lab_Type";
            lab_Type.Size = new Size(0, 37);
            lab_Type.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(501, 288);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 98;
            label1.Text = "Date of Expire";
            // 
            // cmb_Subscribtion
            // 
            cmb_Subscribtion.BackColor = Color.White;
            cmb_Subscribtion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Subscribtion.ForeColor = SystemColors.ControlText;
            cmb_Subscribtion.FormattingEnabled = true;
            cmb_Subscribtion.Location = new Point(501, 439);
            cmb_Subscribtion.Margin = new Padding(3, 4, 3, 4);
            cmb_Subscribtion.Name = "cmb_Subscribtion";
            cmb_Subscribtion.Size = new Size(342, 36);
            cmb_Subscribtion.TabIndex = 101;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(501, 397);
            label4.Name = "label4";
            label4.Size = new Size(287, 38);
            label4.TabIndex = 100;
            label4.Text = "Type of Subscription";
            // 
            // dt_Expire
            // 
            dt_Expire.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dt_Expire.Location = new Point(501, 340);
            dt_Expire.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dt_Expire.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dt_Expire.Name = "dt_Expire";
            dt_Expire.Size = new Size(342, 34);
            dt_Expire.TabIndex = 102;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            Phone.ForeColor = SystemColors.ActiveCaption;
            Phone.Location = new Point(25, 397);
            Phone.Name = "Phone";
            Phone.Size = new Size(100, 38);
            Phone.TabIndex = 104;
            Phone.Text = "Phone";
            // 
            // txt_Phone
            // 
            txt_Phone.Font = new Font("Microsoft Tai Le", 13.8F);
            txt_Phone.Location = new Point(25, 439);
            txt_Phone.Margin = new Padding(3, 4, 3, 4);
            txt_Phone.MaxLength = 11;
            txt_Phone.Name = "txt_Phone";
            txt_Phone.PlaceholderText = "Enter Trainee Phone";
            txt_Phone.Size = new Size(342, 37);
            txt_Phone.TabIndex = 103;
            txt_Phone.KeyPress += txt_Phone_KeyPress;
            txt_Phone.KeyUp += txt_Phone_KeyUp;
            txt_Phone.Leave += txt_Phone_Leave;
            // 
            // dt_Subscription
            // 
            dt_Subscription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dt_Subscription.Location = new Point(501, 235);
            dt_Subscription.Name = "dt_Subscription";
            dt_Subscription.Size = new Size(342, 34);
            dt_Subscription.TabIndex = 106;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(501, 183);
            label3.Name = "label3";
            label3.Size = new Size(287, 38);
            label3.TabIndex = 105;
            label3.Text = "Date of Subscription";
            // 
            // name_validation
            // 
            name_validation.AutoSize = true;
            name_validation.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_validation.ForeColor = Color.FromArgb(192, 0, 0);
            name_validation.Location = new Point(25, 154);
            name_validation.Name = "name_validation";
            name_validation.Size = new Size(0, 25);
            name_validation.TabIndex = 107;
            // 
            // age_validation
            // 
            age_validation.AutoSize = true;
            age_validation.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            age_validation.ForeColor = Color.FromArgb(192, 0, 0);
            age_validation.Location = new Point(25, 266);
            age_validation.Name = "age_validation";
            age_validation.Size = new Size(0, 25);
            age_validation.TabIndex = 108;
            // 
            // phone_validation
            // 
            phone_validation.AutoSize = true;
            phone_validation.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone_validation.ForeColor = Color.FromArgb(192, 0, 0);
            phone_validation.Location = new Point(25, 480);
            phone_validation.Name = "phone_validation";
            phone_validation.Size = new Size(0, 25);
            phone_validation.TabIndex = 109;
            // 
            // AddUpdateTrainee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 20);
            Controls.Add(phone_validation);
            Controls.Add(age_validation);
            Controls.Add(name_validation);
            Controls.Add(dt_Subscription);
            Controls.Add(label3);
            Controls.Add(Phone);
            Controls.Add(txt_Phone);
            Controls.Add(dt_Expire);
            Controls.Add(cmb_Subscribtion);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cmb_Exercise);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(txt_Age);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label_Name);
            Controls.Add(txt_TraineeName);
            Controls.Add(lab_Type);
            Name = "AddUpdateTrainee";
            Size = new Size(1097, 515);
            Load += AddUpdateTrainee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Exercise;
        private Button btn_Update;
        private Button btn_Add;
        private TextBox txt_Age;
        private Label label5;
        private Label label2;
        private Label label_Name;
        private TextBox txt_TraineeName;
        private Label lab_Type;
        private Label label1;
        private ComboBox cmb_Subscribtion;
        private Label label4;
        private DateTimePicker dt_Expire;
        private Label Phone;
        private TextBox txt_Phone;
        private DateTimePicker dt_Subscription;
        private Label label3;
        private Label name_validation;
        private Label age_validation;
        private Label phone_validation;
    }
}
