using System;
using System.ComponentModel.DataAnnotations;

namespace ch11Homework_GH
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
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
