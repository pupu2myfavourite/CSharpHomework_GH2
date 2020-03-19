using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "电脑", 100);
            Product product2 = new Product(2, "手机", 50);
            Client client1 = new Client(1, "张三");
            Client client2 = new Client(2, "李四");

            Order order1 = new Order(1, client1, new OrderItem(1, 20, product1));
            Order order2 = new Order(2, client1, new OrderItem(2, 50, product2));
            Order order3 = new Order(3, client2, new OrderItem(3, 20, product2));
            Order order4 = new Order(4, client1, new OrderItem(4, 15, product1));

            //测试创建功能
            OrderService.CreateOrder(order1);
            OrderService.CreateOrder(order3);
            OrderService.CreateOrder(order2);
            OrderService.CreateOrder(order2);
            OrderService.CreateOrder(order4);

            //测试查询功能
            IEnumerable<Order> orders;
            if (OrderService.QueryOrder(1, out orders))     //查询orderID为1的账单（存在的订单
            {
                Console.WriteLine("查询成功：");
                foreach (Object o in orders)
                {
                    Console.WriteLine(o.ToString());                
                }
            }
            else
            {
                Console.WriteLine("查无此账单");
            }            
            if (OrderService.QueryOrder(7, out orders))     //查询orderID为7的账单（不存在的订单
            {
                Console.WriteLine("查询成功：");
                foreach (Object o in orders)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            else
            {
                Console.WriteLine("查无此账单");
            }
            Console.WriteLine();

            //测试订单修改功能
            if (OrderService.UpdateOrder(1, 2))     // 测试修改存在的订单
            {
                Console.WriteLine("订单修改成功");
            }
            else 
            {
                Console.WriteLine("订单修改失败");
            }

            if (OrderService.UpdateOrder(7, 2))     //测试修改不存在的订单
            {
                Console.WriteLine("订单修改成功");
            }
            else
            {
                Console.WriteLine("订单修改失败");
            }
            Console.WriteLine();

            //测试订单删除功能
            OrderService.Traversing();
            if (OrderService.DeleteOrder(1))    //测试存在的账单删除
            {
                Console.WriteLine("订单删除成功");
            }
            else
            {
                Console.WriteLine("订单删除失败");
            }
            OrderService.Traversing();
            if (OrderService.DeleteOrder(7))    //测试不存在的账单删除  
            {
                Console.WriteLine("订单删除成功");
            }
            else
            {
                Console.WriteLine("订单删除失败");
            }
            OrderService.Traversing();
            Console.WriteLine();


            //测试订单排序功能
            Console.WriteLine("订单排序（按订单号):");
            OrderService.Sort();
            OrderService.Traversing();                                 
        }
    }
}
