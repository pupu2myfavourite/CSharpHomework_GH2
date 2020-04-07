using System;
namespace OrderManagement
{
    [Serializable]
    public class OrderItem
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int ProductNum { get; set; }
        public double OrderItemTotalMoney { get; }

        public Product product;
        
        public OrderItem()
        {
        }
        public OrderItem(int orderID, int productNum, Product newProduct )
        {
            OrderID = orderID;
            ProductID = newProduct.ProductID;

            ProductName = newProduct.ProductName;
            UnitPrice = newProduct.UnitPrice;
            ProductNum = productNum;
            OrderItemTotalMoney = UnitPrice * productNum;

            product = newProduct;
        }

        public override string ToString()
        {
            return "-ProductID:"+product.ProductID+" -ProductNmae:"+ProductName+" -UnitPrice: "
                +UnitPrice+" -ProductNum:"+ProductNum+" -OrderItemTotalMoney:"+OrderItemTotalMoney;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            if(this.ProductID == orderItem.ProductID)
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
