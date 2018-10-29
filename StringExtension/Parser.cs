using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class Parser
    {
        /// <summary>
        /// Converts a string representation of a number 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="base"></param>
        /// <returns></returns>
        public static int ToDecimal(this string source, int @base)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            if (@base < 2 || @base > 16)
            {
                throw new ArgumentOutOfRangeException();
            }

            char[] digits = source.ToCharArray();
            int result = 0;
            int digit;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digit = CharToInt(digits[i]);
                if (digit >= @base)
                {
                    throw new ArgumentException();
                }
                try
                {
                    checked
                    {
                        result += (int)((double)CharToInt(digits[i]) *
                            Math.Pow((double)@base, (double)(digits.Length - 1 - i)));
                    }
                }
                catch (OverflowException)
                {
                    throw;
                }
            }

            return result;
        }

        private static int CharToInt(char c)
        {
            c = char.ToUpper(c);
            if ((int)c < (int)'A')
            {
                return int.Parse(c.ToString());
            }
            else
            {
                switch (c)
                {
                    case 'A':
                        return 10;
                    case 'B':
                        return 11;
                    case 'C':
                        return 12;
                    case 'D':
                        return 13;
                    case 'E':
                        return 14;
                    case 'F':
                        return 15;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
