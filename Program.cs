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
            //Animal animal = new Animal();
            Animal animal = new Cat();
            Cat cat = new Cat();


            Cat cat2 = animal as Cat; // is able to use projection useing - as
            cat2.PijMleko();

            if (!(cat2 == null))
            {

                Console.WriteLine("Rzutowanie się powiodło");
            }
            else
            {
                Console.WriteLine("Rzutowanie zakończone porażką");
            }


            //animal = cat;

            ////Console.WriteLine(cat is Cat);
            //if (animal is Cat)
            //{
            //    Cat cat2 = (Cat)animal;
            //    Console.WriteLine("Rzutowanie się powiodło");
            //}
            //else
            //{
            //    Console.WriteLine("Rzutowanie zakończone porażką");
            //}

            //animal = new Cat();

            //cat = (Cat)animal;
            //cat.PijMleko();



            Console.ReadKey();

        }
    }
}
