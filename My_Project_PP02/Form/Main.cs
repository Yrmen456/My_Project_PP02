using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP02.Data;
using My_Project_PP02.Controls;

namespace My_Project_PP02
{
    public partial class Main : PatternForm
    {
        
        public Main()
        {
            InitializeComponent();
            Program._Main = this;
            btnActivateTheMode.FlatAppearance.BorderSize = 0;
            btnActivateTheMode.BackColor = MyColors.FocusingAttention;
            btnListServices.FlatAppearance.BorderSize = 0;
            btnListServices.BackColor = MyColors.FocusingAttention;
            btnAddServices.FlatAppearance.BorderSize = 0;
            btnAddServices.BackColor = MyColors.FocusingAttention;
            btnRecordClient.FlatAppearance.BorderSize = 0;
            btnRecordClient.BackColor = MyColors.FocusingAttention;
            this.Text = "Главная";
            RoleAccess();

        }
        Button Button;
        public async void RoleAccess()
        {
            switch (User.Role)
            {
                case Roles.Admin:
                    labelRole.Text = "Режим Администратора";
                    btnContainer1.Visible = true;
                    btnContainer2.Visible = true;
                    btnContainer3.Visible = true;
                    containerControl.Controls.Clear();
                    break;
                case Roles.Client:
                    labelRole.Text = "Обычный Режим";
                    btnContainer1.Visible = true;
                    btnContainer2.Visible = false;
                    btnContainer3.Visible = false;
                    containerControl.Controls.Clear();
                    break;
                default:
                    labelRole.Text = "Обычный Режим";
                    btnContainer1.Visible = true;
                    btnContainer2.Visible = false;
                    btnContainer3.Visible = false;
                    containerControl.Controls.Clear();
                    break;
            }

        
        }

        private void ActivateTheMode_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.ShowDialog();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnListServices_Click(object sender, EventArgs e)
        {
     
            containerControl.Controls.Clear();
            ServicesList ServicesList = new ServicesList();
            ServicesList.Dock = DockStyle.Fill;
            containerControl.Visible = false;
            containerControl.Controls.Add(ServicesList);
            await Task.Delay(10);
            containerControl.Visible = true;
            
        }
        
        private async void btnAddServices_Click(object sender, EventArgs e)
        {
            containerControl.Controls.Clear();
            ServicesAddEdit ServicesAddEdit = new ServicesAddEdit();
            ServicesAddEdit.Dock = DockStyle.Fill;
            containerControl.Visible = false;
            containerControl.Controls.Add(ServicesAddEdit);
            await Task.Delay(10);
            containerControl.Visible = true;

        }

        private async void btnRecordClient_Click(object sender, EventArgs e)
        {
            containerControl.Controls.Clear();
            ServicesRecordClient ServicesRecordClient = new ServicesRecordClient();
            ServicesRecordClient.Dock = DockStyle.Fill;
            containerControl.Visible = false;
            containerControl.Controls.Add(ServicesRecordClient);
            await Task.Delay(10);
            containerControl.Visible = true;

        }
    }
}
