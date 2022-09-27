namespace LopushokApp.View
{
    partial class AddEditForm
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
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productionPersonCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productionWorkshopNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeImageBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addMaterialBtn = new System.Windows.Forms.Button();
            this.deleteMaterialBtn = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            articleNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minCostForAgentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPersonCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionWorkshopNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.BackColor = System.Drawing.Color.White;
            articleNumberLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            articleNumberLabel.Location = new System.Drawing.Point(12, 9);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(83, 39);
            articleNumberLabel.TabIndex = 1;
            articleNumberLabel.Text = "Артикль:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.White;
            descriptionLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(12, 283);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(88, 39);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Описание:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.BackColor = System.Drawing.Color.White;
            minCostForAgentLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minCostForAgentLabel.Location = new System.Drawing.Point(12, 185);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(173, 39);
            minCostForAgentLabel.TabIndex = 7;
            minCostForAgentLabel.Text = "Мин. цена для агента:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.BackColor = System.Drawing.Color.White;
            productionPersonCountLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionPersonCountLabel.Location = new System.Drawing.Point(286, 9);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(240, 39);
            productionPersonCountLabel.TabIndex = 9;
            productionPersonCountLabel.Text = "Число человек для производства:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.BackColor = System.Drawing.Color.White;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(286, 97);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(200, 39);
            productionWorkshopNumberLabel.TabIndex = 11;
            productionWorkshopNumberLabel.Text = "Номер цеха производства:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.BackColor = System.Drawing.Color.White;
            productTypeIDLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productTypeIDLabel.Location = new System.Drawing.Point(286, 185);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(124, 39);
            productTypeIDLabel.TabIndex = 13;
            productTypeIDLabel.Text = "Тип продукции:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.White;
            titleLabel.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(12, 97);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(121, 39);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Наименование:";
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.BackColor = System.Drawing.Color.White;
            this.articleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ArticleNumber", true));
            this.articleNumberTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleNumberTextBox.Location = new System.Drawing.Point(19, 51);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(258, 43);
            this.articleNumberTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(19, 325);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(532, 95);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // productTypeIDComboBox
            // 
            this.productTypeIDComboBox.BackColor = System.Drawing.Color.White;
            this.productTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductTypeID", true));
            this.productTypeIDComboBox.DataSource = this.productTypeBindingSource;
            this.productTypeIDComboBox.DisplayMember = "Title";
            this.productTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeIDComboBox.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeIDComboBox.FormattingEnabled = true;
            this.productTypeIDComboBox.Location = new System.Drawing.Point(293, 227);
            this.productTypeIDComboBox.Name = "productTypeIDComboBox";
            this.productTypeIDComboBox.Size = new System.Drawing.Size(258, 47);
            this.productTypeIDComboBox.TabIndex = 14;
            this.productTypeIDComboBox.ValueMember = "ID";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.White;
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(19, 139);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(258, 43);
            this.titleTextBox.TabIndex = 16;
            // 
            // minCostForAgentNumericUpDown
            // 
            this.minCostForAgentNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentNumericUpDown.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCostForAgentNumericUpDown.Location = new System.Drawing.Point(19, 231);
            this.minCostForAgentNumericUpDown.Name = "minCostForAgentNumericUpDown";
            this.minCostForAgentNumericUpDown.Size = new System.Drawing.Size(258, 43);
            this.minCostForAgentNumericUpDown.TabIndex = 17;
            // 
            // productionPersonCountNumericUpDown
            // 
            this.productionPersonCountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountNumericUpDown.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionPersonCountNumericUpDown.Location = new System.Drawing.Point(293, 52);
            this.productionPersonCountNumericUpDown.Name = "productionPersonCountNumericUpDown";
            this.productionPersonCountNumericUpDown.Size = new System.Drawing.Size(258, 43);
            this.productionPersonCountNumericUpDown.TabIndex = 18;
            // 
            // productionWorkshopNumberNumericUpDown
            // 
            this.productionWorkshopNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberNumericUpDown.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionWorkshopNumberNumericUpDown.Location = new System.Drawing.Point(293, 139);
            this.productionWorkshopNumberNumericUpDown.Name = "productionWorkshopNumberNumericUpDown";
            this.productionWorkshopNumberNumericUpDown.Size = new System.Drawing.Size(258, 43);
            this.productionWorkshopNumberNumericUpDown.TabIndex = 19;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(19, 481);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(262, 55);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(1141, 481);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(262, 55);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(293, 481);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(262, 55);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // changeImageBtn
            // 
            this.changeImageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.changeImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeImageBtn.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeImageBtn.Location = new System.Drawing.Point(592, 325);
            this.changeImageBtn.Name = "changeImageBtn";
            this.changeImageBtn.Size = new System.Drawing.Size(300, 55);
            this.changeImageBtn.TabIndex = 20;
            this.changeImageBtn.Text = "Выбрать фото";
            this.changeImageBtn.UseVisualStyleBackColor = false;
            this.changeImageBtn.Click += new System.EventHandler(this.changeImageBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productMaterialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(898, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 358);
            this.dataGridView1.TabIndex = 22;
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.addMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMaterialBtn.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMaterialBtn.Location = new System.Drawing.Point(898, 386);
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.Size = new System.Drawing.Size(208, 55);
            this.addMaterialBtn.TabIndex = 20;
            this.addMaterialBtn.Text = "+";
            this.addMaterialBtn.UseVisualStyleBackColor = false;
            this.addMaterialBtn.Click += new System.EventHandler(this.addMaterialBtn_Click);
            // 
            // deleteMaterialBtn
            // 
            this.deleteMaterialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.deleteMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMaterialBtn.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteMaterialBtn.Location = new System.Drawing.Point(1195, 386);
            this.deleteMaterialBtn.Name = "deleteMaterialBtn";
            this.deleteMaterialBtn.Size = new System.Drawing.Size(208, 55);
            this.deleteMaterialBtn.TabIndex = 20;
            this.deleteMaterialBtn.Text = "-";
            this.deleteMaterialBtn.UseVisualStyleBackColor = false;
            this.deleteMaterialBtn.Click += new System.EventHandler(this.deleteMaterialBtn_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(592, 19);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(300, 300);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 23;
            this.imagePictureBox.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(LopushokApp.Models.Product);
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.DataSource = this.materialBindingSource;
            this.materialIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.materialIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(LopushokApp.Models.Material);
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 70;
            // 
            // productMaterialBindingSource
            // 
            this.productMaterialBindingSource.DataSource = typeof(LopushokApp.Models.ProductMaterial);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(LopushokApp.Models.ProductType);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1423, 556);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteMaterialBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeImageBtn);
            this.Controls.Add(this.addMaterialBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.productionWorkshopNumberNumericUpDown);
            this.Controls.Add(this.productionPersonCountNumericUpDown);
            this.Controls.Add(this.minCostForAgentNumericUpDown);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(this.productTypeIDComboBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лопушок";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minCostForAgentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionPersonCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionWorkshopNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox productTypeIDComboBox;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.NumericUpDown minCostForAgentNumericUpDown;
        private System.Windows.Forms.NumericUpDown productionPersonCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown productionWorkshopNumberNumericUpDown;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeImageBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productMaterialBindingSource;
        private System.Windows.Forms.Button addMaterialBtn;
        private System.Windows.Forms.Button deleteMaterialBtn;
        private System.Windows.Forms.PictureBox imagePictureBox;
    }
}