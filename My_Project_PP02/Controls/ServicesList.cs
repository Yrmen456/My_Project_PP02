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
    public partial class ServicesList : UserControl
    {
        public ServicesList()
        {
            InitializeComponent();
            comboBoxDataSource();
            SQLServices();
        }

        public bool Update = false;
        void comboBoxDataSource()
        {
            Discount[] discounts = new Discount[]
            {
                    new Discount { DiscountMin = 0, DiscountMax =100 },
                    new Discount { DiscountMin = 0, DiscountMax =5 },
                    new Discount { DiscountMin = 5, DiscountMax =15 },
                    new Discount { DiscountMin = 15, DiscountMax =30 },
                    new Discount { DiscountMin = 30, DiscountMax =70 },
                    new Discount { DiscountMin = 70, DiscountMax =100 },
            };
            comboBoxSortByDiscount.DataSource = discounts;
            comboBoxSortByDiscount.DisplayMember = "DiscountText";

            Cost[] Condition = new Cost[]
            {
                new Cost { },
                new Cost {Condition = enumCost.Ascending },
                new Cost {Condition = enumCost.Descending },

            };
            comboBoxSortByCost.DataSource = Condition;
            comboBoxSortByCost.DisplayMember = "CostText";
        }

        public ServiceArray ServiceArray = new ServiceArray();

        public async void SQLServices()
        {

            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select * from Service");
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

            dataSet.Tables[0].TableName = "Service";
            string json = JsonConvert.SerializeObject(dataSet, Formatting.Indented);
            ServiceArray = JsonConvert.DeserializeObject<ServiceArray>(json, settings);
            ConclusionServices();
        }
        public ServicesListItems ThisServicesListItems;
        public async void ConclusionServices()
        {
            ServiceArray SortServiceArray = new ServiceArray();
        
            List<ServicesListItems> ListServicesListItems = new List<ServicesListItems>();
            ServicesListItems[] ArrServicesListItems = { };
            Discount itemsDiscount = (Discount)comboBoxSortByDiscount.SelectedItem;
            Cost itemsCost = (Cost)comboBoxSortByCost.SelectedItem;
     

            SortServiceArray.Service = ServiceArray.Service.Where(x => (x.Title.ToLower().Contains($"{textBox1.Text.ToLower()}") || x.Description.ToLower().Contains($"{textBox1.Text.ToLower()}"))  && x.Discount >= itemsDiscount._DiscountMin && x.Discount < itemsDiscount._DiscountMax).Select(x => x).ToList();
            switch (itemsCost.Condition)
            {
                case enumCost.Ascending:
                    SortServiceArray.Service = SortServiceArray.Service.OrderBy(x => (x.Cost - (x.Cost / 100 * x.Discount))).ToList();
                    break;
                case enumCost.Descending:
                    SortServiceArray.Service = SortServiceArray.Service.OrderByDescending(x => (x.Cost -(x.Cost / 100 * x.Discount))).ToList();
                    break;
                default:
                    SortServiceArray.Service = SortServiceArray.Service.OrderBy(x => x.Cost).ToList();
                    break;
            }
            await Task.Run(() => {
                for (int i = 0; i < SortServiceArray.Service.Count; i++)
                {
                    ServicesListItems ServicesListItems = new ServicesListItems(SortServiceArray.Service[i]);
                    ServicesListItems.Dock = DockStyle.Top;
                    ServicesListItems.ServicesList = this;
                    ServicesListItems.Name = "ServicesListItems" + i;
                    ListServicesListItems.Add(ServicesListItems);
                    if (ThisServicesListItems != null)
                    {
                        if (ServicesListItems.Service.ID == ThisServicesListItems.Service.ID)
                        {
                            ThisServicesListItems = ServicesListItems;
                        }
                    }
                }
            });
 
            containerServicesList.Visible = false;
            containerServicesList.Controls.Clear();
            ArrServicesListItems = ListServicesListItems.ToArray();
            ArrServicesListItems = ArrServicesListItems.Reverse().ToArray();
            containerServicesList.Controls.AddRange(ArrServicesListItems);
            containerServicesList.AutoScroll = true;
            containerServicesList.HorizontalScroll.Maximum = 0;
            containerServicesList.AutoScroll = false;
            containerServicesList.VerticalScroll.Maximum = 0;
            containerServicesList.AutoScroll = true;
            await Task.Delay(10);
            SortServiceArrayCount = SortServiceArray.Service.Count;
            Sort();
            containerServicesList.Visible = true;
            if (ThisServicesListItems != null)
            {
                ThisServicesListItems.Click();
            }
            
        
        }
        public int SortServiceArrayCount;
        public void Sort()
        {
            labelCountItems.Text = $"{SortServiceArrayCount} из {ServiceArray.Service.Count}";
        }
        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxSortByCost_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ConclusionServices();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConclusionServices();
        }
    }
    class Cost
    {
        public Cost()
        {
            Condition = enumCost.WithoutCondition;
        }
        public string CostText { get; set; } = "Без условия";
        public enumCost _Condition { get; set; }
        public enumCost Condition
        {
            get => _Condition;
            set
            {
                if (value != _Condition)
                {
                    _Condition = value;

                    switch (value)
                    {
                        case enumCost.Ascending:
                            CostText = "По возрастанию";
                            break;
                        case enumCost.Descending:
                            CostText = "По убыванию";
                            break;
                        default:
                            CostText = "Без условия";
                            break;
                    }
                }
            }
        }

    }
    enum enumCost
    {
        Ascending,
        Descending,
        WithoutCondition,
    }


    class Discount
    {
        public string DiscountText { get; set; } ="";
        public int _DiscountMin { get; set; } 

        public int DiscountMin
        {
            get => _DiscountMin;
            set
            {
                if (value != _DiscountMin)
                {
                    _DiscountMin = value;
                    NewDiscountText();
                }
            }
        } 

        public int _DiscountMax { get; set; }

        public int DiscountMax
        {
            get => _DiscountMax;
            set
            {
                if (value != _DiscountMax)
                {
                    _DiscountMax = value;
                    NewDiscountText();


                }
            }
        } 
        void NewDiscountText()
        {
            if (DiscountMin == 0 && DiscountMax ==100)
            {
                DiscountText = $"Все";
            }
            else
            {
                DiscountText = $"от {DiscountMin}% до {DiscountMax}%";
            }
            
        }

    }
}
