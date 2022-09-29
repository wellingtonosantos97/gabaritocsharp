using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo35
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int soma = numero1 + numero2;
            Console.WriteLine($"Valor do produto: {soma}");
            Console.ReadKey();

        }
    }
}
