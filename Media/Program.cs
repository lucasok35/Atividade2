using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<decimal> lstPreco = new List<decimal>();

            
            decimal maior, preco, media = 0;

            Console.WriteLine("Insira o preço de 15 produtos:");
            for(int i = 0;i < 15; i++)
            {
                Console.Write("Digite o "+(i+1)+"º valor: ");
                preco = Convert.ToDecimal(Console.ReadLine());
                lstPreco.Add(preco);
                
            }

            lstPreco.Sort();
            maior = lstPreco.Max();
            media = lstPreco.Sum();
            media = media / 15;
            Console.WriteLine("O maior preço da lista é: " + maior);
            Console.WriteLine("A média dos preços é: "+Math.Round(media, 2).ToString());
            Console.ReadKey();
        }
    }
}
