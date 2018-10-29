using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;
using BookLibrary.Formatters;

namespace BookLibrary.Tests
{
    [TestFixture]
    public class BookTests
    {
        Book book = new Book("John Skeet", "C# in Depth", "Manning", 2019, 4, 900, 40m);

        [Test]
        public void ToFormattedString_FullDescription_ReturnsFormattedString()
        {
            Assert.AreEqual(book.ToFormattedString(new FullDescriptionFormatter()),
                "John Skeet, C# in Depth, 2019, \"Manning\"");
        }

        [Test]
        public void ToFormattedString_TitleOnly_ReturnsFormattedString()
        {
            Assert.AreEqual(book.ToFormattedString(new TitleOnlyFormatter()), "C# in Depth");
        }
    }
}
