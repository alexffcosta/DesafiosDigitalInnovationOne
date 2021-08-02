using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDistancia
{
    class Program
    {
    static void Main()
            {
                int quilometros = Int32.Parse(Console.ReadLine());
                int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
                Console.WriteLine(minutos + " minutos");
            Console.ReadKey();
            }
    }
}
