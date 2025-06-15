using System;

namespace OOP.Classes
{
    internal class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name)
        {
            Name = name;
        }

        public void Greet()
        {

            Console.WriteLine($"Hello, my name is {Name}");
        }




    }
}
