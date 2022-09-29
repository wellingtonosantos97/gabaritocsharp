using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para saber o tipo: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numero} é um número do tipo: {numero.GetType()} !");
            Console.ReadKey();

        }
    }
}
