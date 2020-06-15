using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Library
    {
        List<Book> _listOfBooks = new List<Book>();
        private string _libraryName;
        private string _libraryAddress;

        public Library(string libraryName)
        {
            _libraryName = libraryName;
        }



        public string LibraryName
        {
            get { return _libraryName; }
            set
            {
                if (value != null)
                {
                    _libraryName = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }
            }

        }

        public string LibraryAddress
        {
            get { return _libraryAddress; }
            set
            {
                if (value != null)
                {
                    _libraryAddress = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }
            }

        }



        public void AddBook(Book bookToAdd)
        {
            _listOfBooks.Add(bookToAdd);
        }

        public int GetNumberOfBooksInLibrary()
        {
            return _listOfBooks.Count();
        }


        public Book FindBookByName(string bookName)
        {
            foreach (Book a in _listOfBooks)
            {
                if (a.Title.Contains(bookName))
                {
                    return a;
                }
            }
            return null;
        }

        public List<Book> FindAllBooksByName(string bookName)
        {
            List<Book> booksToReturn = new List<Book>();

            foreach (Book book in _listOfBooks)
            {
                if (book.Title.Contains(bookName))
                {   
                    booksToReturn.Add(book);
                }
            }
            return booksToReturn;
        }

        public List<Book> GetBooksSortedByTitle()
        {
            return _listOfBooks.OrderBy(book => book.Title).ToList();
        }

        public List<Book> FindBooksByAuthor(string authorName)
        {
            List<Book> booksToReturn = new List<Book>();

            foreach (Book book in _listOfBooks)
            {
                if (book.Author.Contains(authorName))
                {
                    booksToReturn.Add(book);
                }
            }
            return booksToReturn;
        }

        public List<Book> FindAllBooksWithCertainGenre(BookGenre genre)
        {
            List<Book> booksToReturn = new List<Book>();

            foreach (Book book in _listOfBooks)
            {
                if (book.Genre == genre)
                {
                    booksToReturn.Add(book);
                }
            }

            return booksToReturn;
        }

        public void PrintAllBooksWithCertainGenre(BookGenre genre)
        {
            List<Book> books = FindAllBooksWithCertainGenre(genre);

            Console.WriteLine("\n-All books with genre {0}  are :", genre);

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        public bool BorrowBook(string bookName)
        {
            bool wasBorrowingSuccessful = false;

            List<Book> books = FindAllBooksByName(bookName);

            foreach (Book book in books)
            {
                if (book.GetBorrowedStatus() != true)
                {
                    book.BorrowBook();
                    wasBorrowingSuccessful = true;
                }
            }
            return wasBorrowingSuccessful;
        }

        public void PrintAllBookTitlesInLibrary()
        {
            Console.WriteLine("\n-All books are: ");
            foreach (Book book in _listOfBooks)
            {
                book.PrintBookInfo();
            }
        }

        public bool ReturnBook(string bookName)
        {
            bool wasReturningSuccessful = false;
            List<Book> books = FindAllBooksByName(bookName);

            foreach (Book book in books)
            {
                if (book.Title==bookName && book.GetBorrowedStatus()!=false)
                {
                    book.ReturnBook();
                    _listOfBooks.Add(book);
                    wasReturningSuccessful = true;
                }
            }
            return wasReturningSuccessful;
        }

        public void PrintAllBooksByName(string title)
        {
            List<Book> books = FindAllBooksByName(title);

            Console.WriteLine("\n-All books containing term {0} in title are :", title);

            foreach (Book book in books)
            {
                book.PrintBookInfo();
            }
        }

        public void PrintLibraryInfo()
        {
            Console.WriteLine("Library with name {0} is located in {1} and has {2} books", _libraryName, _libraryAddress, _listOfBooks.Count());
        }

        public void PrintAllBooksByAuthor(string author)
        {
            List<Book> books = FindBooksByAuthor(author);

            Console.WriteLine("\n-All books by {0} in library are :", author);

            foreach (Book book in books)
            {
                book.PrintBookInfo();
            }

        }

        public List<Book> GetBooksReleasedAfter(int year)
        {
            List<Book> booksReleasedAfterGivenYear = new List<Book>();

            foreach (Book book in _listOfBooks)
            {
                if (book.ReleaseYear > year)
                {
                    booksReleasedAfterGivenYear.Add(book);
                }
            }

            return booksReleasedAfterGivenYear;
        }
    }

}
