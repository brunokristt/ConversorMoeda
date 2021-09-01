using System;
using System.Globalization;

namespace ConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de moedas!");
            Console.Write("Qual a atual cotação da moeda a ser comprada: ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a quantidade que você deseja comprar: ");
            double quantidade = int.Parse(Console.ReadLine());
            
            double result = Calculadora.Calc(cotacao, quantidade);

            Console.WriteLine();
            Console.WriteLine("O valor em reis é de " + result.ToString("F2",CultureInfo.InvariantCulture ));
        }
    }
}
