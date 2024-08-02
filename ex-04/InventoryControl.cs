using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04
{
    public class InventoryControl
    {
        private Dictionary<string, int> produtos = new Dictionary<string, int>();

        public void AdicionarProduto(string nome, int quantidade)
        {
            if (produtos.ContainsKey(nome))
            {
                produtos[nome] += quantidade;
            }
            else
            {
                produtos[nome] = quantidade;
            }
        }

        public int ObterQuantidade(string nome)
        {
            if (produtos.ContainsKey(nome))
            {
                return produtos[nome];
            }

            return 0;
        }
    }
}
