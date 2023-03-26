using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Project_PP02.Data;
using Newtonsoft.Json;

namespace My_Project_PP02.Controls
{
    public partial class ServicesAddEdit : UserControl
    {
        public ServicesAddEdit()
        {
            InitializeComponent();
      
        }
        public Service Service = new Service();
        public ServicesList ServicesList;
        public ServicesAddEdit(Service Service)
        {
            InitializeComponent();
         
            this.Service = Service;
            textBox1.Text = Service.Title;
            numericUpDown1.Value = Math.Round(Service.Cost,2);
            numericUpDown2.Value = Service.Discount;
            textBox2.Text = Service.Description;
            ShowPhoto();
        }
        private void ServicesAddEdit_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;";
            var max = new TimeSpan(4, 00, 00);
            dateTimePicker2.Value = new DateTime(2002, 01, 1, 00, 00, 00);
            int H = Service.DurationInSeconds / 60;
            int M = Service.DurationInSeconds % 60;
            var max1 = new TimeSpan(H, M, 00);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + max1;
            pictureBox2.Tag = false;

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var max = new TimeSpan(4, 00, 00);
            if (dateTimePicker2.Value.TimeOfDay >= max)
            {
                dateTimePicker2.Value = dateTimePicker2.Value.Date + max;
            }
        
        }
        public async void SQLServices()
        {

            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select * from ServicePhoto where ServiceID  = {Service.ID}");
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

            dataSet.Tables[0].TableName = "ServicePhoto";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            ServicePhotos ServicePhotos = new ServicePhotos();
            ServicePhotos = JsonConvert.DeserializeObject<ServicePhotos>(json);
      
     
            panel1.Visible = false;

            pictureBoxs =  PhotoAdd(new Bitmap(500,500),new ServicePhotoItems(), false);
            for (int i = 0; i < ServicePhotos.ServicePhoto.Count; i++)
            {
                ServicePhotoItems servicePhotoItems = new ServicePhotoItems();
                servicePhotoItems = ServicePhotos.ServicePhoto[i];
                Bitmap BT = (Bitmap)Bitmap.FromFile($@"{startupPath}\ImgService\{servicePhotoItems.PhotoPath}");
                PhotoAdd(BT, servicePhotoItems, false);
            }
            pictureBoxs.Dispose();
            await Task.Delay(10);
            panel1.Visible = true;
        }
        PictureBox pictureBoxs;
        string startupPath = Environment.CurrentDirectory;
        async void ShowPhoto()
        {

            try
            {
                pictureBox2.Image = Image.FromFile($@"{startupPath}\ImgService\{Service.MainImagePath}");
            }
            catch
            {

            }
            await Task.Delay(1000);
            SQLServices();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if (ServicesList !=null)
            {
                if (ServicesList.Update)
                {
                    ServicesList.ThisServicesListItems.FocusBottom.Focus();
                }
                else
                {
                    ServicesList.ThisServicesListItems.FocusTop.Focus();
                }
                
                
            }
         
            ServicesList.Update = false;
        }


