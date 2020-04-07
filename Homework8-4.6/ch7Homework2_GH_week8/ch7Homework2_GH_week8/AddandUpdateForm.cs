using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
namespace ch7Homework2_GH_week8
{
    public partial class AddandUpdateForm : Form
    {

        private Order CurrentOrder;
        private Order UpdateOrder;
        private OrderItem CurrentOrderItem;
        private OrderItem UpdateOrderItem = new OrderItem();

        public AddandUpdateForm(int index1, int index2)
        {
            InitializeComponent();
            CurrentOrder = OrderService.OrderList[index1];
            CurrentOrderItem = CurrentOrder.orderItems[index2];

            UpdateOrder = CurrentOrder;
            UpdateOrderItem = CurrentOrderItem;

        }

        private void OrderAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OrderService.OrderList.Add(UpdateOrder);
            }
            catch
            {
                MessageBox.Show("创建订单错误");
            }
        }

        private void OrderItemAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.orderItems.Add(UpdateOrderItem);
            }
            catch
            {
                MessageBox.Show("插入OrderItem错误，请重试");
            }

        }

        private void AddandUpdateForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UpdateOrder;

            
            OrderID.DataBindings.Add("Text", UpdateOrder, "OrderID");
            //OrderID.DataBindings.Add("Text", UpdateOrderItem, "OrderID");

            ClientID.DataBindings.Add("Text", UpdateOrder, "ClientID");
            ClientName.DataBindings.Add("Text", UpdateOrder, "ClientName");
            OrderTotalMoney.DataBindings.Add("Text", UpdateOrder, "OrderTotalMoney");

            ProductID.DataBindings.Add("Text", UpdateOrderItem, "ProductID");
            ProductName.DataBindings.Add("Text", UpdateOrderItem, "ProductName");
            UnitPrice.DataBindings.Add("Text", UpdateOrderItem, "UnitPrice");
            ProductNum.DataBindings.Add("Text", UpdateOrderItem, "ProductNum");
            OrderItemTotalMoney.DataBindings.Add("Text", UpdateOrderItem, "OrderItemTotalMoney");


        }
    }
}
