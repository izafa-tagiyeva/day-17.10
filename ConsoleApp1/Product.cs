using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        //        Product class
        //Price -> (encapsulation)
        //Count -> (encapsulation)
        //No
        //Name

        public int No;
        public string Name;
        private decimal _price;
        private int _count;

        public Product(int no, string name, decimal price, int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }

        public decimal Price
        {
            get { return _price; }
            private set
            {
                if (value >= 0) _price = value;
                else { Console.WriteLine("Price cannot be negative."); }
            }
        }

        public int Count
        {
            get { return _count; }
            private set
            {
                if (value >= 0) _count = value;
                else { Console.WriteLine("Count cannot be negative."); }
            }
        }

    }
}
