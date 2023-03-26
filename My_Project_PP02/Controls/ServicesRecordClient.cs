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

namespace My_Project_PP02.Controls
{
    public partial class ServicesRecordClient : UserControl
    {
        public ServicesRecordClient()
        {
            InitializeComponent();
           
        }

        private void ServicesRecordClient_Load(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (30000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            SQLServicesRecordClient(DateTime);
        }
        ClientServiceArray ClientServiceArray = new ClientServiceArray();
        public async void SQLServicesRecordClient(DateTime dateTime)
        {
            containerServicesList.Controls.Clear();
            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select *, DATEADD(MINUTE, Service.DurationInSeconds, ClientService.StartTime ) as EndDate, 
                (Client.FirstName+' '+Client.LastName+' '+Client.Patronymic) as FIO
                from ClientService
                inner join Client Client on Client.ID = ClientService.ClientID
                inner join Service Service on Service.ID = ClientService.ServiceID
                where Cast(DATEADD(MINUTE, Service.DurationInSeconds, ClientService.StartTime ) as date)  = '{dateTime.ToString("yyyy-MM-dd")}'
                and  ClientService.StartTime >= GETDate()
                Order By DATEADD(MINUTE, Service.DurationInSeconds, ClientService.StartTime )");
            });
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            if (dataSet.Tables.Count <= 0)
            {
                MessageBox.Show("F1");
                return;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            dataSet.Tables[0].TableName = "ClientService";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            ClientServiceArray = JsonConvert.DeserializeObject<ClientServiceArray>(json, settings);

            ConclusionServicesRecordClient();
        }
        public ServicesListItems ThisServicesListItems;
        public async void ConclusionServicesRecordClient()
        {
            containerServicesList.Controls.Clear();
            for (int i = 0; i < ClientServiceArray.ClientService.Count; i++)
            {
                
            }
            List<ServicesRecordClientItems> ListClientService = new List<ServicesRecordClientItems>();
            ServicesRecordClientItems[] ArrClientService = { };
            await Task.Run(() => {
                for (int i = 0; i < ClientServiceArray.ClientService.Count; i++)
                {
                    ServicesRecordClientItems ServicesRecordClientItems = new ServicesRecordClientItems(ClientServiceArray.ClientService[i]);
                    ServicesRecordClientItems.Dock = DockStyle.Top;

                    ServicesRecordClientItems.Name = "ServicesRecordClientItems" + i;
                    ListClientService.Add(ServicesRecordClientItems);

                }
            });

            containerServicesList.Visible = false;
           
            ArrClientService = ListClientService.ToArray();
            ArrClientService = ArrClientService.Reverse().ToArray();
            containerServicesList.Controls.AddRange(ArrClientService);
            containerServicesList.AutoScroll = true;
            containerServicesList.HorizontalScroll.Maximum = 0;
            containerServicesList.AutoScroll = false;
            containerServicesList.VerticalScroll.Maximum = 0;
            containerServicesList.AutoScroll = true;
            await Task.Delay(10);
            //SortServiceArrayCount = SortServiceArray.Service.Count;
            
            containerServicesList.Visible = true;
           


        }
        DateTime DateTime = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime = DateTime.Now;
            SQLServicesRecordClient(DateTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime = DateTime.Now.AddDays(+1);
            SQLServicesRecordClient(DateTime);
        }
    }
}
