using OOP.Classes;
using System;

namespace OOP
{
    internal class Program : Animal
    {
        static void Main(string[] args)
        {

            Person intro = new Person(name: "Fahim");

            intro.Greet();


            Student student = new Student();

            student.setAge(20);

            student.getAge();

            Shape shape = new Shape();

            shape.DrawCircle();





            Console.ReadLine();

        }


    }
}
