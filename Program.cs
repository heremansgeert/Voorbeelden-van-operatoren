using System;

namespace Voorbeelden_van_operatoren
{
    class Program
    {
        static void Main(string[] args)
        {

            int intUitkomst;

            intUitkomst= 2 + 3 + 5;
            Console.WriteLine(intUitkomst);//output is 10

            intUitkomst = 5 - 2;
            Console.WriteLine(intUitkomst);//output is 3

            intUitkomst = 5 * 3;
            Console.WriteLine(intUitkomst);//output is 15

            intUitkomst = 10 / 2;
            Console.WriteLine(intUitkomst);//output is 5


            intUitkomst = 6 % 2;
            Console.WriteLine(intUitkomst);//output is 0

            intUitkomst = 6 % 4;
            Console.WriteLine(intUitkomst);//output is 2 (rest na deling)

            intUitkomst = 5;
            intUitkomst++;
            Console.WriteLine(intUitkomst);//output is 6

            intUitkomst = 5;
            intUitkomst--;
            Console.WriteLine(intUitkomst);//output is 4

        

        }
    }
}
