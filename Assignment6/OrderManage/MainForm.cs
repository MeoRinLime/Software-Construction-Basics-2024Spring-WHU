using OrderApp;
using System;
using System.Windows.Forms;

namespace OrderManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ControlInformation.Text = ControlInformationText;
            OrderIDArea.Visible = false;
            OrdersDataGridView.DataSource = GlobalVariables.OrderService.QueryAll();

        }
        string ControlInformationText = "我永远喜欢KizunaAi！今天想要干什么？";

        public void UpdateOrdersDataGridView()
        {
            OrdersDataGridView.DataSource = GlobalVariables.OrderService.QueryAll();
        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            ControlInformationText = "更新订单，请在下面的文本框输入订单号";
            ControlInformation.Text = ControlInformationText;
            OrderIDArea.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmOrderID_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(InputOrderID.Text);
                Order order = new OrderService().GetById(orderID);
                if (order == null)
                {
                    ControlInformationText = "订单不存在，请重新输入";
                    ControlInformation.Text = ControlInformationText;
                    return;
                }
                new UpdateForm(order).Show();

            }
            catch (Exception)
            {
                ControlInformationText = "订单号输入错误，请重新输入";
                ControlInformation.Text = ControlInformationText;
            }
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            new CreateForm().Show();
        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            OrdersDataGridView.DataSource = GlobalVariables.OrderService.QueryAll();
        }
    }
}
