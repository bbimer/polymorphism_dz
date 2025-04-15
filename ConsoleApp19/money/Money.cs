using System;

namespace ConsoleApp19.money
{
    public class Money
    {
        private int _whole;
        private int _tenths;

        public int WholePart
        {
            get => _whole;
            set => _whole = value >= 0 ? value : throw new ArgumentException("Целая часть не может быть отрицательной");
        }

        public int TenthsPart
        {
            get => _tenths;
            set
            {
                if (value < 0 || value >= 100)
                    throw new ArgumentException("Дробная часть должна быть от 0 до 99");
                _tenths = value;
            }
        }

        public Money() : this(0, 0) { }

        public Money(int whole, int tenths)
        {
            WholePart = whole;
            TenthsPart = tenths;
        }

        public void SetAmount(int whole, int tenths)
        {
            WholePart = whole;
            TenthsPart = tenths;
        }

        public void Reduction(Money amount)
        {
            int currentTotal = WholePart * 100 + TenthsPart;
            int amountTotal = amount.WholePart * 100 + amount.TenthsPart;

            if (amountTotal > currentTotal)
                throw new InvalidOperationException($"Нельзя вычесть {amount} из {this} - недостаточно средств");

            int result = currentTotal - amountTotal;
            WholePart = result / 100;
            TenthsPart = result % 100;
        }

        public virtual void Show(string symbol)
        {
            Console.WriteLine($"{WholePart}.{TenthsPart:D2} {symbol}");
        }

        public override string ToString()
        {
            return $"{WholePart}.{TenthsPart:D2}";
        }
    }
}