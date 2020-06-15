using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp38
{
    [TestFixture]
    class LibraryTest
    {
        Book book1, book2, book3, book4, book5;
        Library myLibrary;

        [SetUp]
        public void CreateObjects()
        {
            book1 = new Book("Magic mountain", "james smith");
            book1.Genre = BookGenre.ScienceFiction;
            book1.ReleaseYear = 1864;

            book2 = new Book("Magic", "mari maasikas");
            book2.Genre = BookGenre.ScienceFiction;
            book2.ReleaseYear = 1901;

            book3 = new Book("Blindness", "juku kalle");
            book3.Genre = BookGenre.Drama;
            book3.ReleaseYear = 2000;

            book4 = new Book("Space", "mari maasikas");
            book4.Genre = BookGenre.ScienceFiction;
            book4.ReleaseYear = 2001;

            book5 = new Book("Space", "mari maasikas");
            book5.Genre = BookGenre.ScienceFiction;
            book5.ReleaseYear = 2001;

            myLibrary = new Library("town library");
        }

        [Test]
        public void AddBook_Add1BookToLibrary()
        {
            myLibrary.AddBook(book1);
            Assert.AreEqual(myLibrary.GetNumberOfBooksInLibrary(), 1);
        }

        [Test]
        public void TestFinding1Book()
        {
            myLibrary.AddBook(book1);
            Assert.AreEqual(book1.Title, myLibrary.FindBookByName("Magic mountain").Title);
        }

        [Test]
        public void TestFindingBookByGenre_SciFi()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);

            List<Book> books =
                myLibrary.FindAllBooksWithCertainGenre(BookGenre.ScienceFiction);

            Assert.AreEqual(books.Count, 2);
        }

        [Test]
        public void BorrowBook_DidBookStatusChange()
        {
            myLibrary.AddBook(book1);
            myLibrary.BorrowBook("Magic mountain");
            Assert.IsTrue(book1.GetBorrowedStatus() == true);
        }

        [Test]
        public void BorrowBook_WasBorrowingSuccesful()
        {
            myLibrary.AddBook(book1);
            bool canBorrow = myLibrary.BorrowBook("Magic mountain");
            Assert.IsTrue(canBorrow);
        }

        [Test]
        public void ReturnBook_WasReturningSuccesful()
        {
            myLibrary.AddBook(book1);
            myLibrary.BorrowBook("Magic mountain");
            bool canReturn = myLibrary.ReturnBook("Magic mountain");
            Assert.IsTrue(canReturn);
        }
        [Test]
        public void ReturnBook_DidBookStatusChange()
        {
            myLibrary.AddBook(book1);
            myLibrary.ReturnBook("Magic mountain");
            Assert.IsTrue(book1.GetBorrowedStatus() == false);
        }



        [Test]
        public void BorrowBook_CantBorrowAlreadyBorrowedBook()
        {
            myLibrary.AddBook(book1);
            bool canBorrow = myLibrary.BorrowBook("Sci-fi 1");
            bool canBorrowAgain = myLibrary.BorrowBook("Sci-fi 1");
            Assert.IsFalse(canBorrowAgain);
        }

        [Test]
        public void GetAllBooksThatContain_Magic_InTitle()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            List<Book> allBooksThatContainSci = myLibrary.FindAllBooksByName("Magic");
            Assert.IsTrue(allBooksThatContainSci.Count == 2);
        }

        [Test]
        public void FindBooksByAuthor_mariMaasikas()
        {
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);
            myLibrary.AddBook(book4);

            List<Book> allBooksByMariMaasikas = myLibrary.FindBooksByAuthor("mari");
            Assert.IsTrue(allBooksByMariMaasikas.Count == 2);

        }
        [Test]
        public void CompareBooks_MariMaasikas()
        {
            bool areBooksEqual = book4.CompareBooks(book5);
            Assert.IsTrue(areBooksEqual== true);
        }
        [Test]
        public void GetBooksReleasedAfter_1900()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);
            myLibrary.AddBook(book4);
            myLibrary.AddBook(book5);

            List<Book> allBooksReleasedAfter1900 = myLibrary.GetBooksReleasedAfter(1900);
            Assert.IsTrue(allBooksReleasedAfter1900.Count == 4);
        }



    }


}

