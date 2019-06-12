using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habitantes
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal salario, mediasalario = 0, mediafilhos = 0, maiorsalario, percmenor = 0;
            int filhos;
            List<decimal> lstSalario = new List<decimal>();
            List<int> lstFilhos = new List<int>();
            Console.WriteLine("Insira o salario e número de filhos de 4 pessoas!");
            for(int i = 0;i < 4; i++)
            {
                Console.Write("Salário do habitante " + (i + 1) + ":");
                salario = Convert.ToDecimal(Console.ReadLine());
                lstSalario.Add(salario);

                if (salario < 150)
                {
                    percmenor++;
                }

                Console.Write("Número de filhos do habitante " + (i + 1) + ":");
                filhos = Convert.ToInt32(Console.ReadLine());
                lstFilhos.Add(filhos);
                               
            }

            maiorsalario = lstSalario.Max();
            mediasalario = (mediasalario + lstSalario.Sum()) / 4;
            mediafilhos = (mediafilhos + lstFilhos.Sum()) / 4;
            percmenor = percmenor * 100 / 4;

            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("O maior salario dos habitantes é: "+maiorsalario);
            Console.WriteLine("A media de salario dos habitantes é: " + mediasalario);
            Console.WriteLine("A media de filhos dos habitantes é: " + mediafilhos);
            Console.WriteLine("O percentual de salario menor que 150 dos habitantes é: " + percmenor+"%");
            Console.ReadKey();
        }
    }
}
