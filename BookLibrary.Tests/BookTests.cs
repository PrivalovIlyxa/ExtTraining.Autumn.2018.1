using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace BookLibrary.Tests
{
    [TestFixture]
    public class BookTests
    {
        Book book = new Book("John Skeet", "C# in Depth", "Manning", 2019, 4, 900, 40m);

        [TestCase("John Skeet, C# in Depth, 2019, \"Manning\"", "ATYPH")]
        [TestCase("John Skeet, C# in Depth, 2019", "ATY")]
        [TestCase("John Skeet, C# in Depth", "AT")]
        [TestCase("C# in Depth", "T")]
        public void ToFormattedString_AuthorTitleYearPubH_ReturnsFormattedString(string arranged, string format)
        {
            Assert.AreEqual(book.ToFormattedString(format, new BookFormatter()), arranged);
        }

        [TestCase("TA")]
        public void ToFormattedString_InvalidFormatter_ReturnsStrandartToString(string format)
        {
            Assert.AreEqual(book.ToString(), book.ToFormattedString(format, new BookFormatter()));
        }
    }
}
