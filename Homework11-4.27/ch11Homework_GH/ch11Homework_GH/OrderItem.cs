using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ch11Homework_GH
{
    [Serializable]
    public class OrderItem
    {
        [Key]
        public int OrderitemID { get; set; }
        [NotMapped]
        public int ProductID { get; set; }
        [NotMapped]
        public string ProductName { get; set; }
        [NotMapped]
        public double UnitPrice { get; set; }
        [NotMapped]
        public int ProductNum { get; set; }
        [NotMapped]
        public double OrderItemTotalMoney { get; }
        [Required]
        public Product product;
        
        public OrderItem()
        {
        }
        public OrderItem(int orderID, int productNum, Product newProduct )
        {
            OrderitemID = orderID;
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
