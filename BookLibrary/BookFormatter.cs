namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides a custom formatter for a string 
    /// representation of the Book object.
    /// </summary>
    public class BookFormatter : IFormatProvider, ICustomFormatter
    {
        /// <summary>
        /// If format type is ICustomFormatter, 
        /// returns this bookFormatter.
        /// </summary>
        /// <param name="formatType"></param>
        /// <returns></returns>
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns a string representation of arg
        /// hat corresponds with the format string
        /// fmt using custom format provider.
        /// </summary>
        /// <param name="fmt"></param>
        /// <param name="arg"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public string Format(string fmt, object arg, IFormatProvider formatProvider)
        {
            if (arg.GetType() != typeof(Book))
            {
                try
                {
                    return HandleOtherFormats(fmt, arg);
                }
                catch (FormatException e)
                {
                    throw new
                        FormatException(String.Format("The format of \"{0}\" is invalid",
                        fmt), e);
                }
            }

            Book book = (Book)arg;
            string result = arg.ToString();
            switch (fmt.ToUpper(CultureInfo.InvariantCulture))
            {
                case "ATYPH":
                    result = String.Format("{0}, {1}, {2}, \"{3}\"",
                        book.Author, book.Title, book.Year, book.PublishingHouse);
                    break;
                case "ATY":
                    result = String.Format("{0}, {1}, {2}",
                        book.Author, book.Title, book.Year);
                    break;
                case "AT":
                    result = String.Format("{0}, {1}",
                        book.Author, book.Title);
                    break;
                case "T":
                    result = String.Format("{0}", book.Title);
                    break;
                default:
                    try
                    {
                        return HandleOtherFormats(fmt, arg);
                    }
                    catch(FormatException e)
                    {
                        throw new
                            FormatException(String.Format("The format of \"{0}\" is invalid",
                            fmt), e);
                    }           
            }

            return result;
        }
        
        /// <summary>
        /// Handles other formats that we do not have a
        /// custom interpretation for.
        /// </summary>
        /// <param name="fmt"></param>
        /// <param name="arg"></param>
        /// <returns></returns>
        private string HandleOtherFormats(string fmt, object arg)
        {
            if (arg is IFormattable)
            {
                return ((IFormattable)arg).ToString(fmt, CultureInfo.CurrentCulture);
            }
            else if (arg != null)
            {
                return arg.ToString();
            }
            else
                return String.Empty;
        }
    }
}
