using System;

namespace OOP.Classes
{
    internal class Student
    {

        private int age { get; set; }

        public void setAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                this.age = age;
                Console.WriteLine($"He is {age} years old");
            }

        }

        public int getAge()
        {
            return age;
        }
    }
}
