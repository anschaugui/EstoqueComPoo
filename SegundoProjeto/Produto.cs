using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Produto
    {
        public string Nome;//atributos
        public double Preco;
        public int Quantidade;



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
            return "Nome: " + Nome + "\nPreco:" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
            + Quantidade + " unidades, total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture) ;
        }
    }
}
