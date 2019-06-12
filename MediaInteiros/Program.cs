using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal media;
            int i =15;
            Console.WriteLine("Média dos numeros entre 15(inclusive) e 100(inclusive)");
            int[] vetor = new int[100];

            for ( i = 15; i >=100;i++)
            {
                i = i ++;
                
            }
            media = i;
            media = media / 85;
            Console.WriteLine("Valor da media é: " + media);
            Console.ReadKey();

        }
    }
}
