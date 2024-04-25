using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage.src;

namespace OrderManage
{
    public partial class CreateForm : Form
    {
        private readonly OrderService service = new OrderService();

        public CreateForm()
        {
            InitializeComponent();
            List<string> AllGoodsName = new List<string>();
            service.QueryAllGoods().ForEach(goods =>
            {
                AllGoodsName.Add(goods.GoodsName);
            });
            CreateGoodsComboBox.DataSource = AllGoodsName;
        }

        private void CreateBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAddButton_Click(object sender, EventArgs e)
        {
            string goodsName = CreateGoodsComboBox.SelectedItem.ToString();
            try
            {
                int quantity = int.Parse(CreateGoodsQuantityTextBox.Text);
                service.QueryAllGoods().ForEach(goods =>
                {
                    if (goods.GoodsName == goodsName)
                    {
                        CreateGoodsListBox.Items.Add(goods.GoodsName + ",数量:" + quantity);
                    }
                });
                CreateGoodsQuantityTextBox.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数量");
            }
        }

        private void CreateRemoveButton_Click(object sender, EventArgs e)
        {
            CreateGoodsListBox.Items.Remove(CreateGoodsListBox.SelectedItem);
        }

        private void CreateConfirmButton_Click(object sender, EventArgs e)
        {
            string newCustomer = CreateCostomerTextBox.Text;
            Order newOrder = new Order(newCustomer);

            List<string> AllgoodsName = new List<string>();
            foreach (var item in CreateGoodsListBox.Items)
            {
                string goodsNameCheck = item.ToString().Split(',')[0];
                if (AllgoodsName.Contains(goodsNameCheck))
                {
                    MessageBox.Show("请勿添加重复商品");
                    return;
                }
                AllgoodsName.Add(goodsNameCheck);
            }

            foreach (var item in CreateGoodsListBox.Items)
            {
                string[] goods = item.ToString().Split(',');
                string goodsName = goods[0];
                int quantity = 0;
                try
                {
                    quantity = int.Parse(goods[1].Substring(3));
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的数量");
                }
                service.QueryAllGoods().ForEach(goods =>
                {
                    if (goods.GoodsName == goodsName)
                    {
                        newOrder.AddDetails(new OrderDetail(goods, quantity));
                    }
                });
            }
            service.AddOrder(newOrder);
            this.Close();
        }
    }
}
