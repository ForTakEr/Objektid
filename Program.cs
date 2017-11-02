using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Age = 7;
            dog1.Color = "Brown";
            dog1.Name = ("Muki");

            Console.WriteLine("Koera värv: " + dog1.Color);
            Console.WriteLine("Koera vanus: " + dog1.Age);
            Console.WriteLine("Koera nimi: " + dog1.Name);
            Console.WriteLine("--------------------------------");

            Dog dog2 = new Dog();
            Console.WriteLine("Sisesta koera nimi: ");
            dog2.Name = Console.ReadLine();
            Console.WriteLine("Sisesta koera värv: ");
            dog2.Color = Console.ReadLine();
            Console.WriteLine("Sisesta koera vanus: ");
            dog2.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Koera nimi: " + dog2.Name);
            Console.WriteLine("Koera värv: " + dog2.Color);
            Console.WriteLine("Koera vanus: " + dog2.Age);
            Console.WriteLine("--------------------------------");

            Dog dog3 = new Dog();
            Console.WriteLine("Koera nimi: " + dog3.Name);
            Console.WriteLine("Koera vanus: " + dog3.Age);
            Console.WriteLine("Koera värv: " + dog3.Color);
            dog3.Bark();
            Console.WriteLine("Koera tegelik vanus: " + dog3.CalculateDogYears());
            Console.WriteLine(dog3.IsCarnivore);
            Console.WriteLine("Silmade arv: " + dog3.NumberOfEyes);
            Console.WriteLine("--------------------------------");

            Cat cat1 = new Cat();
            Console.WriteLine("Kassi nimi: " + cat1.Name);
            Console.WriteLine("Kassi vanus: " + cat1.Age);
            Console.WriteLine("Kassi värv: " + cat1.Color);
            cat1.Meow();
            Console.WriteLine("--------------------------------");

            Cat cat2 = new Cat();
            Console.WriteLine("Sisesta kassi nimi: ");
            cat2.Name = Console.ReadLine();
            Console.WriteLine("Sisesta kassi vanus: ");
            cat2.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta kassi värv: ");
            cat2.Color = Console.ReadLine();

            Console.WriteLine("Kassi nimi: " + cat2.Name);
            Console.WriteLine("Kassi vanus: " + cat2.Age);
            Console.WriteLine("Kassi värv: " + cat2.Color);
            Console.WriteLine("--------------------------------");

            Mammal mammal = new Mammal();


            Console.ReadLine();
        }
    }
}
