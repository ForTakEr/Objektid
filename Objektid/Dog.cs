using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Dog : Mammal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public int realYears { get; set; }
        
        public Dog()
        {
            Name = "Rex";
            Age = 5;
            Color = "Brown";
            Bark();
        }

        public void Bark()
        {
            Console.WriteLine("Auh auh!!!");
        }

        public int CalculateDogYears()
        {
            realYears = Age * 7;
            return realYears;
        }
    }
}
