static void Main(string[] args)
{
    Console.WriteLine("Hello, World!");
    // Create an instance of the Book class
    OOP.Classes.Book myBook = new OOP.Classes.Book(title: "1984", author: "George Orwell", publicationYear: 1949);



    // You can now use myBook to access properties and methods defined in the Book class
    // For example, if you had a method called DisplayInfo, you could call it like this:
    myBook.DisplayInfo();
}