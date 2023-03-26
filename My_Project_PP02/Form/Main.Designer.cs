
namespace My_Project_PP02
{
    partial class Main
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
            this.Container = new System.Windows.Forms.Panel();
            this.ContainerContent = new System.Windows.Forms.Panel();
            this.btnContainer3 = new System.Windows.Forms.Panel();
            this.btnRecordClient = new System.Windows.Forms.Button();
            this.btnContainer2 = new System.Windows.Forms.Panel();
            this.btnAddServices = new System.Windows.Forms.Button();
            this.btnContainer1 = new System.Windows.Forms.Panel();
            this.btnListServices = new System.Windows.Forms.Button();
            this.ContainerLogo = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.ContainerBottom = new System.Windows.Forms.Panel();
            this.btnActivateTheMode = new System.Windows.Forms.Button();
            this.containerControl = new System.Windows.Forms.Panel();
            this.Container.SuspendLayout();
            this.ContainerContent.SuspendLayout();
            this.btnContainer3.SuspendLayout();
            this.btnContainer2.SuspendLayout();
            this.btnContainer1.SuspendLayout();
            this.ContainerLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.ContainerBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Container.Controls.Add(this.ContainerContent);
            this.Container.Controls.Add(this.ContainerLogo);
            this.Container.Controls.Add(this.ContainerBottom);
            this.Container.Location = new System.Drawing.Point(0, 7);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(284, 806);
            this.Container.TabIndex = 0;
            // 
            // ContainerContent
            // 
            this.ContainerContent.Controls.Add(this.btnContainer3);
            this.ContainerContent.Controls.Add(this.btnContainer2);
            this.ContainerContent.Controls.Add(this.btnContainer1);
            this.ContainerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerContent.Location = new System.Drawing.Point(0, 229);
            this.ContainerContent.Name = "ContainerContent";
            this.ContainerContent.Size = new System.Drawing.Size(284, 504);
            this.ContainerContent.TabIndex = 1;
            // 
            // btnContainer3
            // 
            this.btnContainer3.Controls.Add(this.btnRecordClient);
            this.btnContainer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContainer3.Location = new System.Drawing.Point(0, 164);
            this.btnContainer3.Name = "btnContainer3";
            this.btnContainer3.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnContainer3.Size = new System.Drawing.Size(284, 82);
            this.btnContainer3.TabIndex = 2;
            this.btnContainer3.Visible = false;
            // 
            // btnRecordClient
            // 
            this.btnRecordClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecordClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordClient.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecordClient.Location = new System.Drawing.Point(15, 10);
            this.btnRecordClient.Name = "btnRecordClient";
            this.btnRecordClient.Size = new System.Drawing.Size(254, 62);
            this.btnRecordClient.TabIndex = 1;
            this.btnRecordClient.Text = "Записи Клиентов";
            this.btnRecordClient.UseVisualStyleBackColor = true;
            this.btnRecordClient.Click += new System.EventHandler(this.btnRecordClient_Click);
            // 
            // btnContainer2
            // 
            this.btnContainer2.Controls.Add(this.btnAddServices);
            this.btnContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContainer2.Location = new System.Drawing.Point(0, 82);
            this.btnContainer2.Name = "btnContainer2";
            this.btnContainer2.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnContainer2.Size = new System.Drawing.Size(284, 82);
            this.btnContainer2.TabIndex = 1;
            this.btnContainer2.Visible = false;
            // 
            // btnAddServices
            // 
            this.btnAddServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServices.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddServices.Location = new System.Drawing.Point(15, 10);
            this.btnAddServices.Name = "btnAddServices";
            this.btnAddServices.Size = new System.Drawing.Size(254, 62);
            this.btnAddServices.TabIndex = 1;
            this.btnAddServices.Text = "Добавление услуги";
            this.btnAddServices.UseVisualStyleBackColor = true;
            this.btnAddServices.Click += new System.EventHandler(this.btnAddServices_Click);
            // 
            // btnContainer1
            // 
            this.btnContainer1.Controls.Add(this.btnListServices);
            this.btnContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContainer1.Location = new System.Drawing.Point(0, 0);
            this.btnContainer1.Name = "btnContainer1";
            this.btnContainer1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnContainer1.Size = new System.Drawing.Size(284, 82);
            this.btnContainer1.TabIndex = 0;
            this.btnContainer1.Visible = false;
            // 
            // btnListServices
            // 
            this.btnListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListServices.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnListServices.Location = new System.Drawing.Point(15, 10);
            this.btnListServices.Name = "btnListServices";
            this.btnListServices.Size = new System.Drawing.Size(254, 62);
            this.btnListServices.TabIndex = 1;
            this.btnListServices.Text = "Список Услуг";
            this.btnListServices.UseVisualStyleBackColor = true;
            this.btnListServices.Click += new System.EventHandler(this.btnListServices_Click);
            // 
            // ContainerLogo
            // 
            this.ContainerLogo.Controls.Add(this.labelRole);
            this.ContainerLogo.Controls.Add(this.imageLogo);
            this.ContainerLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerLogo.Location = new System.Drawing.Point(0, 0);
            this.ContainerLogo.Name = "ContainerLogo";
            this.ContainerLogo.Padding = new System.Windows.Forms.Padding(15, 5, 15, 2);
            this.ContainerLogo.Size = new System.Drawing.Size(284, 229);
            this.ContainerLogo.TabIndex = 1;
            // 
            // labelRole
            // 
            this.labelRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRole.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.Location = new System.Drawing.Point(15, 152);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(254, 75);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Role";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageLogo
            // 
            this.imageLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageLogo.Image = global::My_Project_PP02.Properties.Resources.school_logo;
            this.imageLogo.Location = new System.Drawing.Point(15, 5);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(254, 147);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // ContainerBottom
            // 
            this.ContainerBottom.Controls.Add(this.btnActivateTheMode);
            this.ContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContainerBottom.Location = new System.Drawing.Point(0, 733);
            this.ContainerBottom.Name = "ContainerBottom";
            this.ContainerBottom.Padding = new System.Windows.Forms.Padding(10);
            this.ContainerBottom.Size = new System.Drawing.Size(284, 73);
            this.ContainerBottom.TabIndex = 1;
            // 
            // btnActivateTheMode
            // 
            this.btnActivateTheMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivateTheMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateTheMode.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActivateTheMode.Location = new System.Drawing.Point(10, 10);
            this.btnActivateTheMode.Name = "btnActivateTheMode";
            this.btnActivateTheMode.Size = new System.Drawing.Size(264, 53);
            this.btnActivateTheMode.TabIndex = 0;
            this.btnActivateTheMode.Text = "Сменить режим";
            this.btnActivateTheMode.UseVisualStyleBackColor = true;
            this.btnActivateTheMode.Click += new System.EventHandler(this.ActivateTheMode_Click);
            // 
            // containerControl
            // 
            this.containerControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerControl.Location = new System.Drawing.Point(284, 7);
            this.containerControl.Name = "containerControl";
            this.containerControl.Size = new System.Drawing.Size(775, 806);
            this.containerControl.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 813);
            this.Controls.Add(this.containerControl);
            this.Controls.Add(this.Container);
            this.MinimumSize = new System.Drawing.Size(1077, 782);
            this.Name = "Main";
            this.Text = "Главная";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.Container.ResumeLayout(false);
            this.ContainerContent.ResumeLayout(false);
            this.btnContainer3.ResumeLayout(false);
            this.btnContainer2.ResumeLayout(false);
            this.btnContainer1.ResumeLayout(false);
            this.ContainerLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.ContainerBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel ContainerLogo;
        private System.Windows.Forms.Panel ContainerContent;
        private System.Windows.Forms.Panel ContainerBottom;
        private System.Windows.Forms.Button btnActivateTheMode;
        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.Panel btnContainer3;
        private System.Windows.Forms.Button btnRecordClient;
        private System.Windows.Forms.Panel btnContainer2;
        private System.Windows.Forms.Button btnAddServices;
        private System.Windows.Forms.Panel btnContainer1;
        private System.Windows.Forms.Button btnListServices;
        private System.Windows.Forms.Label labelRole;
        internal System.Windows.Forms.Panel containerControl;
    }
}