using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book 
    {
        private string _author;
        private string _title;
        private string _publishingHouse;
        private int _year;
        private int _edition;
        private int _pages;
        private decimal _price;

        public Book(string author, string title, string publishingHouse,
            int year, int edition, int pages, decimal price)
        {
            _author = author;
            _title = title;
            _publishingHouse = publishingHouse;
            _year = year;
            _edition = edition;
            _pages = pages;
            _price = price;
        }

        public string Author => _author;
        public string Title => _title;
        public string PublishingHouse => _publishingHouse;
        public int Year => _year;
        public int Edition => _edition;
        public int Pages => _pages;
        public decimal Price => _price;

        /// <summary>
        /// Rerpesents book instance as a string
        /// according to an interface.
        /// </summary>
        /// <param name="formatter"></param>
        /// <returns></returns>
        public string ToFormattedString(IFormatter formatter)
        {
            return formatter.Form(this);
        }
    }
}
