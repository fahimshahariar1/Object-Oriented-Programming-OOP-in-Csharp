using OOP.Classes;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person intro = new Person(name: "Fahim", age: 25);

            intro.Greet();

            Console.ReadLine();

        }


    }
}
