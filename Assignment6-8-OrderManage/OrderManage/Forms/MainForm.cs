using Microsoft.EntityFrameworkCore;
using OrderManage.sql;
using OrderManage.src;
using System;
using System.Windows.Forms;

namespace OrderManage
{
    public partial class MainForm : Form
    {
        private readonly OrderService service = new OrderService();

        public MainForm()
        {
            InitializeComponent();
            ControlInformation.Text = ControlInformationText;
            OrderIDArea.Visible = false;
            QueryAll(service);
        }
        string ControlInformationText = "我永远喜欢KizunaAi！今天想要干什么？";

        public void QueryAll(OrderService service)
        {
            OrdersDataGridView.DataSource = service.QueryAll();
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
                Order order = service.GetById(orderID);
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
            OrdersDataGridView.DataSource = service.QueryAll();
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            // 获取当前选中的行
            if (OrdersDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = OrdersDataGridView.SelectedRows[0];
                var order = (Order)selectedRow.DataBoundItem;

                // 弹窗询问用户是否确认删除
                DialogResult result = MessageBox.Show($"确认删除订单 {order.OrderId} 吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 执行删除操作
                    service.RemoveOrder(order.OrderId);
                    RefreshButton_Click(sender, e); // 刷新DataGridView
                }
            }
            else
            {
                MessageBox.Show("请选择一个订单进行删除。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
