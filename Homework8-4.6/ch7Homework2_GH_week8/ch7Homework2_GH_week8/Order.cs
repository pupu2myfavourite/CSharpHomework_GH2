using System;
using System.Collections.Generic;

namespace OrderManagement
{
    [Serializable]
    public class Order : IComparable
    {
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        public String ClientName { get; set; }
        public double OrderTotalMoney { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public Client client;

        public Order()
        {
        }
        public Order(int orderID, Client newClient, List<OrderItem> OrderItems)
        {
            OrderID = orderID;
            ClientID = newClient.ClientID;
            ClientName = newClient.ClientName;
            client = newClient;

            orderItems = OrderItems;
            foreach (OrderItem orderItem in orderItems){
                OrderTotalMoney += orderItem.OrderItemTotalMoney;
            }
        }
        public override string ToString()
        {
            return "orderID:" + OrderID + " -ClientID:" + ClientID+" -ClientName:"
                +ClientName+" -OrderTotalMoney:"+OrderTotalMoney; 
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
