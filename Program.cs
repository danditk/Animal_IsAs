using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Cat cat = new Cat();

            //Console.WriteLine(cat is Cat);
            if (animal is Cat)
            {
                Console.WriteLine("Rzutowanie się powiodło");
            }
            else
            {
                Cat cat2 = (Cat)animal;
                Console.WriteLine("Rzutowanie zakończone porażką");
            }

            //animal = new Cat();

            //cat = (Cat)animal;
            //cat.PijMleko();



            Console.ReadKey();

        }
    }
}
