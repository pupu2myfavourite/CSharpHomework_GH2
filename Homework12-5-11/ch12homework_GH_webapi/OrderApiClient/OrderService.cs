using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using OrderApi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OrderSystem
{
    public class OrderService
    {
        public List<Order> orderList;
        XmlSerializer orderXmlSeri;
        string xmlFileName;
        string baseUrl = "https://localhost:5001/api/order/";


        public OrderService()
        {
            orderList = new List<Order>();
            orderXmlSeri = new XmlSerializer(typeof(List<Order>));
        }

        public Order SearchOrder(string field, string value)
        {
            Order order = null;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string url = baseUrl + "/"+ field + "/" + value;
            Task<HttpResponseMessage> res2 = client.GetAsync(url);
            res2.Wait();
            order = JsonConvert.DeserializeObject<Order>(res2.Result.Content.ToString());
            return order;

        }

        public void DeleteOrder(string field, string value)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.DeleteAsync(baseUrl +"/"+ field + "/" + value);
            task.Wait();
        }

        // 初始化订单
        public Order InitOrder(string orderInitPara)
        {

            Order newOrder = new Order();
            newOrder.Client = orderInitPara;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(newOrder), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            return new Order();


        }

        public void CompleOrder(Order order, IEnumerable<OrderItem> orderItems)
        {
            foreach (OrderItem item in orderItems)
            {
                order.AddItem(item);
            }
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();

        }

        internal void ModiOrder(Order target, string name, string op, string num_S)
        {
            if (int.TryParse(num_S, out int num) == false)
            {
                throw new Exception("Augument illegal");
            }
            OrderItem item = new OrderItem(name, 1, num);
            switch (op.ToLower())
            {
                case ("add"):
                    target.AddItem(item);
                    break;
                case ("reduce"):
                    target.AddItem(item);
                    break;
            }
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(target), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();
        }


        public void Export(string fileName)

        {
            xmlFileName = "D:\\" + fileName + ".xml";
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Create))
            {
                orderXmlSeri.Serialize(fs, orderList);
            }

        }

        public List<Order> Import()
        {
            if (xmlFileName.Length == 0) { throw new Exception("xml file has not yet generated"); }
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Open))
            {
                List<Order> orderList = (List<Order>)orderXmlSeri.Deserialize(fs);
            }
            return orderList;

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Order order in orderList)
            {
                sb.Append(order.ToString());

            }
            return sb.ToString();
        }


    }
}


