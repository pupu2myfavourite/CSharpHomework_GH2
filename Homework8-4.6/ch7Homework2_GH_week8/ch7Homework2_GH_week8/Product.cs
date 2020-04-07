using System;
namespace OrderManagement
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public Product()
        {

        }
        public Product(int ID, string name, int price)
        {
            ProductID = ID;
            ProductName = name;
            UnitPrice = price;
        }
        public override string ToString()
        {
            return "-ProductID:" + ProductID + " -ProductName:" + ProductName + " -UnitPrice:" + UnitPrice;
        }
    }
}
