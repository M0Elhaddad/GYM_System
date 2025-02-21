namespace GYM_System.Pages
{
    partial class TraineePage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_UpdateTrainee = new Button();
            btn_AddTrainee = new Button();
            label7 = new Label();
            btn_DeleteTrainee = new Button();
            btn_Search = new Button();
            txt_Search = new TextBox();
            cmb_Category = new ComboBox();
            label2 = new Label();
            dgv_Trainee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Trainee).BeginInit();
            SuspendLayout();
            // 
            // btn_UpdateTrainee
            // 
            btn_UpdateTrainee.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_UpdateTrainee.FlatStyle = FlatStyle.Flat;
            btn_UpdateTrainee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_UpdateTrainee.ForeColor = SystemColors.ActiveCaption;
            btn_UpdateTrainee.Location = new Point(408, 448);
            btn_UpdateTrainee.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateTrainee.Name = "btn_UpdateTrainee";
            btn_UpdateTrainee.Size = new Size(263, 55);
            btn_UpdateTrainee.TabIndex = 81;
            btn_UpdateTrainee.Text = "Update Trainee";
            btn_UpdateTrainee.UseVisualStyleBackColor = true;
            // 
            // btn_AddTrainee
            // 
            btn_AddTrainee.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_AddTrainee.FlatStyle = FlatStyle.Flat;
            btn_AddTrainee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_AddTrainee.ForeColor = SystemColors.ActiveCaption;
            btn_AddTrainee.Location = new Point(117, 448);
            btn_AddTrainee.Margin = new Padding(3, 4, 3, 4);
            btn_AddTrainee.Name = "btn_AddTrainee";
            btn_AddTrainee.Size = new Size(263, 55);
            btn_AddTrainee.TabIndex = 80;
            btn_AddTrainee.Text = "Add Trainee";
            btn_AddTrainee.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(462, 79);
            label7.Name = "label7";
            label7.Size = new Size(165, 37);
            label7.TabIndex = 79;
            label7.Text = "All Trainees";
            // 
            // btn_DeleteTrainee
            // 
            btn_DeleteTrainee.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_DeleteTrainee.FlatStyle = FlatStyle.Flat;
            btn_DeleteTrainee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_DeleteTrainee.ForeColor = SystemColors.ActiveCaption;
            btn_DeleteTrainee.Location = new Point(700, 448);
            btn_DeleteTrainee.Margin = new Padding(3, 4, 3, 4);
            btn_DeleteTrainee.Name = "btn_DeleteTrainee";
            btn_DeleteTrainee.Size = new Size(263, 55);
            btn_DeleteTrainee.TabIndex = 75;
            btn_DeleteTrainee.Text = "Delete Trainee";
            btn_DeleteTrainee.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            btn_Search.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.ForeColor = SystemColors.ActiveCaption;
            btn_Search.Location = new Point(993, 14);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 35);
            btn_Search.TabIndex = 78;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            txt_Search.BackColor = SystemColors.ControlLightLight;
            txt_Search.Font = new Font("Microsoft Uighur", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Search.Location = new Point(777, 14);
            txt_Search.Margin = new Padding(3, 4, 3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Search for Trainee";
            txt_Search.Size = new Size(209, 32);
            txt_Search.TabIndex = 77;
            // 
            // cmb_Category
            // 
            cmb_Category.BackColor = Color.Cornsilk;
            cmb_Category.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Category.ForeColor = SystemColors.ControlText;
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new Point(176, 16);
            cmb_Category.Margin = new Padding(3, 4, 3, 4);
            cmb_Category.Name = "cmb_Category";
            cmb_Category.Size = new Size(204, 29);
            cmb_Category.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(4, 11);
            label2.Name = "label2";
            label2.Size = new Size(163, 37);
            label2.TabIndex = 74;
            label2.Text = "Select Type";
            // 
            // dgv_Trainee
            // 
            dgv_Trainee.AllowUserToAddRows = false;
            dgv_Trainee.AllowUserToResizeColumns = false;
            dgv_Trainee.AllowUserToResizeRows = false;
            dgv_Trainee.BackgroundColor = Color.FromArgb(0, 0, 20);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 40, 65);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Trainee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Trainee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Trainee.Location = new Point(1, 120);
            dgv_Trainee.Margin = new Padding(3, 4, 3, 4);
            dgv_Trainee.MultiSelect = false;
            dgv_Trainee.Name = "dgv_Trainee";
            dgv_Trainee.RowHeadersWidth = 51;
            dgv_Trainee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Trainee.Size = new Size(1094, 303);
            dgv_Trainee.TabIndex = 73;
            // 
            // TraineePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 20);
            Controls.Add(btn_UpdateTrainee);
            Controls.Add(btn_AddTrainee);
            Controls.Add(label7);
            Controls.Add(btn_DeleteTrainee);
            Controls.Add(btn_Search);
            Controls.Add(txt_Search);
            Controls.Add(cmb_Category);
            Controls.Add(label2);
            Controls.Add(dgv_Trainee);
            Name = "TraineePage";
            Size = new Size(1097, 515);
            Load += TraineePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Trainee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_UpdateTrainee;
        private Button btn_AddTrainee;
        private Label label7;
        private Button btn_DeleteTrainee;
        private Button btn_Search;
        private TextBox txt_Search;
        private ComboBox cmb_Category;
        private Label label2;
        private DataGridView dgv_Trainee;
    }
}
