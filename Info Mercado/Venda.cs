using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info_Mercado
{
    public class Venda
    {
        private int id;
        private string cliente;
        private List<Produto> produtos = new List<Produto>();
        private double valor_total;
        private string data;
        public int Id { get; set; }
        public int Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public int Valor_Total { get; set; }
        public string Data { get; set; }
    }
}
