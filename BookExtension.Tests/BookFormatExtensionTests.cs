using NUnit.Framework;
using BookLibrary;

namespace BookExtension.Tests
{
    [TestFixture]
    public class BookFormatExtensionTests
    {
        Book book = new Book("John Skeet", "C# in Depth", "Manning", 2019, 4, 900, 40m);

        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(book.ToTitlePublisherString(), "C# in Depth, \"Manning\"");
        }
    }
}
