using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer komp = new Computer("Vx50", "HP", "Win10");
            Desktop stolno = new Desktop("A12", "Acer", "Win7", 50.5);
            Laptop prijenosno = new Laptop("Vostro15", "Dell", "Linux", 6000, 6.2);

            Console.WriteLine(komp.ToString());
            Console.WriteLine(stolno.ToString());
            Console.WriteLine(prijenosno.ToString());
        }
    }
}
