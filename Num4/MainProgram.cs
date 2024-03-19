using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Num4
{
    class MainProgram 
    {
     static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("введіть перше значення");
            double Operand1=double.Parse(Console.ReadLine());
            Console.WriteLine("Ведіть друге значеня");
            double Operand2=double.Parse(Console.ReadLine());
            Calculate.Calckulate(Operand1, Operand2);

        }

    }

}
