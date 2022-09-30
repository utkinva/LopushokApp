namespace LopushokApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pagesLbl = new System.Windows.Forms.Label();
            this.nextPageLbl = new System.Windows.Forms.Label();
            this.LabelP = new System.Windows.Forms.Label();
            this.prevPageLbl = new System.Windows.Forms.Label();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.changePrice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descCheckBox = new System.Windows.Forms.CheckBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.addNewProduct);
            this.panel1.Controls.Add(this.changePrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 702);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pagesLbl);
            this.panel3.Controls.Add(this.nextPageLbl);
            this.panel3.Controls.Add(this.LabelP);
            this.panel3.Controls.Add(this.prevPageLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(970, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 70);
            this.panel3.TabIndex = 6;
            // 
            // pagesLbl
            // 
            this.pagesLbl.AutoSize = true;
            this.pagesLbl.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesLbl.Location = new System.Drawing.Point(8, 11);
            this.pagesLbl.Name = "pagesLbl";
            this.pagesLbl.Size = new System.Drawing.Size(86, 45);
            this.pagesLbl.TabIndex = 6;
            this.pagesLbl.Text = "## из ##";
            // 
            // nextPageLbl
            // 
            this.nextPageLbl.AutoSize = true;
            this.nextPageLbl.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextPageLbl.Location = new System.Drawing.Point(255, 11);
            this.nextPageLbl.Name = "nextPageLbl";
            this.nextPageLbl.Size = new System.Drawing.Size(29, 45);
            this.nextPageLbl.TabIndex = 5;
            this.nextPageLbl.Text = ">";
            this.nextPageLbl.Click += new System.EventHandler(this.nextPageLbl_Click);
            // 
            // LabelP
            // 
            this.LabelP.AutoSize = true;
            this.LabelP.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelP.Location = new System.Drawing.Point(186, 11);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(63, 45);
            this.LabelP.TabIndex = 5;
            this.LabelP.Text = "1 2 3 4";
            // 
            // prevPageLbl
            // 
            this.prevPageLbl.AutoSize = true;
            this.prevPageLbl.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevPageLbl.Location = new System.Drawing.Point(151, 11);
            this.prevPageLbl.Name = "prevPageLbl";
            this.prevPageLbl.Size = new System.Drawing.Size(29, 45);
            this.prevPageLbl.TabIndex = 5;
            this.prevPageLbl.Text = "<";
            this.prevPageLbl.Click += new System.EventHandler(this.prevPageLbl_Click);
            // 
            // addNewProduct
            // 
            this.addNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.addNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProduct.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewProduct.Location = new System.Drawing.Point(12, 6);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(262, 55);
            this.addNewProduct.TabIndex = 0;
            this.addNewProduct.Text = "Добавить продукцию";
            this.addNewProduct.UseVisualStyleBackColor = false;
            this.addNewProduct.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // changePrice
            // 
            this.changePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.changePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePrice.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePrice.Location = new System.Drawing.Point(280, 6);
            this.changePrice.Name = "changePrice";
            this.changePrice.Size = new System.Drawing.Size(262, 55);
            this.changePrice.TabIndex = 0;
            this.changePrice.Text = "Изменить стоимость на ...";
            this.changePrice.UseVisualStyleBackColor = false;
            this.changePrice.Click += new System.EventHandler(this.changePrice_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.descCheckBox);
            this.panel2.Controls.Add(this.filterComboBox);
            this.panel2.Controls.Add(this.sortComboBox);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.logoPictureBox);
            this.panel2.Controls.Add(this.titleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 125);
            this.panel2.TabIndex = 1;
            // 
            // descCheckBox
            // 
            this.descCheckBox.AutoSize = true;
            this.descCheckBox.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descCheckBox.Location = new System.Drawing.Point(897, 72);
            this.descCheckBox.Name = "descCheckBox";
            this.descCheckBox.Size = new System.Drawing.Size(144, 49);
            this.descCheckBox.TabIndex = 3;
            this.descCheckBox.Text = "По убыванию";
            this.descCheckBox.UseVisualStyleBackColor = true;
            this.descCheckBox.CheckedChanged += new System.EventHandler(this.TriggerFilters);
            // 
            // filterComboBox
            // 
            this.filterComboBox.BackColor = System.Drawing.Color.White;
            this.filterComboBox.DataSource = this.productTypeBindingSource;
            this.filterComboBox.DisplayMember = "Title";
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(1047, 66);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(207, 53);
            this.filterComboBox.TabIndex = 0;
            this.filterComboBox.ValueMember = "ID";
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.TriggerFilters);
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(LopushokApp.Models.ProductType);
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.White;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Номер производственного цеха",
            "Минимальная стоимость для агента"});
            this.sortComboBox.Location = new System.Drawing.Point(557, 66);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(334, 53);
            this.sortComboBox.TabIndex = 2;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.TriggerFilters);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(129, 71);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(422, 48);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.TriggerFilters);
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::LopushokApp.Properties.Resources.Лопушок;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(120, 120);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(129, -10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 88);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Лопушок";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 125);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1266, 577);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 772);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лопушок";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.CheckBox descCheckBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button changePrice;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nextPageLbl;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.Label prevPageLbl;
        private System.Windows.Forms.Label pagesLbl;
    }
}

