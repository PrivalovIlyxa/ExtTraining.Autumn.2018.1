using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class TitleOnlyFormatter : IFormatter
    {
        public string Form(Book book)
        {
            return String.Format("{0}", book.Title);
        }
    }
}
