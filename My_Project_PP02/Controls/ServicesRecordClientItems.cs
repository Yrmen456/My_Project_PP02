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

namespace My_Project_PP02.Controls
{
    public partial class ServicesRecordClientItems : UserControl
    {
        ClientService ClientService;
        public ServicesRecordClientItems(ClientService ClientService)
        {
            InitializeComponent();
            this.ClientService = ClientService;
            label1.Text = ClientService.ID.ToString();
            label2.Text = ClientService.FIO.ToString();
            label3.Text = ClientService.Title.ToString();
            label4.Text = ClientService.Email.ToString();
            label5.Text = ClientService.Phone.ToString();
            label6.Text = ClientService.StartTime.ToString();

            label7.Text = $@"{(ClientService.StartTime - DateTime.Now)}";
            if ((ClientService.StartTime - DateTime.Now).Days >= 1)
            {
                return;
            }
            if ((ClientService.StartTime - DateTime.Now).Hours < 1)
            {
                panel1.BackColor = Color.Red;
            }
            else
            {

            }
        }

            private void ServicesRecordClientItems_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
           
            if (ClientService.StartTime >= DateTime.Now)
            {
                label7.Text = $@"{(ClientService.StartTime - DateTime.Now)}";
                if ((ClientService.StartTime - DateTime.Now).Days >=1)
                {
                    return;
                }
                if ((ClientService.StartTime - DateTime.Now).Hours <1)
                {
                    panel1.BackColor = Color.Red;
                }
                else
                {
                    panel1.BackColor = Color.White;
                }
            }
            else
            {
                this.Dispose();
            }
        }
    }
}
