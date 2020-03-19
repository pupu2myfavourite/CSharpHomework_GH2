using System;

namespace OrderManagement
{
    public class Order : IComparable
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int ClientID { get; set; }

        public OrderItem orderItem;
        public Client client;

        public Order()
        {
        }
        public Order(int orderID, Client newClient, OrderItem newOrderItem)
        {
            OrderID = orderID;
            ClientID = newClient.ClientID;
            ProductID = newOrderItem.ProductID;

            client = newClient;
            orderItem = newOrderItem;
        }
        public override string ToString()
        {

            //这个被注释的方法会报错，暂时没解决
            //return "OrderID:"+OrderID +" -OrderItem:"+orderItem.ToString()
            //+"-Client:"+client.ToString();
            return "orderID:" + OrderID + " -ProductID:" + orderItem.ProductID; //+
                //" -ProductName"+orderItem.product.ProductName;
        }

        public int CompareTo(object obj)
        {
            Order otherOrder = obj as Order;
            if (this.OrderID > otherOrder.OrderID)
            {
                return 1;
            }
            else if (this.OrderID == otherOrder.OrderID)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override bool Equals(object obj)
        {

            if (this.CompareTo(obj) != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }       
    }
}
