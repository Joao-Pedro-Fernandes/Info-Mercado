using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Mercado
{
    internal class Produto
    {
        private int id;
        private string nome;
        private double preco;
        private int qtd;
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Preco { get; set; }
        public int Qtd { get; set; }
    }
}
