using System;
using System.Globalization;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
                
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         

            Produto produto3 = new Produto()
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };  

            Console.WriteLine();
            Console.WriteLine("dados do produto: " + produto3);

            Console.WriteLine();
            Console.Write("digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto3.AdicionarProdutos(qte);

            Console.WriteLine("dados atualizados: " + produto3);

            Console.Write("digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto3.RemoverProdutos(qte);
            Console.WriteLine("dados atualizados: " + produto3);


        }
    }
}