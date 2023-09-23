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
        private string perecivel;
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }
        public string Perecivel { get; set; }
    }
}
