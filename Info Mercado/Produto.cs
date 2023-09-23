using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Mercado
{
    public class Produto
    {
        private int id;
        private string nome;
        private double preco;
        private int qtd;
        private bool perecivel;
        private int qtdVenda = 0;

        public int QtdVenda { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Qtd { get; set; }
        public bool Perecivel { get; set; }
    }
}
