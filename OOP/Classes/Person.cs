using System;

namespace OOP.Classes
{
    internal class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Greet()
        {

            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");

            Console.WriteLine();

        }


    }
}
