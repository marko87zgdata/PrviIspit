using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Desktop: Computer
    {
        public double CaseHeight { get; set; }

        public Desktop(string model, string manufacturer, string operatingSystem, double caseHeight)
            : base(model, manufacturer, operatingSystem)
        {
            CaseHeight = caseHeight;
        }

        public override string GetComputerType()
        {
            return "desktop computer";
        }

        public override double CalculatePortabilityScore()
        {
            
            return 5 + CaseHeight/30;
        }
    }
}
