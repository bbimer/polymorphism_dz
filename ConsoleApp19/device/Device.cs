using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.device
{
    public class Device
    {
        public string Name { get; }

        protected Device(string name) 
        {
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException("The device name cannot be empty.");
        }

        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
    }

    public class Kettle : Device
    {
        public Kettle(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine($"Shhhh-Pshhh-Glug-glug!");
        }
        public override void Show() 
        { 
            Console.WriteLine($"Device name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"electric appliance for boiling water");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine($"Vzzz-Peep-peep-peep!");
        }
        public override void Show()
        {
            Console.WriteLine($"Device name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Food heating device");
        }
    }

    public class Car : Device
    {
        public Car(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine($"Vroom-vroom-beep-beep!");
        }
        public override void Show()
        {
            Console.WriteLine($"Device name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"vehicle for transportation");
        }
    }

    public class Ship : Device
    {
        public Ship(string name) : base(name) { }
        public override void Sound()
        {
            Console.WriteLine($"Too-o-o-o!");
        }
        public override void Show()
        {
            Console.WriteLine($"Device name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"vehicle for moving on water");
        }
    }
}
