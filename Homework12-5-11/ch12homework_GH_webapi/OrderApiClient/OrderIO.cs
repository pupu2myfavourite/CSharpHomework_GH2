using System;
using System.Collections.Generic;
using System.Text;
using OrderApi.Models;


namespace OrderSystem
{
    class OrderIO
    {

        //获取用户字符输入
        public string GetString()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim();
                if (input.Length != 0)
                {
                    return input;
                }
            }

        }

        public string GetString(string question)
        {
            Printf(question);
            return GetString();
        }

        //获取用户数字输入
        public double GetNumber()
        {
            double num = 0;

                string input = Console.ReadLine();
                if (double.TryParse(input, out num))
                {
                    return num;
                }
                else
                {
                throw new Exception("what you input just now is even not a number");
                }
        }

        //获取用户数字输入
        public double GetDoubleNumber(string question)
        {
            Printf(question);
            double num = 0;

            string input = Console.ReadLine();
            if (double.TryParse(input, out num))
            {
                return num;
            }
            else
            {
                throw new Exception("what you input just now is even not a number");
            }
        }

        //获取用户数字输入
        public int GetIntNumber(string question)
        {
            Printf(question);
            int num = 0;

            string input = Console.ReadLine();
            if (int.TryParse(input, out num))
            {
                return num;
            }
            else
            {
                throw new Exception("what you input just now is even not a number");
            }
        }


        //输出
        public void Printf(object obj)
        {
            String str = obj as string;
            if (str!= null) { Console.WriteLine(">> "+str); }
            else Console.WriteLine(">> " + obj);
        }

        internal string[] GetModiPara()
        {

            string[] operation = new String[3];
            
            operation[0] = GetString("input the name of the item you wanna modify, you are only allowed to operate the existed items");
            operation[1] = GetString("input the operation name (add / reduce)");
            operation[2] = GetDoubleNumber("input the amount you wanna alter").ToString();

            return operation;
        }


        // 编辑订单
        /*
        public void EditOrder(Order order)
        {
            while (true)
            {
                String info = Console.ReadLine();

                if (info[0] == 'c')
                {
                    //增添orderItem
                    try
                    {
                        // 还未判断重复

                        order.AddItem(info.Substring(2));
                        Console.WriteLine("add sucessfully!\n");
                        Console.WriteLine(order);


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (info[0] == 'q')
                {
                    break;
                }


            }
        }
        */


        internal string[] GetDeletePara()
        {
            return GetSearchPara();
        }

        /*
        public string GetCreaPara()
        {
            string orderInitPara = Console.ReadLine();
            if(orderInitPara.Length == 0)
            {
                Get
            }
            throw new NotImplementedException();
        }
        */

        internal void PrintSearchRes(Order results)
        {
            throw new NotImplementedException();
        }

        internal string[] GetSearchPara()
        {
            string field = GetString("input the field please(id / client)");
            if(field.ToLower() == "id" || field.ToLower() == "client")
            {
                string value = GetString("input the value of that field");
                String[] result = new string[2];
                result[0] = field;
                result[1] = value;
                return result;
            }
            else
            {
                throw new Exception("no such field name");
            }
        }

        internal IEnumerable<String> GetItemsPara()
        {
            StringBuilder sb = new StringBuilder();
            Printf("input the item's name");
            sb.Append(GetString() + " ");
            Printf("input the price of the item");
            sb.Append(GetNumber() + " ");
            Printf("input the number of the item");
            sb.Append(GetNumber());
            yield return sb.ToString();


        }

        internal bool checkContinue()
        {
            Printf("input yes to continue, no to exit");
            string input = GetString();
            if (input.ToLower() == "yes")
            {
                return true;
            }
            else if (input.ToLower() == "no")
            {
                return false;
            }
            else
            {
                throw new Exception("illegal input!");
            }
        }

        internal bool checkContinue(string question)
        {
            Printf(question);
            string input = GetString();
            if (input.ToLower() == "yes")
            {
                return true;
            }
            else if (input.ToLower() == "no")
            {
                return false;
            }
            else
            {
                throw new Exception("illegal input!");
            }
        }
    }

}
