using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Produto
    {
        public string Nome;//atributos
        public double Preco;
        public int Quantidade;
        public Produto()
        {
            Quantidade = 10;

        }
        public Produto(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public Produto(string Nome, double Preco, int Quantidade) : this(Nome, Preco)
        {
            this.Quantidade = Quantidade;
        }

        public double ValorTotalEmEstoque()//metodos
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; 
        }

        public void RemoverProdutos( int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nPreco:" + Preco.ToString(CultureInfo.InvariantCulture) + ", "
            + Quantidade + " unidades, total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
