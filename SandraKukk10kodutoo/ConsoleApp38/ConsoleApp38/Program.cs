using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            //dog exercise
            ISpeak dog1 = Factory.getDog("small");
            dog1.Speak();

            ISpeak dog2 = Factory.getDog("big");
            dog2.Speak();

            ISpeak dog3 = Factory.getDog("working");
            dog3.Speak();

            //library exercise
            Book book1 = new Book();
            book1.Title = "Blindness";
            book1.Author = "Mari Maasikas";
            book1.ReleaseYear = 2000;
            book1.Genre = BookGenre.ScienceFiction;
            
            Book book2 = new Book();
            book2.Title = "Magic mountain";
            book2.Author = "Juku Kalle";
            book2.ReleaseYear = 2002;
            book2.Genre = BookGenre.ScienceFiction;

            Book book3 = new Book();
            book3.Title = "Magic";
            book3.Author = "Kusti Kuusk";
            book3.ReleaseYear = 2010;
            book3.Genre = BookGenre.Drama;

            Book book4 = new Book();
            book4.Title = "Magic";
            book4.Author = "Kusti Kuusk";
            book4.ReleaseYear = 2010;
            book4.Genre = BookGenre.Drama;

            Book book5 = new Book();
            book5.Title = "Cakes - Recipes";
            book5.Author = "Jane Smith";
            book5.ReleaseYear = 2010;
            book5.Genre = BookGenre.Cookbook;

            Book book6 = new Book();
            book6.Title = "Owls";
            book6.Author = "Oru Ott";
            book6.ReleaseYear = 1995;
            book6.Genre = BookGenre.Horror;

            Book book7 = new Book();
            book7.Title = "Love";
            book7.Author = "Oru Ott";
            book7.ReleaseYear = 1985;
            book7.Genre = BookGenre.Romance;

            Book book8 = new Book();
            book8.Title = "10 dinner ideas - Recipes";
            book8.Author = "Gordon Ramsay";
            book8.ReleaseYear = 2012;
            book8.Genre = BookGenre.Cookbook;

            Book book9 = new Book();
            book9.Title = "Space Wars";
            book9.Author = "Tim Wott";
            book9.ReleaseYear = 1830;
            book9.Genre = BookGenre.ScienceFiction;

            Book book10 = new Book();
            book10.Title = "Last Spring";
            book10.Author = "Anna Spruce";
            book10.ReleaseYear = 1989;
            book10.Genre = BookGenre.Romance;

            book3.CompareBooks(book4);
            Library library = new Library("School library");
            library.LibraryAddress="Tammsaare 2";

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);
            library.AddBook(book8);
            library.AddBook(book9);
            library.AddBook(book10);

            List<Book> allBooksThatContainDarkness = library.FindAllBooksByName("Magic");

            library.PrintAllBooksByName("Magic");

           

            bool canBorrow = library.BorrowBook("Darkness 2");
            bool canBorrowAgain = library.BorrowBook("Sci-fi");

            //Info printimine
            library.PrintAllBookTitlesInLibrary();
            library.PrintLibraryInfo();
            book1.PrintBookInfo();
            library.PrintAllBooksByAuthor("Mari Maasikas");
            library.PrintAllBooksByAuthor("Oru Ott");

            Console.ReadLine();
        }
    }
}
