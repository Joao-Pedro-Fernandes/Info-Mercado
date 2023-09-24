using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_Mercado
{
    public partial class MenuPrincipal : Form
    {
        public static int segundos = 0;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            var vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var produtos = new Produtos();
            produtos.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblTimer.Text = $"Tempo em Atividade: {segundos}s.";
        }
    }
}
