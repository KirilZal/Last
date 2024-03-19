using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num2
{
   public static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] bookText = new string[]
            {
            "Page 1: MARCA",
            "Page 2: GAZETA DELLA SPORT",
            "Page 3: GQ.",

            };

            Book.InitializeBook(bookText);

            Book.FindNext("Page 1: MARCA");


            Book.Notess.Method("Page 1: MARCA");


        }
    }
}
