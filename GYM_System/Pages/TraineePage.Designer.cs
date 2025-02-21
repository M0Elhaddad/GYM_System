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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_UpdateProduct = new Button();
            btn_AddProduct = new Button();
            label7 = new Label();
            btn_DeleteProduct = new Button();
            btn_Search = new Button();
            txt_Search = new TextBox();
            cmb_Category = new ComboBox();
            label2 = new Label();
            dgv_Products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).BeginInit();
            SuspendLayout();
            // 
            // btn_UpdateProduct
            // 
            btn_UpdateProduct.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_UpdateProduct.FlatStyle = FlatStyle.Flat;
            btn_UpdateProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_UpdateProduct.ForeColor = SystemColors.ActiveCaption;
            btn_UpdateProduct.Location = new Point(408, 448);
            btn_UpdateProduct.Margin = new Padding(3, 4, 3, 4);
            btn_UpdateProduct.Name = "btn_UpdateProduct";
            btn_UpdateProduct.Size = new Size(263, 55);
            btn_UpdateProduct.TabIndex = 81;
            btn_UpdateProduct.Text = "Update Product";
            btn_UpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_AddProduct.FlatStyle = FlatStyle.Flat;
            btn_AddProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_AddProduct.ForeColor = SystemColors.ActiveCaption;
            btn_AddProduct.Location = new Point(117, 448);
            btn_AddProduct.Margin = new Padding(3, 4, 3, 4);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(263, 55);
            btn_AddProduct.TabIndex = 80;
            btn_AddProduct.Text = "Add Product";
            btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(462, 79);
            label7.Name = "label7";
            label7.Size = new Size(173, 37);
            label7.TabIndex = 79;
            label7.Text = "All Products";
            // 
            // btn_DeleteProduct
            // 
            btn_DeleteProduct.FlatAppearance.MouseOverBackColor = Color.Navy;
            btn_DeleteProduct.FlatStyle = FlatStyle.Flat;
            btn_DeleteProduct.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btn_DeleteProduct.ForeColor = SystemColors.ActiveCaption;
            btn_DeleteProduct.Location = new Point(700, 448);
            btn_DeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btn_DeleteProduct.Name = "btn_DeleteProduct";
            btn_DeleteProduct.Size = new Size(263, 55);
            btn_DeleteProduct.TabIndex = 75;
            btn_DeleteProduct.Text = "Delete Product";
            btn_DeleteProduct.UseVisualStyleBackColor = true;
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
            txt_Search.PlaceholderText = "Search for Product";
            txt_Search.Size = new Size(209, 32);
            txt_Search.TabIndex = 77;
            // 
            // cmb_Category
            // 
            cmb_Category.BackColor = Color.Cornsilk;
            cmb_Category.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Category.ForeColor = SystemColors.ControlText;
            cmb_Category.FormattingEnabled = true;
            cmb_Category.Location = new Point(230, 18);
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
            label2.Size = new Size(220, 37);
            label2.TabIndex = 74;
            label2.Text = "Select Category";
            // 
            // dgv_Products
            // 
            dgv_Products.AllowUserToAddRows = false;
            dgv_Products.AllowUserToResizeColumns = false;
            dgv_Products.AllowUserToResizeRows = false;
            dgv_Products.BackgroundColor = Color.FromArgb(0, 0, 20);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 40, 65);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Products.Location = new Point(1, 120);
            dgv_Products.Margin = new Padding(3, 4, 3, 4);
            dgv_Products.MultiSelect = false;
            dgv_Products.Name = "dgv_Products";
            dgv_Products.RowHeadersWidth = 51;
            dgv_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Products.Size = new Size(1094, 303);
            dgv_Products.TabIndex = 73;
            // 
            // Trainee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 20);
            Controls.Add(btn_UpdateProduct);
            Controls.Add(btn_AddProduct);
            Controls.Add(label7);
            Controls.Add(btn_DeleteProduct);
            Controls.Add(btn_Search);
            Controls.Add(txt_Search);
            Controls.Add(cmb_Category);
            Controls.Add(label2);
            Controls.Add(dgv_Products);
            Name = "Trainee";
            Size = new Size(1097, 515);
            ((System.ComponentModel.ISupportInitialize)dgv_Products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_UpdateProduct;
        private Button btn_AddProduct;
        private Label label7;
        private Button btn_DeleteProduct;
        private Button btn_Search;
        private TextBox txt_Search;
        private ComboBox cmb_Category;
        private Label label2;
        private DataGridView dgv_Products;
    }
}
