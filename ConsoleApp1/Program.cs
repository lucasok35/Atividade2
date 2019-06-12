using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] vetor = new decimal[5];
            decimal media = 0;
            Console.WriteLine("Digite a temperatura de 5 dias diferentes!");
            for(int i = 0;i < 5; i++)
            {
                Console.Write("Temperatura do "+(i+1)+" dia: ");
                vetor[i] = Convert.ToDecimal(Console.ReadLine());

            }

            media = (media + vetor.Sum()) / 4;

            Console.WriteLine("A menor temperatura dos 5 dias é: "+ vetor.Min());
            Console.WriteLine("A maior temperatura dos 5 dias é: " + vetor.Max());
            Console.WriteLine("A media de temperatura dos 5 dias é: " + media+"%");
            Console.ReadKey();
        }
    }
}
