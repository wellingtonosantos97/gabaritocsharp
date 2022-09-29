using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int terceiroNumero = int.Parse(Console.ReadLine());
            double soma = primeiroNumero + segundoNumero + terceiroNumero / 3;
            Console.WriteLine($"A média aritmética é: {soma}");
            Console.ReadKey();

        }
    }
}
