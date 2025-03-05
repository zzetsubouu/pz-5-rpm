using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5_rpm
{
    internal class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public int year { get; set; }

        public Product() { }
        public Product(string name, double price, int year)
        {
            this.name = name;
            this.price = price;
            this.year = year;
        }
        ~Product()
        {
            Console.WriteLine($"продукт {name} удален");
        }

        public int WhenReleased()
        {
            return DateTime.Now.Year - year;
        }
        public void PriceIncrease()
        {
            if (name.ToLower().Contains("tv"))
            {
                price = price+price*0.2;
            }
        }
    }
}
