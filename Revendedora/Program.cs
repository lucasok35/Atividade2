using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            double carros, totvendas, salario, comissao, comissaotot, perc, saltotal;

            do
            {
                Console.WriteLine("Digite o total de carros vendidos: ");
                carros = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor total das vendas: ");
                totvendas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor de seu salario: ");
                salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor a receber sobre cada venda: ");
                comissao = Convert.ToDouble(Console.ReadLine());

                comissaotot = comissao * carros;
                perc = totvendas * 0.05;
                saltotal = salario + comissaotot + perc;
                
            } while (carros <= 0);

            Console.WriteLine("O seu salario final é: " + saltotal);

            Console.ReadKey();
        }
    }
}
