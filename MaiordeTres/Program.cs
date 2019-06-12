using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiordeTres
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 3 numeros inteiros diferentes para saber qual o maior deles: ");
            Console.Write("1ª: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2ª: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3ª: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if(num1 == num2 && num1 == num3)
            {
                Console.WriteLine("Os numeros são iguais!");
            }
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O maior numero é: "+num1);
            }
            if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O maior numero é: " + num2);
            }
            if(num3 > num1 && num3 > num2)
            {
                Console.WriteLine("O maior numero é: " + num3);
            }

            Console.ReadKey();
  
        }
    }
}
