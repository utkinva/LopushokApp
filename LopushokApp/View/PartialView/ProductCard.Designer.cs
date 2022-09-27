namespace LopushokApp.View.PartialView
{
    partial class ProductCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleTypeLabel = new System.Windows.Forms.Label();
            this.articleLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.materialsLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTypeLabel
            // 
            this.titleTypeLabel.AutoSize = true;
            this.titleTypeLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTypeLabel.Location = new System.Drawing.Point(203, -1);
            this.titleTypeLabel.Name = "titleTypeLabel";
            this.titleTypeLabel.Size = new System.Drawing.Size(437, 54);
            this.titleTypeLabel.TabIndex = 1;
            this.titleTypeLabel.Text = "Тип продукта | Наименование продукта";
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleLabel.Location = new System.Drawing.Point(203, 42);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(101, 50);
            this.articleLabel.TabIndex = 1;
            this.articleLabel.Text = "Артикул";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(823, 22);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(127, 50);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Стоимость";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::LopushokApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 22);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(194, 144);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // materialsLabel
            // 
            this.materialsLabel.BackColor = System.Drawing.Color.White;
            this.materialsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialsLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialsLabel.Location = new System.Drawing.Point(212, 92);
            this.materialsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.materialsLabel.Multiline = true;
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.ReadOnly = true;
            this.materialsLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.materialsLabel.Size = new System.Drawing.Size(428, 91);
            this.materialsLabel.TabIndex = 2;
            this.materialsLabel.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialsLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.titleTypeLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(1050, 194);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleTypeLabel;
        private System.Windows.Forms.Label articleLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox materialsLabel;
    }
}
