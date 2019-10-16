using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la temperatura della serra: ");
            double temperatura = double.Parse(Console.ReadLine());
            if(temperatura<=5)
            {
                Console.WriteLine("La serra può avere danni irreparabili!");
            }else if(temperatura>5&&temperatura<18)
            {
                Console.WriteLine("La serra è in situazione di pericolo!");
            }else if(temperatura>=18)
            {
                Console.WriteLine("La serra è in condizione normale");
            }
            Console.ReadLine();
        }
    }
}
