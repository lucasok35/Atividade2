using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 medidas para formar um triangulo:");
            Console.Write("Medida Lado 1: ");
            decimal lado1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Medida Lado 2: ");
            decimal lado2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Medida Lado 3: ");
            decimal lado3 = Convert.ToDecimal(Console.ReadLine());

            if ((lado1 + lado2 > lado3) || (lado2 + lado3 > lado1) || (lado3 + lado1 > lado2))
            {
                Console.WriteLine("Parabéns você construiu um triangulo!");
            }
            else
            {
                Console.WriteLine("Essas medidas não formam um triangulo!");
            }

            Console.ReadKey();
        }
    }
}
