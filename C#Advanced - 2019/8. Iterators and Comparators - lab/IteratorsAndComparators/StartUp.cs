using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 1000, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book bookFour = new Book("Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree, bookFour);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }
    }
}
