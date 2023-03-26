
namespace My_Project_PP02.Controls
{
    partial class ServicesListItems
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.FocusBottom = new System.Windows.Forms.Button();
            this.btnRecordClient = new System.Windows.Forms.Button();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelCostTime = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBoxServiceImg = new System.Windows.Forms.PictureBox();
            this.FocusTop = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.FocusTop);
            this.panel3.Controls.Add(this.FocusBottom);
            this.panel3.Controls.Add(this.btnRecordClient);
            this.panel3.Controls.Add(this.labelDiscount);
            this.panel3.Controls.Add(this.labelCostTime);
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.pictureBoxServiceImg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(747, 160);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.ServicesListItems_Click);
            // 
            // FocusBottom
            // 
            this.FocusBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FocusBottom.BackColor = System.Drawing.Color.White;
            this.FocusBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FocusBottom.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FocusBottom.Location = new System.Drawing.Point(736, 148);
            this.FocusBottom.Name = "FocusBottom";
            this.FocusBottom.Size = new System.Drawing.Size(10, 10);
            this.FocusBottom.TabIndex = 7;
            this.FocusBottom.Text = "Редактировать";
            this.FocusBottom.UseVisualStyleBackColor = false;
            // 
            // btnRecordClient
            // 
            this.btnRecordClient.BackColor = System.Drawing.Color.White;
            this.btnRecordClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordClient.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecordClient.Location = new System.Drawing.Point(475, 123);
            this.btnRecordClient.Name = "btnRecordClient";
            this.btnRecordClient.Size = new System.Drawing.Size(168, 30);
            this.btnRecordClient.TabIndex = 6;
            this.btnRecordClient.Text = "Записать клиента ";
            this.btnRecordClient.UseVisualStyleBackColor = false;
            this.btnRecordClient.Click += new System.EventHandler(this.btnRecordClient_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.Location = new System.Drawing.Point(162, 80);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(117, 24);
            this.labelDiscount.TabIndex = 5;
            this.labelDiscount.Text = "^ скидка 10%";
            this.labelDiscount.Click += new System.EventHandler(this.ServicesListItems_Click);
            // 
            // labelCostTime
            // 
            this.labelCostTime.AutoSize = true;
            this.labelCostTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostTime.Location = new System.Drawing.Point(162, 46);
            this.labelCostTime.Name = "labelCostTime";
            this.labelCostTime.Size = new System.Drawing.Size(271, 25);
            this.labelCostTime.TabIndex = 4;
            this.labelCostTime.Text = "800 720 рублей за 30 минут";
            this.labelCostTime.Click += new System.EventHandler(this.ServicesListItems_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(162, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(225, 28);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Наименование услуги";
            this.labelName.Click += new System.EventHandler(this.ServicesListItems_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(347, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(162, 123);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBoxServiceImg
            // 
            this.pictureBoxServiceImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxServiceImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxServiceImg.Image = global::My_Project_PP02.Properties.Resources.free_icon_question_189665;
            this.pictureBoxServiceImg.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxServiceImg.Name = "pictureBoxServiceImg";
            this.pictureBoxServiceImg.Size = new System.Drawing.Size(150, 148);
            this.pictureBoxServiceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxServiceImg.TabIndex = 0;
            this.pictureBoxServiceImg.TabStop = false;
            this.pictureBoxServiceImg.Click += new System.EventHandler(this.ServicesListItems_Click);
            // 
            // FocusTop
            // 
            this.FocusTop.BackColor = System.Drawing.Color.White;
            this.FocusTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FocusTop.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FocusTop.Location = new System.Drawing.Point(-1, -1);
            this.FocusTop.Name = "FocusTop";
            this.FocusTop.Size = new System.Drawing.Size(10, 10);
            this.FocusTop.TabIndex = 8;
            this.FocusTop.Text = "Редактировать";
            this.FocusTop.UseVisualStyleBackColor = false;
            // 
            // ServicesListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "ServicesListItems";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(755, 170);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ServicesListItems_Paint);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServiceImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelCostTime;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxServiceImg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecordClient;
        internal System.Windows.Forms.Button FocusBottom;
        private System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button FocusTop;
    }
}
