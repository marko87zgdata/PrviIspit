using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Desktop: Computer
    {
        public double CaseHeight { get; set; }

        public Desktop(string model, string manufacturer, string operatingSystem, double caseHeight)
            : base(model, manufacturer, operatingSystem)
        {
            CaseHeight = caseHeight;
        }

        public override string ToString()
        {
            return "Model: " + Model + ", " + "Manufacturer: " + Manufacturer + ", " + "OperatingSystem: " 
                + OperatingSystem + ", " + CaseHeight + "cm";
        }
    }
}
