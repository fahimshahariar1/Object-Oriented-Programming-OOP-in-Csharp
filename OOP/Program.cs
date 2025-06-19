using OOP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    internal class Program : Animal
    {
        static void Main(string[] args)
        {

            //Person intro = new Person(name: "Fahim");

            ////intro.Greet();


            //Student student = new Student();

            ////student.setAge(20);

            ////student.getAge();

            //Shape shape = new Shape();

            ////shape.DrawCircle();



            //async Task<string> SayHello()
            //{
            //    await Task.Delay(2000); // Simulate some asynchronous work
            //    return "Hello, Fahim!";
            //}

            ////chianing async method

            //async Task<int> LoadDataAsync()
            //{
            //    await Task.Delay(1000); // Simulate data loading
            //    Console.WriteLine("Data loaded");
            //    return 42; // Example data
            //}

            //async Task<int> ProcessDataAsync(int data)
            //{
            //    await Task.Delay(1000); // Simulate data processing
            //    Console.WriteLine("Data processed");
            //    return data * 2;
            //}

            //async Task SaveDataAsync(int data)
            //{
            //    await Task.Delay(1000); // Simulate saving data
            //    Console.WriteLine($"Data saved: {data}");
            //}

            //async Task ProcessAsync()
            //{
            //    var data = await LoadDataAsync();
            //    var processed = await ProcessDataAsync(data);
            //    await SaveDataAsync(processed);
            //}

            //string message = SayHello().GetAwaiter().GetResult();

            //Console.WriteLine(message);

            //ProcessAsync().GetAwaiter().GetResult();



            List<int> scores = new List<int> { 90, 85, 78, 92, 88, 76 };
            var even = scores.Where(score => score == 0);

            foreach (var num in even)
            {
                Console.WriteLine(num);
            }

            List<string> names = new List<string> { "Alice", "BOB", "Charlie", "DAVID" };

            var friends = names.Select(name => name.ToUpper());
            Console.WriteLine(friends);


            Console.ReadLine();

        }


    }
}
