using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            double  number1, number2 ,c;
            string stnumber1, stnumber2;

            stnumber1 = Console.ReadLine();
           stnumber2 = Console.ReadLine();
            number1 = double.Parse(stnumber1);
            number2 = double.Parse(stnumber2);

            c = number1 + number2;
          

            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
