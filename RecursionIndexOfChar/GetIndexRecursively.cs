using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            return RGetInChar(str, value, 0);
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            return RGetInChar2(str, value, startIndex, count);
        }

        public static int RGetInChar(string str, char val, int curi)
        {
            if (curi >= str.Length)
            {
                return -1;
            }

            if (str[curi] == val)
            {
                return curi;
            }

            return RGetInChar(str, val, curi + 1);
        }

        public static int RGetInChar2(string str, char val, int curi, int count)
        {
            if (count <= 0)
            {
                return -1;
            }

            if (curi >= str.Length)
            {
                return -1;
            }

            if (str[curi] == val)
            {
                return curi;
            }

            return RGetInChar2(str, val, curi + 1, count - 1);
        }
    }
}
