using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Product class
               Price -> (encapsulation)
               Count -> (encapsulation)
               No
               Name

               Book class
               ===========
               string Genre
               Book classi Productdan miras alir. Book yaratmaq istedikde butun deyerleri daxil edilmeden
               (no, price, name, genre) yaradila bilmesin.
               ShowInfo() - kitabin butun melumatlarini ekranda gosterir

               Library class
               =============
               Book[] Books;

               void AddBook(Book book) - Book tipinden book qebul edir parameter olaraq 
               ve onu Books arrayine elave edir.
               GetFilteredBooks(string genre) -> janr deyeri daxil edib hemin janra uygun
               kitablarin siyahisini geriye qaytarir.
               GetFilteredBooks(int minPrice, int maxPrice) -> minimum qiymet ve maksimum qiymet qebul edib
               bu qiymet araligindaki kitablarin siyahisini geriye qaytarir.
               void ShowAllBooks() - Books arrarindeki kitablari gosterir */



            Library library = new Library();

            Book book1 = new Book(1, "Harry potter and the Chamber secret", 10.99m, 5, "Fiction");
            Book book2 = new Book(2, "Harry POtter and the Prisioner of Azkaban", 7.99m, 3, "Fiction");
            Book book3 = new Book(3, "1984", 15.50m, 7, "Dystopian");
            Book book4 = new Book(4, "The Mountain is you", 20.00m, 10, "Psychology");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine("All Books:");
            library.ShowAllBooks();

            Console.WriteLine("\nFiltered Books by Genre (Fiction):");
            Book[] fictionBooks = library.GetFilteredBooks("Fiction");
            foreach (var book in fictionBooks)
            {
              
                if (book != null)
                {
                    book.ShowInfo();
                }
            }

            
            Console.WriteLine("\nFiltered Books by Price (8 to 16):");
            Book[] priceFilteredBooks = library.GetFilteredBooks(8m, 16m);
            foreach (var book in priceFilteredBooks)
            {
                
                if (book != null)
                {
                    book.ShowInfo();
                }
            }


        }
    }
}
