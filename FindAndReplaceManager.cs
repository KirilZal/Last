using Num1;

namespace Num1
{
    using System;
    using System.Runtime.InteropServices;

    public static class FindAndReplaceManager
    {
        private static string[] book;

        public static void InitializeBook(string[] bookText)
        {
            book = bookText;
        }

        public static void FindNext(string str)
        {
            bool found = false;

            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Contains(str))
                {
                    Console.WriteLine($"String '{str}' found on page {i + 1}.");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"String '{str}' not found in the book.");
            }

        }
       
    }


}
