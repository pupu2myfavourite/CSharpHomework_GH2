using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OrderApi.Models{


    public class Order{        
        static int count;
        public List<OrderItem> Items { get; set; }
        public int Id { get; set; }
        public String Client { get; set; }
        //public double TotalSum { get; set; }
        public Order(){
            Items = new List<OrderItem>();
            Id = (++count);
        }


/*
        public double TotalSum {
            get => (Items.ConvertAll(x => x.TotalSum).Sum());
            set => TotalSum = value;
        } 
*/



        public void AddItem(OrderItem item)
        {
            IEnumerable<OrderItem> items = Items.AsEnumerable().Where(x => x.Equals(item));
            if (items.Count() == 0)
            {
                Items.Add(item);
            }
            else
            {
                items.ToList()[0].Number += item.Number;
            }

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /*
                public void AddItem(String info)
                {
                        OrderItem item = new OrderItem(info);
                        Items.Add(item);
                }
                */
        /*
        public bool Equals(Object obj)
        {
            Order order = obj as Order;
            foreach (OrderItem item in order.Items) {
                if (!this.Items.Contains(item))
                {
                    return false;
                }
            }
            return order != null && order.Client == Client && order.ID == ID && order.Items.Count == Items.Count;
        }
        */

/*
        public override string ToString()
        {

            StringBuilder str = new StringBuilder();

            str.Append("\n-----------------------\n");
            str.Append("ID:" + Id + "\n");
            str.Append("Client:" + Client + "\n");
            str.Append("-----------------------\n");
            str.Append("Item\t|Price\t|Number\n");
            str.Append("-----------------------\n");
            foreach (OrderItem item in Items)
            {
                str.Append(item);
                str.Append("-----------------------\n");
            }
            return str.ToString();
        }
*/
        public override int GetHashCode()
        {
            return HashCode.Combine(Items, Id, Client);
        }

        internal void AddItem(string name, int num)

        {
            IEnumerable<OrderItem> item = Items.AsEnumerable().Where(x => x.goods.Name == name);
            if (item.ToList().Count() == 0)
            {
                throw new Exception("no such item found!");

            }
            OrderItem target = item.ToList()[0];

            target.Number += num;
            if (target.Number == 0)
            {
                Items.Remove(target);
            }
            else if (target.Number < 0)
            {
                target.Number += num;
                throw new Exception("the number of remnant could not be negtive");
            }

        }




    }

    public class OrderItem{        
        public int OrderItemId { get; set; }
        public Goods goods { get; set; }
        public int Number { get; set; }
        public string goodName => goods.Name;
        public double goodPrice => goods.Price;
        /*
        public double TotalSum
        {
            get=> goodPrice * Number;
            set => TotalSum=value;

        }
        */

         public OrderItem(String name, double price, int number)
        {
            goods = new Goods(name, price);
            Number = number;
        }

        public OrderItem()
        {
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(goods, Number);
        }

        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item!=null && item.goods.Equals(goods);
        }

/*
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(goods.Name + "\t|");
            str.Append(goods.Price +"\t|");
            str.Append(Number + "\n");
            return str.ToString();
        }
*/
        //public Order Order { get; set; }
    }

    public class Goods{
        public int Id{get; set;}
        public string Name { get; set; }
        public double Price { get; set; }

         public Goods() { }

        public Goods(String name, double price ){
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            Goods g = obj as Goods;
            return g != null && g.Name == Name && g.Price == Price;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}