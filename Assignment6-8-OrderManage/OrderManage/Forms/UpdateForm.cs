using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage;
using OrderManage.src;

namespace OrderManage
{
    public partial class UpdateForm : Form
    {
        private readonly OrderService service = new OrderService();

        public UpdateForm()
        {
            InitializeComponent();
        }

        public UpdateForm(Order order)
        {
            Order = order;
            InitializeComponent();
            UpdateOrderIDText.Text = order.OrderId.ToString();
            UpdateCostomerTextBox.Text = order.Customer.ToString();
            UpdateOrderDetailsComboBox.DataSource = order.Details;
            UpdateOrderDetailsComboBox.DisplayMember = "ProductName";
        }
        public Order Order { get; }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 更新订单信息
                Order.Customer = UpdateCostomerTextBox.Text;


                // 保存订单
                service.Update(Order);

                // 关闭窗口
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存订单时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
