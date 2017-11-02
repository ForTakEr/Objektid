using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Cat()
        {
            Name = "Kiisu";
            Age = 5;
            Color = "Punane";
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

    }
}
