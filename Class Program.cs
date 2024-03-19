using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num1
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] bookText = new string[]
            {
            "Page 1: MARCA",
            "Page 2: GAZETA DELLA SPORT",
            "Page 3: GQ.",

            };

            FindAndReplaceManager.InitializeBook(bookText);

            FindAndReplaceManager.FindNext("Page 1: MARCA");

            Console.ReadLine();
           

        }
    }
}
