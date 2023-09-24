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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            
           
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroProduto = new CadastroProd();
            cadastroProduto.ShowDialog();
        }

        private void pesquisarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pesquesaProduto = new PesquisaProd();
            pesquesaProduto.ShowDialog();
        }

        
    }
}
