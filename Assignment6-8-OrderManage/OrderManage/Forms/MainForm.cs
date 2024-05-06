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
        string ControlInformationText = "����Զϲ��KizunaAi��������Ҫ��ʲô��";

        public void QueryAll(OrderService service)
        {
            OrdersDataGridView.DataSource = service.QueryAll();
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
                Order order = service.GetById(orderID);
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
            OrdersDataGridView.DataSource = service.QueryAll();
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            // ��ȡ��ǰѡ�е���
            if (OrdersDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = OrdersDataGridView.SelectedRows[0];
                var order = (Order)selectedRow.DataBoundItem;

                // ����ѯ���û��Ƿ�ȷ��ɾ��
                DialogResult result = MessageBox.Show($"ȷ��ɾ������ {order.OrderId} ��", "ȷ��ɾ��", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // ִ��ɾ������
                    service.RemoveOrder(order.OrderId);
                    RefreshButton_Click(sender, e); // ˢ��DataGridView
                }
            }
            else
            {
                MessageBox.Show("��ѡ��һ����������ɾ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
