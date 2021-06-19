using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    public class Program
    {
        static void Main(string[] args)
        {

            int i;
            for(i = 0; i <= 100; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }
                string divisorPor3 = VerificarDivisaoPor3(i);
                string divisaoPor5 = VerificarDivisaoPor5(i);
                Console.WriteLine(i + divisorPor3 + divisaoPor5);
            }
            Console.ReadLine();
        }

        private static string VerificarDivisaoPor3(int i)
        {
            if (i % 3 == 0)
                return " PIX";
            else
                return "";
        }

        private static string VerificarDivisaoPor5(int i)
        {
            if (i % 5 == 0)
                return " TED";
            else
                return "";
        }


    }
}
