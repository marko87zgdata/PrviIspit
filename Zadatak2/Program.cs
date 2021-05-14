using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop stolno = new Desktop("A12", "Acer", "Win7", 100.5);
            Laptop prijenosno = new Laptop("Vostro15", "Dell", "Linux", 6000, 6.2);

            Console.WriteLine(stolno.GetComputerType());
            Console.WriteLine(prijenosno.GetComputerType());

            Console.WriteLine(stolno.CalculatePortabilityScore() + "kg");
            Console.WriteLine(prijenosno.CalculatePortabilityScore() + "kg");

           
        }
    }
}
