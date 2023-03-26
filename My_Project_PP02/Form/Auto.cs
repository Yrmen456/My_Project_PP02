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
using Newtonsoft.Json;

namespace My_Project_PP02
{
    public partial class Auto : PatternForm
    {
        public Auto()
        {
            InitializeComponent();
        }
        bool visible_password_click = true;
        private void visible_password_Paint(object sender, PaintEventArgs e)
        {

        }

        private void visible_password_Click(object sender, EventArgs e)
        {
            if (visible_password_click)
            {

                visible_password_click = false;
                password_textbox.UseSystemPasswordChar = false;
                visible_password.BackgroundImage = Properties.Resources.open;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
                visible_password_click = true;
                visible_password.BackgroundImage = Properties.Resources.close;
            }
        }

        private void form_authorization_MouseDown(object sender, MouseEventArgs e)
        {
            form_authorization.Capture = false;
            labelTitle.Capture = false;
            pictureBox_logo.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void login_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void login_up_Click(object sender, EventArgs e)
        {

            if (password_textbox.Text == ProgramData.AdminCode)
            {
                User.Role = Roles.Admin;
            }
            else
            {
                User.Role = Roles.Client;
            }
            Program._Main.RoleAccess();
            this.Close();

        }
    }

}
