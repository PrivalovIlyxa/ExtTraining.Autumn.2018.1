﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class TitleYearPublisherFormatter : IFormatter
    {
        public string Form(Book book)
        {
            return String.Format("{0}, {1}, \"{2}\"", book.Author, book.Title, book.PublishingHouse);
        }
    }
}