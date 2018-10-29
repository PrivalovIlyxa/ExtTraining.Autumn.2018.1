using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace BookExtension
{
    public static class BookFormatExtension
    {
        /// <summary>
        /// An extension method for Book class that provides
        /// a different way to format a string representation of 
        /// Book instance.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static string ToTitlePublisherString(this Book book)
        {
            return string.Format("{0}, \"{1}\"", book.Title, book.PublishingHouse);
        }
    }
}
