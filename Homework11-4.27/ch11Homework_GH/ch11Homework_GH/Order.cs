using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ch11Homework_GH
{
    [Serializable]
    public class Order : IComparable
    {
        [Key]
        public int OrderID { get; set; }
        [NotMapped]
        public int ClientID { get; set; }
        [NotMapped]
        public string ClientName { get; set; }
        [NotMapped]
        public double OrderTotalMoney { get; set; }
        [Required]
        public List<OrderItem> orderItems { get; set; }
        [Required]
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
