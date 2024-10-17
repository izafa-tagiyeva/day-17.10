using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
        /* Library class
           =============
           Book[] Books;

           void AddBook(Book book) - Book tipinden book qebul edir parameter olaraq ve onu
           Books arrayine elave edir.
           GetFilteredBooks(string genre) -> janr deyeri daxil edib hemin janra uygun kitablarin siyahisini geriye qaytarir.
           GetFilteredBooks(int minPrice, int maxPrice) -> minimum qiymet ve maksimum qiymet qebul edib
           bu qiymet araligindaki kitablarin siyahisini geriye qaytarir.
           void ShowAllBooks() - Books arrarindeki kitablari gosterir */

        public Book[] Books;

        public Library()
        {
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {

            Book[] filteredBooks = new Book[Books.Length+1];
            int index = 0;

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre.ToLower() == genre.ToLower())
                {
                    filteredBooks[index] = Books[i];
                    index++;
                }
            }

            return filteredBooks;



        }

        public Book[] GetFilteredBooks(decimal minPrice, decimal maxPrice)
        {
            Book[] filteredBooks = new Book[0];
            int index = 0;

            
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null && Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                  
                    Array.Resize(ref filteredBooks, index + 1);
                    filteredBooks[index] = Books[i];
                    index++;
                }
            }

            return filteredBooks;
        }

        public void ShowAllBooks()
        {
            foreach (var book in Books)
            {
                book.ShowInfo();
            }
        }
    }






}

