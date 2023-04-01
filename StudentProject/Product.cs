using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class Product
    {
        public string Sku {  get; set; }
        public string Nama { get; set; }
        public int Stock { get; set; }
        public double Harga { get; set; }

        public Product(string sku, string nama, int stock, double harga)
        {
            Sku = sku;
            Nama = nama;
            Stock = stock;
            Harga = harga;
        }
  
    }
}
