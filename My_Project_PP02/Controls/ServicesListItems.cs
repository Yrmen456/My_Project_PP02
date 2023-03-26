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
    public partial class ServicesListItems : UserControl
    {
        public Service Service;
        Color Color;
        public ServicesList ServicesList;
        public ServicesListItems(Service Service)
        {
            InitializeComponent();
            this.Service = Service;
            
            ShowItems();
            switch (User.Role)
            {
                case Roles.Admin:
                    btnDelete.Visible = true;
                    btnEdit.Visible = true;
                    btnRecordClient.Visible = true;
                    break;
                default:
                    btnDelete.Visible = false;
                    btnEdit.Visible = false;
                    btnRecordClient.Visible = false;
                    break;
            }
         
        }
        public void ShowItems()
        {
            decimal Time = Math.Round(decimal.Parse(Service.DurationInSeconds.ToString()) / 60, 2);
            ShowPhoto();
            labelName.Text = Service.Title;
            if (Service.Discount > 0)
            {
                string g = Encoding.UTF8.GetString(new byte[] { 204, 182 });
                labelDiscount.Text = $"^ скидка {Service.Discount} %";
                string Cost = string.Join(g, Math.Round(Service.Cost, 2).ToString().AsEnumerable()).Insert(0, g);

                labelCostTime.Text = Cost + $" {Math.Round(Service.Cost - (Service.Cost / 100 * Service.Discount), 2)} рублей за {Service.DurationInSeconds} минут";
                panel3.BackColor = Color.LightGreen;
            }
            else
            {
                labelDiscount.Text = $"";
                labelCostTime.Text = Math.Round(Service.Cost, 2) + $" рублей за {Service.DurationInSeconds} минут";
            }
            Color = panel3.BackColor;
        }
        string startupPath = Environment.CurrentDirectory;
        public async void ShowPhoto()
        {
    
            try
            {
                pictureBoxServiceImg.Image = Image.FromFile($@"{startupPath}\ImgService\{Service.MainImagePath}");
            }
            catch
            {
                
            }
        }
        public void Click()
        {
            if (this.ServicesList.ThisServicesListItems !=null)
            {
                this.ServicesList.ThisServicesListItems.ThisBackColor(Selected.No);
            }
           
            this.ServicesList.ThisServicesListItems = this;
            this.ServicesList.ThisServicesListItems.ThisBackColor(Selected.Yes);

        }
        public void ThisBackColor(Selected selected)
        {

            if (selected == Selected.Yes)
            {
                panel3.BackColor = MyColors.FocusingAttention;
            }
            else if (selected == Selected.No)
            {
                panel3.BackColor = this.Color;
            }

        }
        private void ServicesListItems_Click(object sender, EventArgs e)
        {
            Click();
        }
        private void ServicesListItems_Paint(object sender, PaintEventArgs e)
        {
          
        }
        public enum Selected
        {
            Yes,
            No,
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            Click();
            ServicesAddEdit ServicesAddEdit = new ServicesAddEdit(Service);
            ServicesAddEdit.Dock = DockStyle.Fill;
            ServicesAddEdit.ServicesList = ServicesList;
            Program._Main.containerControl.Visible = false;
            ServicesAddEdit.button1.Visible = true;
            Program._Main.containerControl.Controls.Add(ServicesAddEdit);
            Program._Main.containerControl.Controls.SetChildIndex(ServicesAddEdit, 0);
            await Task.Delay(10);

            Program._Main.containerControl.Visible = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool Result = SQL.Query($@"DELETE FROM [dbo].[Service]
            WHERE [Service].ID = {Service.ID}");
            if (!Result)
            {
                MessageBox.Show("На эту услугу есть записи");
            }
            this.ServicesList.ServiceArray.Service = this.ServicesList.ServiceArray.Service.Where(x => x.ID != Service.ID).Select(x => x).ToList();
            this.ServicesList.SortServiceArrayCount--;
            this.ServicesList.Sort();
            this.Hide();

        }
        private void btnRecordClient_Click(object sender, EventArgs e)
        {
            Click();
            ServiceClient ServiceClient = new ServiceClient(Service);
            ServiceClient.Show();
        }

        
    }
}
