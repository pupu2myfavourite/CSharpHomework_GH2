using System.Collections.Generic;

namespace ch12Homework_GH.models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Date { get; set; }
        public string Customer { get; set; }

        public List<Item> Items { get; set; }
    }
}