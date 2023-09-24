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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            lstVendas.View = View.Details;
            lstVendas.LabelEdit = true;
            lstVendas.AllowColumnReorder = true;
            lstVendas.FullRowSelect = true;
            lstVendas.GridLines = true;

            lstVendas.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstVendas.Columns.Add("Cliente", 200, HorizontalAlignment.Left);
            lstVendas.Columns.Add("Produtos", 260, HorizontalAlignment.Left);
            lstVendas.Columns.Add("Valor", 100, HorizontalAlignment.Left);




        }

        private void btnCadastrarVenda_Click(object sender, EventArgs e)
        {
            CadastrarVenda cadastrarVenda = new CadastrarVenda();
            cadastrarVenda.ShowDialog();
        }

        private void btnMostrarVendas_Click(object sender, EventArgs e)
        {
            lstVendas.Items.Clear();
            foreach (Venda v in Program.ListaVendas)
            {
                string[] row = { v.Id.ToString(), v.Cliente, v.GetProdutos() , v.Valor_Total.ToString("R$0.00") };
                var listViewItem = new ListViewItem(row);
                lstVendas.Items.Add(listViewItem);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lstVendas.Items.Clear();
            foreach (Venda v in Program.ListaVendas)
                if (v.Cliente == txtPesquisaVenda.Text)
                {
                    string[] row = { v.Id.ToString(), v.Cliente, v.GetProdutos(), v.Valor_Total.ToString("R$0.00") };
                    var listViewItem = new ListViewItem(row);
                    lstVendas.Items.Add(listViewItem);
                }     
        }
    }
}
