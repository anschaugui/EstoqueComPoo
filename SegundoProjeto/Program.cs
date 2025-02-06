using System;
using System.Globalization;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1, produto2;
            produto1 = new Produto();
            produto2 = new Produto();  
             
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            produto1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"dados do produto:\n{produto1}");

            Console.WriteLine();
            Console.Write("digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);

            Console.WriteLine("dados atualizados: " + produto1);

            Console.Write("digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qte);
            Console.WriteLine("dados atualizados: " + produto1);


        }
    }
}