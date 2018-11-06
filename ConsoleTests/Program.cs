using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;
using StringExtension;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("John Skeet", "C# in Depth", "Manning", 2019, 4, 900, 40m);
            book.ToFormattedString("TA", new BookFormatter());
        }
    }
}
