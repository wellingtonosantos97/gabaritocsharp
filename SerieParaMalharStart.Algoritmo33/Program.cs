using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int antecessor = numero - 1;
            int sucessor = numero + 1;
            Console.WriteLine($"O número antecessor de {numero} é: {antecessor}");
            Console.WriteLine($"O número sucessor de {numero} é: {sucessor}");
            Console.ReadKey();
        }
    }
}
