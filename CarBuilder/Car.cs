using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    public abstract class Car
    {
        public string Color { get; set; }
        public string BodyType { get; set; }

        public Car(string color, string bodyType)
        {
            Color = color;
            BodyType = bodyType;
        }

        public abstract void Move();
        public abstract void Break();
        public abstract void Stop();

    }
}
