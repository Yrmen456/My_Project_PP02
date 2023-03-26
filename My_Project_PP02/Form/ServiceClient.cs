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
    public partial class ServiceClient : PatternForm
    {
        Service Service;
        public ServiceClient(Service Service)
        {
            InitializeComponent();
            this.Service = Service;
            this.Text = "Запись клиента на услугу";
            textBox1.Text = Service.Title;
            numericUpDown1.Value = Math.Round(Service.Cost, 2);
            numericUpDown2.Value = Service.Discount;
            textBox2.Text = Service.Description;
            ShowCommboBox();
        }

        private void ServiceClient_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;

            
            Time();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Time();
        }
        void Time()
        {
            int H = Service.DurationInSeconds / 60;
            int M = Service.DurationInSeconds % 60;
            var max1 = new TimeSpan(H, M, 00);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + max1;
            DateTime dateTime = (dateTimePicker1.Value.Date) + dateTimePicker3.Value.TimeOfDay + max1;
            label10.Text = $"Дата Окончания:{dateTime.ToString("dd.MM.yyyy HH:mm")}";
        }
        public async void ShowCommboBox()
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() => {
                dataSet = SQL.Table($@"Select *, (Client.FirstName+' '+Client.LastName+' '+Client.Patronymic) as FIO from Client");
            });


            if (dataSet.Tables.Count < 1)
            {

                return;
            }
            dataSet.Tables[0].TableName = "Client";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
    
            ClientArray ClientArray = new ClientArray();
            ClientArray = JsonConvert.DeserializeObject<ClientArray>(json);

     
            comboBox1.DataSource = ClientArray.Client;
            comboBox1.DisplayMember = "FIO";
            comboBox1.ValueMember = "ID";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Client items = (Client)comboBox1.SelectedItem;

            int H = Service.DurationInSeconds / 60;
            int M = Service.DurationInSeconds % 60;
            var max1 = new TimeSpan(H, M, 00);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + max1;
            DateTime dateTime = (dateTimePicker1.Value.Date) + dateTimePicker3.Value.TimeOfDay;
            bool result = false;
            string query = $@"INSERT INTO [dbo].[ClientService]
                       ([ClientID]
                       ,[ServiceID]
                       ,[StartTime]
                       ,[Comment])
                 VALUES
                       ('{items.ID}'
                       ,'{Service.ID}'
                       ,'{dateTime.ToString("yyyy.MM.dd HH:mm")}'
                       ,'{textBox3.Text}');";
            await Task.Run(() =>
            {
                result = SQL.Query(query);
            });

            if (result)
            {
                MessageBox.Show("Успех");
                this.Close();
            }
            else
            {
                MessageBox.Show("F");
            }

   
        }
    }
}
