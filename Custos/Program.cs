using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custos
{
    class Program
    {
        static void Main(string[] args)
        {
            double custoconsumidor, custofab, percdist = 0.28, percimp = 0.45;

            do
            {
                Console.WriteLine("Digite o valor do custo de fabrica do carro: ");
                custofab = Convert.ToInt32(Console.ReadLine());
                custoconsumidor = (custofab * percdist) + (custofab * percimp) + custofab;

            } while (custofab<=0);

            Console.WriteLine("O custo do carro ao consumidor é de: " + custoconsumidor+" reais!");
            Console.ReadKey();
        }
    }
}
