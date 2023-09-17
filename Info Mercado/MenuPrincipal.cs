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
    }
}
