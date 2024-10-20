using System;
using System.Globalization;

namespace VerificaçãoEmEstoque
{
    internal class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdiocionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " , " + Quantidade + " Unidades, Total $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
