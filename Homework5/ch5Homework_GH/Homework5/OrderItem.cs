using System;
namespace OrderManagement
{
    public class OrderItem
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public double UnitPrice { get; set; }
        public int ProductNum { get; set; }
        public double TotalMoney { get; }

        public Product product;
        
        public OrderItem()
        {
        }
        public OrderItem(int orderID, int productNum, Product newProduct )
        {
            OrderID = orderID;
            ProductNum = productNum;

            ProductID = newProduct.ProductID;
            UnitPrice = newProduct.UnitPrice;

            TotalMoney = UnitPrice * productNum;
        }

        public override string ToString()
        {
            //return " -ProductName:"+product.ProductName+" -ProductID:"
            //    +ProductID+" -UnitPrice:" + UnitPrice + " -ProductNum:"
            //    + ProductNum + " -TotalMoney:" + TotalMoney;
            return "ProductID:"+product.ProductID;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            if(this.OrderID == orderItem.OrderID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
