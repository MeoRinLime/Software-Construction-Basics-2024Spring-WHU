using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderManage
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();

            List<string> options = new List<string>
            {
                "苹果", "鸡蛋", "牛奶", "面包", "蛋糕", "电脑", "手机", "书籍"
            };

            CreateGoodsComboBox.DataSource = options;

        }

        private void CreateBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAddButton_Click(object sender, EventArgs e)
        {
            string goodsName = CreateGoodsComboBox.SelectedItem.ToString();
            string goodsNameEng = " ";
            switch (goodsName)
            {
                case "苹果":
                    goodsNameEng = "apple";
                    break;
                case "鸡蛋":
                    goodsNameEng = "egg";
                    break;
                case "牛奶":
                    goodsNameEng = "milk";
                    break;
                case "面包":
                    goodsNameEng = "bread";
                    break;
                case "蛋糕":
                    goodsNameEng = "cake";
                    break;
                case "电脑":
                    goodsNameEng = "computer";
                    break;
                case "手机":
                    goodsNameEng = "phone";
                    break;
                case "书籍":
                    goodsNameEng = "book";
                    break;
            }
            try
            {
                int quantity = int.Parse(CreateGoodsQuantityTextBox.Text);

                GlobalVariables.AllGoods.ForEach(goods =>
                {
                    if (goods.Name == goodsNameEng)
                    {
                        CreateGoodsListBox.Items.Add($"{goodsName}, 数量：{quantity}");
                    }
                });
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
            Order newOrder = new Order();
            newOrder.Customer = CreateCostomerTextBox.Text;
            newOrder.Id = newOrder.GetHashCode();
        }
    }
}
