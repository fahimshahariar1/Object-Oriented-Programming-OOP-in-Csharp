namespace OOP.Classes
{
    internal class Book
    {

        // Properties of the Book class
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        // Constructor to initialize a new instance of the Book class
        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {PublicationYear}");
        }

    }
}
