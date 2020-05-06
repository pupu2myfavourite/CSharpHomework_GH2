using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ch11Homework_GH;

namespace ch11Homework_GH
{
    public partial class AddandUpdateForm : Form
    {
        private int mode;//0为添加，1为修改
        private NewOrderService newOrderService;
        private Order CurrentOrder;
        private OrderItem CurrentOrderItem;    
        public AddandUpdateForm(int mode, Order order)
        {
            InitializeComponent();
            newOrderService = new NewOrderService();
            this.mode = mode;
            CurrentOrder = order;
        }

        private void OrderAddUpdate_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    try
                    {
                        //OrderService.OrderList.Add(CurrentOrder);
                        newOrderService.AddOrder(CurrentOrder);
                    }
                    catch
                    {
                        MessageBox.Show("创建订单错误");
                    }
                    break;
                case 1:
                    try
                    {
                        //OrderService.UpdateOrder(CurrentOrder.OrderID, CurrentOrder);
                        newOrderService.UpdateOrder(CurrentOrder.OrderID, CurrentOrder);
                    }
                    catch
                    {
                        MessageBox.Show("修改订单错误");
                    }
                    break;
            }
           
            DialogResult = DialogResult.OK;
        }

        private void OrderItemAddUpdate_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    try
                    {
                        newOrderService.AddOrder(CurrentOrder);
                    }
                    catch
                    {
                        MessageBox.Show("创建OrderItem错误");
                    }
                    break;
                case 1:
                    try
                    {
                        newOrderService.UpdateOrder(CurrentOrder.OrderID, CurrentOrder);
                    }
                    catch
                    {
                        MessageBox.Show("修改OrderItem错误");
                    }
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void AddandUpdateForm_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = CurrentOrder;

            OrderItembindingSource.DataSource = CurrentOrder;
            OrderItembindingSource.DataMember = "orderItems";


            OrderID.DataBindings.Add("Text", CurrentOrder, "OrderID");

            ClientID.DataBindings.Add("Text", CurrentOrder, "ClientID");
            ClientName.DataBindings.Add("Text", CurrentOrder, "ClientName");
            OrderTotalMoney.DataBindings.Add("Text", CurrentOrder, "OrderTotalMoney");

            //ProductID.DataBindings.Add("Text", CurrentOrderItem, "ProductID");
            //ProductName.DataBindings.Add("Text", CurrentOrderItem, "ProductName");
            //UnitPrice.DataBindings.Add("Text", CurrentOrderItem, "UnitPrice");
            //ProductNum.DataBindings.Add("Text", CurrentOrderItem, "ProductNum");
            //OrderItemTotalMoney.DataBindings.Add("Text", CurrentOrderItem, "OrderItemTotalMoney");


        }
    }
}
