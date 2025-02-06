using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("nome: ");
            produto1.Nome = Console.ReadLine();
            Console.WriteLine("preco: ");
            produto1.Preco = double.Parse(Console.ReadLine(), System.Globalization.NumberStyles.Currency);
            Console.WriteLine("Quantidade em estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());



        }
    }
}