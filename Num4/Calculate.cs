using System.ComponentModel;

namespace Num4
{
    public static class Calculate
    {
       public static void Calckulate(double Item1,double Item2)
        {
            Console.WriteLine("введіть знак арефметичноі операціі");
            double result = 0;
            char operation =Console.ReadLine()[0];
            switch(operation)

            {
                case '+':
                    result=Item1 + Item2;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result=Item1 - Item2;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result=Item1 * Item2;
                    Console.WriteLine(result);
                    break;
                    case '/':
                    if (Item1 != 0 && Item2 != 0)
                        {
                        result = Item1 / Item2;

                       Console.WriteLine(result);
                     break;
                      }
                    else
                    {
                        Console.WriteLine("ERROR");
                        break;
                    }
            }
        }
    }
}