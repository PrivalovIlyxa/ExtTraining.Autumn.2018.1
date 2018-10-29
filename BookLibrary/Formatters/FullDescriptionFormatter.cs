using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Formatters
{
    public class FullDescriptionFormatter : IFormatter
    {
        public string Form(Book book)
        {
            return String.Format("{0}, {1}, {2}, \"{3}\"", book.Author, book.Title, book.Year, book.PublishingHouse);
        }
    }
}
