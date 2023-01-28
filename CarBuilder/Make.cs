using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    internal class Make : Car
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Registration { get; set; }
        public string Color { get; set; }
        public string BodyType { get; set; }

        public Fuel Fuel { get; set; }
        public GearBox GearBox { get; set; }
        public int Speed { get; set; } = 0;

        public Make(string name, string price, string registration, string color, string bodyType, Fuel fuelType, GearBox gearBox) : base(color, bodyType)
        {
            Name = name;
            Price = price;
            Registration = registration;
            Color = color;
            BodyType = bodyType;
            Fuel = fuelType;
            GearBox = gearBox;
            Fuel = fuelType;
        }

        public override void Move()
        {
            Speed += 20;
            Console.WriteLine($"The car is moving at a speed of {Speed} km/hr.");
        }

        public override void Break()
        {
            Speed -= 10;
            Console.WriteLine($"The car is breaking ... , current speed is {Speed} km/hr");
        }

        public override void Stop()
        {
            Speed = 0;
            Console.WriteLine("Car has stopped !");
        }

        public override string ToString()
        {
            return ($"The car is of brand {Name} build in year {Registration}. The price is {Price} and {Color} in color. " +
                $"\n Specification: \n Fuel: {Fuel} \n GearBox:{GearBox} \n BodyType: {BodyType}");
        }


    }
}
