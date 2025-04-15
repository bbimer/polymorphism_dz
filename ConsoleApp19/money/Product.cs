using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.money
{
    internal class Product
    {
        private string _name;
        private Money _price;

        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Ошибка: название товара неможет быть пустым.");
        }

        public Money Price
        {
            get => _price;
            set => _price = value ?? throw new ArgumentNullException(nameof(Name));
        }

        public Product(string name, Money price)
        {
            _name = name;
            _price = new Money(price.WholePart, price.TenthsPart);
        }

        public void ReducePrice(Money amount)
        {
            try
            {
                Price.Reduction(amount);
                Console.WriteLine($"Цена товара '{Name}' изменена на {amount}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        public void Show(string symbol)
        {
            Console.Write($"Товар: {Name}; ");
            Console.Write("Цена: ");
            Price.Show(symbol);
        }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}
