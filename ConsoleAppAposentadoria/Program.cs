using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos anos você tem: ");
            int idd = int.Parse(Console.ReadLine());

            Console.Write("Quantos anos você trabalhou: ");
            int tra = int.Parse(Console.ReadLine());

            if ((idd >= 65) || (tra >=30) || (idd>=60 && tra >= 25))
            {
                Console.Write("Você tem direito a aposentadoria");
            }
            else
            {
                Console.Write("Você não tem direito a aposentadoria");
            }

            Console.ReadKey();
        }
    }
}
