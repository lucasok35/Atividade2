using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal peso_ideal, altura;
            string nome;
            char sexo;
            
            Console.WriteLine("Para saber o peso ideal digite as informações abaixo:");
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua altura:");
            altura = Convert.ToDecimal(Console.ReadLine());
            
            do
            {
                Console.WriteLine("Digite o seu sexo (M ou F):");
                sexo = Convert.ToChar(Console.ReadLine());
            } while (sexo != 'm' && sexo != 'f');

           

            if(sexo == 'm')
            {
                peso_ideal = (72.7m * altura)-58m;
            }
            else
            {
                peso_ideal = (62.1m * altura)-44.7m;
            }

            Console.WriteLine("O peso ideal para você é: " + peso_ideal);
            Console.ReadKey();
        }
    }
}
