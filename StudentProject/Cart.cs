using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class Cart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Cart(Product produk, int quantity)
        {
            Product = produk;
            Quantity = quantity;
        }
    }
}
