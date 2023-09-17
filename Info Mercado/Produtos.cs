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
            lstProdutos.LabelEdit = true;
            lstProdutos.AllowColumnReorder = true;
            lstProdutos.FullRowSelect = true;
            lstProdutos.GridLines = true;

            lstProdutos.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstProdutos.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lstProdutos.Columns.Add("Preço", 260, HorizontalAlignment.Left);
            lstProdutos.Columns.Add("Qtd", 100, HorizontalAlignment.Left);
        }
    }
}
