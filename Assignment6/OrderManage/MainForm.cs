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
        string ControlInformationText = "����Զϲ��KizunaAi��������Ҫ��ʲô��";

        public void UpdateOrdersDataGridView()
        {
            OrdersDataGridView.DataSource = GlobalVariables.OrderService.QueryAll();
        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            ControlInformationText = "���¶���������������ı������붩����";
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
                    ControlInformationText = "���������ڣ�����������";
                    ControlInformation.Text = ControlInformationText;
                    return;
                }
                new UpdateForm(order).Show();

            }
            catch (Exception)
            {
                ControlInformationText = "�����������������������";
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
