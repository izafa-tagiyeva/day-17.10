using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book:Product
    {
        // Book class
        //===========
        //string Genre
        //Book classi Productdan miras alir.
        //Book yaratmaq istedikde butun deyerleri daxil edilmeden (no, price, name, genre) yaradila bilmesin.
        //ShowInfo() - kitabin butun melumatlarini ekranda gosterir


        public string Genre;

            public Book(int no, string name, decimal price, int count, string genre)
                : base(no, name, price, count)
            {
                Genre = genre;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Book No: {No}, Name: {Name}, Price: {Price}, Count: {Count}, Genre: {Genre}");
            }
        




    }
}
