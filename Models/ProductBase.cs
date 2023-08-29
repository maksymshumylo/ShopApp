
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Shop.Models
{
    public class ProductsBase
    {
        public string Name { get; set; }
        public string PhotoPath { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }

        public ProductsBase(string category, string name, int price, string photoPath)
        {
            Name = name;
            PhotoPath = photoPath;
            Price = price;
            Category = category;
        }
    }


}