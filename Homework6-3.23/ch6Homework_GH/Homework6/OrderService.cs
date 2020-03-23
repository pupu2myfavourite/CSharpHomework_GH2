using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManagement
{
    [Serializable]
    public class OrderService
    {
        static List<Order> OrderList = new List<Order> { };

        //四种业务：添加、删除、修改、查询订单
        //添加订单
        public static bool CreateOrder(Order order)
        {
            foreach(Order o in OrderList)
            {
                if (o.Equals(order))
                {
                    Console.WriteLine("创建失败，订单已存在!  OrderID:"+ order.OrderID);
                    return false;
                }
            }
            //Order order = new Order(OrderID, newClient, newOrderItem);
            OrderList.Add(order);
            Console.WriteLine("添加订单成功！ OrderID:"+order.OrderID );
            return true;
        }

        //查询订单
        public static bool QueryOrder(int orderID,out IEnumerable<Order> orders)
        {
            //可以用OrderBy来对订单进行排序
            IEnumerable<Order> order = from o in OrderList
                                       where o.OrderID == orderID
                                       orderby o.orderItem.TotalMoney ascending
                                       select o;          
            if (order.Count() > 0)
            {
                orders = order;
                return true;
            }
            else
            {
                orders = null;
                return false;
            }
            //Console.WriteLine("查询结果:");
            //foreach(var o in order)
            //{
            //    Console.WriteLine(o.ToString());
            //}

        }

        //修改订单
        public static bool UpdateOrder(int orderID,int ProductID)
        {
            IEnumerable<Order> order = from o in OrderList
                          where o.OrderID == orderID
                          select o;
            if(order.Count() > 0)//查询到有此订单
            {
                foreach (var o in OrderList)//找到OrderList中的此订单，进行修改
                {
                    if(o.OrderID == orderID)
                    {
                        o.ProductID = ProductID;
                    }

                }
                //Console.WriteLine("修改成功！");
                return true;
            }
            else//未查询到订单
            {
                //Console.WriteLine("修改失败，未查询到订单。");
                return false;
            }
             
        }

        //删除订单
        public static bool DeleteOrder(int orderID)
        {
            IEnumerable<Order> order = from o in OrderList
                                       where o.OrderID == orderID
                                       select o;
            
            if(order.Count() > 0)//查询到由此订单
            {
                foreach (var o in OrderList)
                {
                    if (o.OrderID == orderID)
                    {
                        //OrderList.Append(o);
                        OrderList.Remove(o);
                        break;
                    }
                }
                Console.WriteLine("删除成功！");
                return true;
            }
            else//微查询到此订单
            {
                Console.WriteLine("删除失败，未查询到订单。");
                return false;
            }
        }

        //对订单排序
        public static void Sort()
        {
            OrderList.Sort();
        }

        //遍历订单
        public static void Traversing()
        {
            foreach(Order o in OrderList)
            {
                Console.WriteLine(o.ToString());
            }
        }
        
        //序列化订单为XML文件
        public static void Export(string path)
        {
            //Console.WriteLine("original order object:");
            //OrderList.ForEach(o => Console.WriteLine(o));

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream(path, FileMode.Create))
            {
                //List<Order> orders = null;
                //OrderList.ForEach(order => orders.Add(order));

                xmlSerializer.Serialize(fs, OrderList);
                
               // Console.WriteLine("xml:"+fs);
            }
            
        }
        //从XML中载入订单
        public static void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> orders = (List<Order>)xmlSerializer.Deserialize(fs);
                orders.ForEach(order => OrderList.Add(order));
            }
           
        }
    }
}
