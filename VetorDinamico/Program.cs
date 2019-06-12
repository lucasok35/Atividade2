using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDinamico
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            do
            {
                Console.WriteLine("Digite um número inteiro maior que 0!");
                n = Convert.ToInt32(Console.ReadLine());
                int[] vetor = new int[n];
                for(int i = 1;i <=  n; i++)
                {
                    Console.WriteLine("Valores do vetor: "+i);
                }

            } while (n % 2 == 0 && n <= 0);

            Console.ReadKey();
        }
    }
}
