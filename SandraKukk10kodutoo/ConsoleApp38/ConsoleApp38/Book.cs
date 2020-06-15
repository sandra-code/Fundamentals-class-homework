﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public enum BookGenre { Horror, ScienceFiction, Romance, Drama, Cookbook}
    class Book
    {

        private string _title;
        private string _author;
        private int _releaseYear;
        private BookGenre _genre;
        bool _isBorrowed;

        public Book()
        {
            _isBorrowed = false;
        }

        public Book(string title, string author)
        {
            _isBorrowed = false;
            _title = title;
            _author = author;
        }

        public int SetReleaseYear(int releaseYear)
        {
            _releaseYear = releaseYear;
            return _releaseYear;
        }

        public BookGenre Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public bool GetBorrowedStatus()
        {
            return _isBorrowed;
        }

        public void BorrowBook()
        {
            _isBorrowed = true;
        }

        public void ReturnBook()
        {
            _isBorrowed = false;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value != "")
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (value != "")
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }
            }

        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value >0)
                {
                    _releaseYear = value;
                }
                else
                {
                    Console.WriteLine("Invalid value!");
                }

               
            }
        }

        public bool CompareBooks(Book book2)
        {
            bool areBooksEqual = false;

            if(_title==book2.Title && _author == book2.Author)
            {
                areBooksEqual = true;
            }

            return areBooksEqual;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine("{0} by {1}, {2}", _title, _author, _releaseYear);
        }

    }
}
