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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public UpdateForm(Order order)
        {
            Order = order;
            InitializeComponent();
            UpdateOrderIDText.Text = order.Id.ToString();
            UpdateCostomerTextBox.Text = order.Customer.ToString();
            UpdateOrderDetailsComboBox.DataSource = order.Details;
        }
        public Order Order { get; }
    }
}
