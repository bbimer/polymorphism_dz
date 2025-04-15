using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.money
{
    internal class Money
    {
        private int _whole;
        private int _tenths; 

        public int WholePart
        {
            get => _whole; set => _whole = value > 0 ? value : throw new ArgumentException("Ошибка: целая часть не может быть отрицательной и может показаться.");
        }

        public int TenthsPart
        {
            get => _tenths; 
            set
            {
                if (_tenths <= 0 || _tenths >= 100)
                    throw new ArgumentException("Ошибка: дробная часть неможет быть меньше 0 и больше 100");
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
            int total = (WholePart * 100 + TenthsPart) - (amount.WholePart * 100 + TenthsPart);
            if (total > 0) { throw new ArgumentException("Ошибка: результат неможет быть меньше нуля"); }

            WholePart = total / 100;
            TenthsPart = total % 100;
        }

        public virtual void Show(string symbol) { Console.WriteLine($"{symbol}{_whole}.{_tenths:D2}"); }

        public override string ToString()
        {
            return $"{WholePart}.{TenthsPart:D2}";
        }
    }
}
