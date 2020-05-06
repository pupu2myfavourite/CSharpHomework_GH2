using ch11Homework_GH;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ch11Homework_GH
{
    class NewOrderService
    {
        //add
        public bool AddOrder(Order order)
        {
            using (var database = new OrderContext())
            {
                database.Orders.Add(order);
                int result = database.SaveChanges();
                return result> 0 ? true : false;
            }
        }

        //delete
        public bool DeleteOrder(int orderID)
        {
            using (var database = new OrderContext())
            {
                var deleteOrder = database.Orders.
                   Include(o => o.orderItems).
                   Include(o => o.client).
                   Include(o => o.orderItems.Select(i => i.product)).
                   FirstOrDefault(o => o.OrderID == orderID);

                if(deleteOrder != null)
                {
                    database.Orders.Remove(deleteOrder);
                    int result = database.SaveChanges();
                    return result > 0 ? true : false;
                }
                return false;
            }
        }

        //update
        public bool UpdateOrder(int orderID,Order updateOrder)
        {
            using (var databse = new OrderContext())
            {
                var oldOrder = databse.Orders.
                    Include(o=>o.orderItems).
                    Include(o=>o.client).
                    Include(o=>o.orderItems.Select(i => i.product)).
                    FirstOrDefault(o => o.OrderID == orderID);
              
                if(updateOrder != null)
                {
                    oldOrder.client = updateOrder.client;
                    oldOrder.orderItems = updateOrder.orderItems;
                    databse.Entry(oldOrder).State = EntityState.Modified;
                    int result = databse.SaveChanges();
                    return result > 0 ? true : false;
                }
                return false;
            }
        }

        //select
        public List<Order> SelectOrder(string from, string condition)
        {
            using (var database = new OrderContext())
            {
                switch (from)
                {
                    case "Order ID":
                        int orderID = 0;
                        int.TryParse(condition, out orderID);
                        List<Order> list1 = database.Orders.
                            Include(o => o.orderItems).
                            Include(o => o.client).
                            Include(o => o.orderItems.Select(i => i.product)).
                            Where(o => o.OrderID == orderID).ToList();
                        list1.Sort();
                        return list1;

                    case "Client Name":
                        List<Order> list2 = database.Orders.
                            Include(o => o.orderItems).
                            Include(o => o.client).
                            Include(o => o.orderItems.Select(i => i.product)).
                            Where(o => o.client.ClientName == condition).ToList();
                        list2.Sort();
                        return list2;

                    case "Client ID":
                        int clientID = 0;
                        int.TryParse(condition, out clientID);
                        List<Order> list3 = database.Orders.
                            Include(o => o.orderItems).
                            Include(o => o.client).
                            Include(o => o.orderItems.Select(i => i.product)).
                            Where(o => o.client.ClientID == clientID).ToList();
                        list3.Sort();
                        return list3;

                    case "All":
                        List<Order> list4 = database.Orders.
                            Include(o => o.orderItems).
                            Include(o => o.client).
                            Include(o => o.orderItems.Select(i => i.product)).ToList();
                        list4.Sort();
                        return list4;

                    default:
                        return null;
                }
            }
        }

        //输出订单到xml文件
        public void Export(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (var database = new OrderContext())
            {
                List<Order> orders = database.Orders.
                    Include(o => o.orderItems).
                    Include(o => o.client).
                    Include(o => o.orderItems.Select(i => i.product)).ToList();
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, orders);
                }
            }
        }

        //从xml导入订单信息
        public void Import(String path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> importedOrderList = (List<Order>)xmlSerializer.Deserialize(fs);
                for(int i = 0; i < importedOrderList.Count; i++)
                {
                    AddOrder(importedOrderList[i]);
                }
            }
        }
    }
}
