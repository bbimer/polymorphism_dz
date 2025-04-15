using ConsoleApp19.money;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money[] wallets =
            {
                new Money(5, 0),
                new USD(100, 50),
                new EUR(30, 33),
                new UAH(26000, 84)
            };

            foreach (var wallet in wallets) { wallet.Print(); }
        }
    }
}
