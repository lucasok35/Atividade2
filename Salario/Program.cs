using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salfixo, totvendas, perc;
            Console.WriteLine("Digite as informações abaixo para saber o valor total do seu salario!");
            Console.WriteLine("Digite o valor do seu salario fixo: ");
            salfixo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas: ");
            totvendas = Convert.ToDecimal(Console.ReadLine());

                perc = totvendas * 0.03m;
                salfixo = salfixo + perc;
            
            if(totvendas > 1500)
            {
                salfixo = (totvendas * 0.05m)+salfixo;
                
            }
            

            Console.WriteLine("O valor total do seu salario é: " + salfixo);

            Console.ReadKey();
        }
    }
}
