
namespace My_Project_PP02.Controls
{
    partial class ServicesList
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
            this.containerServicesList = new System.Windows.Forms.Panel();
            this.containerMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCountItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.comboBoxSortByCost = new System.Windows.Forms.ComboBox();
            this.comboBoxSortByDiscount = new System.Windows.Forms.ComboBox();
            this.containerMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerServicesList
            // 
            this.containerServicesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerServicesList.Location = new System.Drawing.Point(0, 93);
            this.containerServicesList.Name = "containerServicesList";
            this.containerServicesList.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.containerServicesList.Size = new System.Drawing.Size(775, 607);
            this.containerServicesList.TabIndex = 0;
            // 
            // containerMain
            // 
            this.containerMain.Controls.Add(this.containerServicesList);
            this.containerMain.Controls.Add(this.panel2);
            this.containerMain.Controls.Add(this.panel1);
            this.containerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerMain.Location = new System.Drawing.Point(0, 0);
            this.containerMain.Name = "containerMain";
            this.containerMain.Size = new System.Drawing.Size(775, 735);
            this.containerMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCountItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 35);
            this.panel2.TabIndex = 2;
            // 
            // labelCountItems
            // 
            this.labelCountItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountItems.Location = new System.Drawing.Point(0, 0);
            this.labelCountItems.Name = "labelCountItems";
            this.labelCountItems.Size = new System.Drawing.Size(775, 35);
            this.labelCountItems.TabIndex = 0;
            this.labelCountItems.Text = "0 из 0";
            this.labelCountItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelCost);
            this.panel1.Controls.Add(this.labelDiscount);
            this.panel1.Controls.Add(this.comboBoxSortByCost);
            this.panel1.Controls.Add(this.comboBoxSortByDiscount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 93);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(424, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(504, 27);
            this.textBox1.MaximumSize = new System.Drawing.Size(600, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 60);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCost.Location = new System.Drawing.Point(223, 27);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(58, 25);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Цена";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDiscount.Location = new System.Drawing.Point(14, 27);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(78, 25);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "Скидка";
            // 
            // comboBoxSortByCost
            // 
            this.comboBoxSortByCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortByCost.FormattingEnabled = true;
            this.comboBoxSortByCost.Location = new System.Drawing.Point(226, 54);
            this.comboBoxSortByCost.Name = "comboBoxSortByCost";
            this.comboBoxSortByCost.Size = new System.Drawing.Size(192, 33);
            this.comboBoxSortByCost.TabIndex = 1;
            this.comboBoxSortByCost.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            this.comboBoxSortByCost.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSortByCost_SelectionChangeCommitted);
            // 
            // comboBoxSortByDiscount
            // 
            this.comboBoxSortByDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSortByDiscount.FormattingEnabled = true;
            this.comboBoxSortByDiscount.Location = new System.Drawing.Point(14, 54);
            this.comboBoxSortByDiscount.Name = "comboBoxSortByDiscount";
            this.comboBoxSortByDiscount.Size = new System.Drawing.Size(192, 33);
            this.comboBoxSortByDiscount.TabIndex = 0;
            this.comboBoxSortByDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            this.comboBoxSortByDiscount.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSortByCost_SelectionChangeCommitted);
            // 
            // ServicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerMain);
            this.Name = "ServicesList";
            this.Size = new System.Drawing.Size(775, 735);
            this.containerMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerServicesList;
        private System.Windows.Forms.Panel containerMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSortByCost;
        private System.Windows.Forms.ComboBox comboBoxSortByDiscount;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelCountItems;
    }
}
