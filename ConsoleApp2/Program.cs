using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] soma = new decimal[10];

            Console.WriteLine("Insira 10 números!");
            for(int i = 0;i < 10; i++)
            {
                Console.Write(i+1+"º valor: ");
                soma[i] = Convert.ToDecimal(Console.ReadLine());


            }
            Console.WriteLine("A soma entre os valores digitados é: " + soma.Sum());

            Console.ReadKey();
        }
    }
}
