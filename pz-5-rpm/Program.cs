using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5_rpm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CircleArc
            Console.WriteLine("Введите радиус окружности:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол в радианах:");
            double angle = double.Parse(Console.ReadLine());

            CircleArc arc = new CircleArc(radius, angle);
            Console.WriteLine(arc); // Выводит информацию о радиусе и угле
            Console.WriteLine($"Длина дуги = {arc.LengthOfArc()}"); // Вычисляет длину дуги

            // Product
            Console.WriteLine("\nВведите название товара:");
            string productName = Console.ReadLine();
            Console.WriteLine("Введите цену товара:");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите год выпуска товара:");
            int productYear = int.Parse(Console.ReadLine());

            Product product = new Product()
            {
                name = productName,
                price = productPrice,
                year = productYear
            };

            Console.WriteLine($"Товар был выпущен {product.WhenReleased()} лет назад.");

            // Увеличение цены, если в названии есть "TV"
            product.PriceIncrease();
            Console.WriteLine($"Новая цена товара: {product.price}");

            Console.ReadKey();
        }
    }
}
