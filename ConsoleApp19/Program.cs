using ConsoleApp19.money;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var price = new Money(100, 50);
            var ds = new Money(90, 50);
            price.Show("USD");

            Console.WriteLine();
            var product = new Product("Книга", price);
            product.Show("USD");

            product.ReducePrice(ds);
            product.Show("USD");
        }
    }
}
