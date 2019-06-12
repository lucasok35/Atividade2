using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            
            Console.WriteLine("Digite a sua idade em anos, meses e dias: ");
            do
            {
                Console.WriteLine("Anos: ");
                anos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Meses: ");
                meses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dias: ");
                dias = Convert.ToInt32(Console.ReadLine());
            } while (anos <= 0 || meses < 0 || dias<0);


            anos = anos * 365;
            meses = meses * 30;
            dias = dias + meses + anos;

            Console.Write("Você tem " + dias + " dias!");

            Console.ReadKey();
            //Console.Clear();
            
        }
    }
}