        private void pictureBoxbutton_Click(object sender, EventArgs e)
        {
            Button Button  = (Button)sender;
            ServicePhotoItems pictureBox = (ServicePhotoItems)Button.Tag;
            bool result = SQL.Query($@"DELETE FROM [dbo].[ServicePhoto]
            WHERE ServicePhoto.ID = {pictureBox.ID}");
            if (result)
            {
                pictureBox.PictureBox.Dispose();
 
            }
           

            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            pictureBox2.Image = Image.FromFile(filename);
            pictureBox2.Tag = true;
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (Service.ID ==0) 
            {
               MessageBox.Show("Картинки Можно Добавить только к существующей услуге");
               return;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            pictureBoxs = PhotoAdd(new Bitmap(500, 500), new ServicePhotoItems(), false);

            
            string filename = openFileDialog1.FileName;
            PhotoAdd((Bitmap)Bitmap.FromFile(filename),new ServicePhotoItems(), true);

            pictureBoxs.Dispose();

        }
      
        
        PictureBox PhotoAdd(Bitmap BT, ServicePhotoItems ServicePhotoItems, bool add)
        {
            PictureBox pictureBox = new PictureBox();

            try
            {
                pictureBox.Dock = DockStyle.Left;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                panel1.Controls.Add(pictureBox);
                pictureBox.Image = BT;
                decimal R = BT.Height / pictureBox.Height;
                  
                if (R == 0)
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else
                {
                    pictureBox.Width = (BT.Width / Convert.ToInt32(R));
                }

                ServicePhotoItems.PictureBox = pictureBox;
                pictureBox.Tag = true;
                Button button = new Button();
                button.Text = "Delete";
                button.Tag = ServicePhotoItems;
                button.Click += pictureBoxbutton_Click;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.Controls.Add(button);
                Random random = new Random();
                string PhotoName = $"Photo{DateTime.Now.ToString("yyyy.MM.dd.HH_mm.ss_")}{random.Next(1, 100000)}.png";
                if (add)
                {
                    bool result = SQL.Query($@"INSERT INTO [dbo].[ServicePhoto]
                       ([ServiceID]
                       ,[PhotoPath])
                     VALUES
                       ('{Service.ID}'
                       ,'{PhotoName}')");
                    if (result)
                    {
                        pictureBox.Image.Save($@"{startupPath}\ImgService\{PhotoName}", System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
                
                
            }
            catch (Exception)
            {
                return pictureBox;

            }
            return pictureBox;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }


        private async void button3_Click(object sender, EventArgs e)
        {
      
            
            if (Service.ID == 0)
            {
                Insert();
            }
            else
            {
                Update();
                if (this.ServicesList != null)
                {
                    await Task.Delay(100);
                    button1.Visible = true;
                }
                
              
            }
           
        }

        async void Update()
        {
          
           
            DataSet dataSet = new DataSet();
            string Cost = Math.Round(numericUpDown1.Value,2).ToString().Replace(",", ".");
            string Discount = Math.Round(numericUpDown2.Value, 2).ToString().Replace(",", ".");

            bool result = (bool)pictureBox2.Tag;
            if (result)
            {
                Random random = new Random();
                string PhotoName = $"Photo{DateTime.Now.ToString("yyyy.MM.dd.HH_mm.ss_")}{random.Next(1, 100000)}.png";
                pictureBox2.Image.Save($@"{startupPath}\ImgService\{PhotoName}", System.Drawing.Imaging.ImageFormat.Png);
                Service.MainImagePath = PhotoName;
            }
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"UPDATE [dbo].[Service]
                   SET [Title] = N'{textBox1.Text}'
                      ,[Cost] = '{Cost}'
                      ,[DurationInSeconds] = '{(dateTimePicker2.Value.Hour * 60) + dateTimePicker2.Value.Minute}'
                      ,[Description] = N'{textBox2.Text }'
                      ,[Discount] = '{Discount}'
                      ,[MainImagePath] = N'{Service.MainImagePath}'
                 WHERE [Service].ID = {Service.ID};
                 Select * from Service WHERE [Service].ID = {Service.ID}  "
                 );
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
                MessageBox.Show("F2");
                return;
            }

            string json = JsonConvert.SerializeObject(dataSet.Tables[0], Formatting.Indented);
            json = json.Trim('[', ']');
          
            Service = JsonConvert.DeserializeObject<Service>(json);
            this.ServicesList.ThisServicesListItems.Service = Service;
            this.ServicesList.ThisServicesListItems.ShowItems();
            MessageBox.Show("Успех");
        }
        async void Insert()
        {
      

            DataSet dataSet = new DataSet();
            string Cost = Math.Round(numericUpDown1.Value, 2).ToString().Replace(",", ".");
            string Discount = Math.Round(numericUpDown2.Value, 2).ToString().Replace(",", ".");
            Random random = new Random();
            string PhotoName = $"Photo{DateTime.Now.ToString("yyyy.MM.dd.HH_mm.ss_")}{random.Next(1, 100000)}.png";
            pictureBox2.Image.Save($@"{startupPath}\ImgService\{PhotoName}", System.Drawing.Imaging.ImageFormat.Png);
            Service.MainImagePath = PhotoName;

            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"INSERT INTO [dbo].[Service]
                       ([Title]
                       ,[Cost]
                       ,[DurationInSeconds]
                       ,[Description]
                       ,[Discount]
                       ,[MainImagePath])
                 VALUES
                       (N'{textBox1.Text}'
                       ,'{Cost}'
                       ,'{(dateTimePicker2.Value.Hour * 60) + dateTimePicker2.Value.Minute}'
                       ,N'{textBox2.Text }'
                       ,'{Discount}'
                       ,N'{Service.MainImagePath}');
                 Select * from Service WHERE [Service].ID = SCOPE_IDENTITY()"
                 );
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
                MessageBox.Show("F2");
                return;
            }

            string json = JsonConvert.SerializeObject(dataSet.Tables[0], Formatting.Indented);
            json = json.Trim('[', ']');

            Service = JsonConvert.DeserializeObject<Service>(json);
            
            MessageBox.Show("Успех");

        }
    }
    class ServicePhotos
    {
        public List<ServicePhotoItems> ServicePhoto { get; set; }
    }


    class ServicePhotoItems
    {
        public PictureBox PictureBox { get; set; }
        public int ID { get; set; }
        public int ServiceID { get; set; }
        public string PhotoPath { get; set; }
    }
}
