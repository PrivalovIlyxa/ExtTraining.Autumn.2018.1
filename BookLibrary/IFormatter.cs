using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    /// <summary>
    /// Provides a contract for a class to
    /// be a formatter for Book.ToFormattedString method.
    /// </summary>
    public interface IFormatter
    {
        string Form(Book book);
    }
}
