
namespace StarMeatsPos
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodonPromotionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prodPriceperkgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceperunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantityAvailablekgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantityAvailableunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodsellbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group3DataSet = new StarMeatsPos.group3DataSet();
            this.productTableAdapter = new StarMeatsPos.group3DataSetTableAdapters.ProductTableAdapter();
            this.employeeTableAdapter1 = new StarMeatsPos.group3DataSetTableAdapters.EmployeeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(271, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 348);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(318, 208);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 28);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.Location = new System.Drawing.Point(209, 153);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(209, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUserName.Location = new System.Drawing.Point(209, 104);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(209, 23);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUserName.Click += new System.EventHandler(this.textBoxUserName_Click);
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(119, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(119, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(209, 208);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(238, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIdDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn,
            this.prodCategoryDataGridViewTextBoxColumn,
            this.prodonPromotionDataGridViewCheckBoxColumn,
            this.prodPriceperkgDataGridViewTextBoxColumn,
            this.prodPriceperunitDataGridViewTextBoxColumn,
            this.prodQuantityAvailablekgDataGridViewTextBoxColumn,
            this.prodQuantityAvailableunitDataGridViewTextBoxColumn,
            this.prodsellbyDataGridViewTextBoxColumn,
            this.reorderlevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(746, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "Prod_Id";
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Prod_Description";
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "Prod_Description";
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            // 
            // prodCategoryDataGridViewTextBoxColumn
            // 
            this.prodCategoryDataGridViewTextBoxColumn.DataPropertyName = "Prod_Category";
            this.prodCategoryDataGridViewTextBoxColumn.HeaderText = "Prod_Category";
            this.prodCategoryDataGridViewTextBoxColumn.Name = "prodCategoryDataGridViewTextBoxColumn";
            // 
            // prodonPromotionDataGridViewCheckBoxColumn
            // 
            this.prodonPromotionDataGridViewCheckBoxColumn.DataPropertyName = "Prod_on_Promotion";
            this.prodonPromotionDataGridViewCheckBoxColumn.HeaderText = "Prod_on_Promotion";
            this.prodonPromotionDataGridViewCheckBoxColumn.Name = "prodonPromotionDataGridViewCheckBoxColumn";
            // 
            // prodPriceperkgDataGridViewTextBoxColumn
            // 
            this.prodPriceperkgDataGridViewTextBoxColumn.DataPropertyName = "Prod_Price_per_kg";
            this.prodPriceperkgDataGridViewTextBoxColumn.HeaderText = "Prod_Price_per_kg";
            this.prodPriceperkgDataGridViewTextBoxColumn.Name = "prodPriceperkgDataGridViewTextBoxColumn";
            // 
            // prodPriceperunitDataGridViewTextBoxColumn
            // 
            this.prodPriceperunitDataGridViewTextBoxColumn.DataPropertyName = "Prod_Price_per_unit";
            this.prodPriceperunitDataGridViewTextBoxColumn.HeaderText = "Prod_Price_per_unit";
            this.prodPriceperunitDataGridViewTextBoxColumn.Name = "prodPriceperunitDataGridViewTextBoxColumn";
            // 
            // prodQuantityAvailablekgDataGridViewTextBoxColumn
            // 
            this.prodQuantityAvailablekgDataGridViewTextBoxColumn.DataPropertyName = "Prod_Quantity_Available_kg";
            this.prodQuantityAvailablekgDataGridViewTextBoxColumn.HeaderText = "Prod_Quantity_Available_kg";
            this.prodQuantityAvailablekgDataGridViewTextBoxColumn.Name = "prodQuantityAvailablekgDataGridViewTextBoxColumn";
            // 
            // prodQuantityAvailableunitDataGridViewTextBoxColumn
            // 
            this.prodQuantityAvailableunitDataGridViewTextBoxColumn.DataPropertyName = "Prod_Quantity_Available_unit";
            this.prodQuantityAvailableunitDataGridViewTextBoxColumn.HeaderText = "Prod_Quantity_Available_unit";
            this.prodQuantityAvailableunitDataGridViewTextBoxColumn.Name = "prodQuantityAvailableunitDataGridViewTextBoxColumn";
            // 
            // prodsellbyDataGridViewTextBoxColumn
            // 
            this.prodsellbyDataGridViewTextBoxColumn.DataPropertyName = "Prod_sell_by";
            this.prodsellbyDataGridViewTextBoxColumn.HeaderText = "Prod_sell_by";
            this.prodsellbyDataGridViewTextBoxColumn.Name = "prodsellbyDataGridViewTextBoxColumn";
            // 
            // reorderlevelDataGridViewTextBoxColumn
            // 
            this.reorderlevelDataGridViewTextBoxColumn.DataPropertyName = "Reorder_level";
            this.reorderlevelDataGridViewTextBoxColumn.HeaderText = "Reorder_level";
            this.reorderlevelDataGridViewTextBoxColumn.Name = "reorderlevelDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.group3DataSet;
            // 
            // group3DataSet
            // 
            this.group3DataSet.DataSetName = "group3DataSet";
            this.group3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1104, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private group3DataSet group3DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private group3DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prodonPromotionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceperkgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceperunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantityAvailablekgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantityAvailableunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodsellbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderlevelDataGridViewTextBoxColumn;
        private group3DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}