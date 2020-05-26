using System;
using System.Collections.Generic;
using System.Text;
using OrderApi.Models;

namespace OrderSystem
{


    class Terminal
    {
        OrderService service;
        OrderIO io;

        public Terminal()
        {
            service = new OrderService();
            io = new OrderIO();
        }

        public void Run()
        {
                while (true)
                {
                    
                    string op = io.GetString("input add (an order)/ search (order)/ delete (order) " +
                        "/ \nmodify (order) / show (current orderlist) / export (to a xml file)" +
                        "/ \nimport (to show the exported xml file)to start the service.");
                    try
                    {
                        switch (op.ToLower())
                        {
                            case ("add"):
                                CreateOrder();
                                io.Printf("add successfully");
                                break;

                            case ("search"):
                                Order result = SearchOrder();
                                io.Printf(result);
                                break;

                            case ("delete"):
                                DeleteOrder();
                            io.Printf("delete successfully, now the order list is\n" + service);
                                break;

                        case ("modify"):
                            ModifyOrder();
                            io.Printf("modify successfully, now the order list is\n " + service);
                            break;
                        case ("show"):
                            io.Printf(service);
                            break;

                        case ("export"):                            
                            service.Export(io.GetString("please input the xml file name"));
                            break;

                        case ("import"):
                            List<Order> orders = service.Import();
                            foreach (Order order in orders) { io.Printf(order); }
                            break;
                         default:
                                throw new Exception("illegal input");
                        }
                    }
                    catch(Exception e)
                    {
                        io.Printf(e.Message);
                    }
                service.Export("text");


            }

           
        }

        private void ModifyOrder()
        {
            Order target = SearchOrder();
            io.Printf(target);
            do
            {
                string[] paras = io.GetModiPara();
                service.ModiOrder(target, paras[0], paras[1], paras[2]);
            }
            while (io.checkContinue());
        }

        private void DeleteOrder()
        {
            string[] deletePara = io.GetDeletePara();
            service.DeleteOrder(deletePara[0], deletePara[1]);
        }

        private Order SearchOrder()
        {
            string[] searchPara = io.GetSearchPara();
            Order result = service.SearchOrder(searchPara[0], searchPara[1]);
            return result;
        }

        private void CreateOrder()
        {
            String orderInitPara = io.GetString("input the client's name please");

            IEnumerable<String> orderItemPara;

            Order order =  service.InitOrder(orderInitPara);
            if(io.checkContinue("do you want to add some items?(yes / no)"))
            {
                do
                {
                    try
                    {
                        orderItemPara = io.GetItemsPara();
                        List<OrderItem> items = new List<OrderItem>();
                        foreach (string itempara in orderItemPara)
                        {
                            string[] paras = itempara.Split(" ");
                            string name = "";
                            for (int i = 0; i <= paras.Length - 3; i++)
                            {
                                name += paras[i];
                                /*OrderItem item = new OrderItem(name, 
                                    double.Parse(paras[paras.Length - 2]), 
                                    int.Parse(paras[paras.Length - 1]));
                                items.Add(item);
                                */
                            }
                            

                        }
                        service.CompleOrder(order, items);
                    }
                    catch (Exception e)
                    {
                        io.Printf(e.Message);
                    }

                }
                while (io.checkContinue("continue to add items?(yes / no)"));
            }
                

        }
    }
}
