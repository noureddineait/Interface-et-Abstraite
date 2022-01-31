using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Marchandise banane = new Marchandise(3, 1);
            Marchandise pomme = new Marchandise(2, 2);

            TransportRoutier transportRoutier = new TransportRoutier();
            TransportAerienNormal transportAerienNormal = new TransportAerienNormal();
            TransportAerienUrgent transportAerienUrgent = new TransportAerienUrgent();
            Console.WriteLine($"Pomme en route : {transportRoutier.Prix(pomme)} $");
            Console.WriteLine($"Pomme en air {transportAerienNormal.Prix(pomme)} $");
            Console.WriteLine($"Pomme en air urgent {transportAerienUrgent.Prix(pomme)} $");

            Console.WriteLine($"Banane en route : {transportRoutier.Prix(banane)} $");
            Console.WriteLine($"Banane en air {transportAerienNormal.Prix(banane)} $");
            Console.WriteLine($"Banane en air urgent {transportAerienUrgent.Prix(banane)} $");

            Console.ReadKey();
        }
    }
}
