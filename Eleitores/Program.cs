using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleitores
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores, brancos, nulos, validos;

            do
            {
                Console.WriteLine("Digite o numero de eleitores do municipio: ");
                eleitores = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero de votos validos: ");
                validos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero de votos brancos: ");
                brancos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero de votos nulos: ");
                nulos = Convert.ToInt32(Console.ReadLine());

                
                
            } while ((eleitores <= 0) || (brancos < 0) || (nulos < 0) || (validos < 0) || (brancos+nulos+validos>eleitores));
            if(validos != 0 && brancos != 0 && nulos != 0)
            {
                int percval = (validos * 100) / eleitores;
                int percbranc = (brancos * 100) / eleitores;
                int percnul = (nulos * 100) / eleitores;

                Console.WriteLine("O percentual de votos validos é de: " + percval + " %");
                Console.WriteLine("O percentual de votos brancos é de: " + percbranc + " %");
                Console.WriteLine("O percentual de votos nulos é de: " + percnul + " %");

            }
            if(validos != 0 && brancos == 0 && nulos == 0) { 
                int percval = (eleitores * validos)/100;

                Console.WriteLine("O percentual de votos validos é de: "+percval+" %");
                Console.WriteLine("O percentual de votos brancos é de: 0%");
                Console.WriteLine("O percentual de votos nulos é de: 0%");

            }
            if(validos == 0 && brancos != 0 && nulos != 0)
            {
                int percbranc = (eleitores * brancos) / 100;
                int percnul = (eleitores * nulos) / 100;
                Console.WriteLine("O percentual de votos validos é de 0%");
                Console.WriteLine("O percentual de votos brancos é de: " + percbranc + " %");
                Console.WriteLine("O percentual de votos nulos é de: " + percnul + " %");

            }
            if (validos != 0 && brancos == 0 && nulos != 0)
            {
                int percval = (eleitores * validos) / 100;
                int percnul = (eleitores * nulos) / 100;

                Console.WriteLine("O percentual de votos validos é de: " + percval + " %");
                Console.WriteLine("O percentual de votos brancos é de: 0%");
                Console.WriteLine("O percentual de votos nulos é de: " + percnul + " %");

            }
            Console.ReadKey();


        }
    }
}
