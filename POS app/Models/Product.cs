using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_app.Models
{
    class Product
    {

        public Product()
        {
            ProductId = 0;
            ProductName = "Unknown";
            Price = 0.00M;
            Quantity = 0;
        }
        public Product(int id, string name, decimal price, int quantity)
        {
            ProductId = id;
            ProductName = name;
            Price = price;
            Quantity = quantity;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return ProductName +"\n"+ ProductId +"\n"+ Price+ "\n";
        }
    }
}
