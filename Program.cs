using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatorial = 1;
            for (double i = 1; i <= 170; i++)
            {
                Console.Write("Fatorial de " + i + ": 1");                
                if (i == 1)
                    Console.Write(" x " + i);
                else                
                    for (double u = 2; u <= i; u++)
                        Console.Write(" x " + u);
                fatorial *= i;
                Console.WriteLine(" = " + fatorial);
                if (i == 17)
                {
                    Console.WriteLine(@"
Digite enter caso queira continuar. . .");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
            
        }
    }
}
