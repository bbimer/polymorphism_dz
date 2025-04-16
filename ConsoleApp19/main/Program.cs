using ConsoleApp19.device;
using ConsoleApp19.money;

namespace ConsoleApp19.main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-----------( 1 )-----------*/
            /*
            var price = new Money(100, 50);
            var ds = new Money(90, 50);
            price.Show("USD");

            Console.WriteLine();
            var product = new Product("Книга", price);
            product.Show("USD");

            product.ReducePrice(ds);
            product.Show("USD");
            */

            /*-----------( 2 )-----------*/
            Device[] devices =
            {
                new Kettle("Bosch"),
                new Microwave("Samsung "),
                new Car("porshe"),
                new Ship("titanic")
            };

            foreach (var device in devices) { device.Show(); device.Sound(); device.Desc(); Console.WriteLine(); }
        
        }
    }
}
