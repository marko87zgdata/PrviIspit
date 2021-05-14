using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Laptop : Computer
    {
        public int BatteryCapacity { get; set; }
        public double Weight { get; set; }
        public Laptop(string model, string manufacturer, string operatingSystem, int batteryCapacity, double weight)
            : base(model, manufacturer, operatingSystem)
        {
            BatteryCapacity = batteryCapacity;
            Weight = weight;
        }

        public override string GetComputerType()
        {
            return "laptop computer";
        }

        public override double CalculatePortabilityScore()
        {
            return (int)Weight;
        }
    }
}
