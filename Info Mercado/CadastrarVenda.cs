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
    public partial class CadastrarVenda : Form
    {
        private Venda venda = new Venda();
        public CadastrarVenda()
        {
            venda.Id = Program.CountVendas;
            venda.Data = System.DateTime.Now.ToString();
            venda.Produtos = new List<Produto>();

            InitializeComponent();
            lstVenderProdutos.View = View.Details;
            lstVenderProdutos.LabelEdit = true;
            lstVenderProdutos.AllowColumnReorder = true;
            lstVenderProdutos.FullRowSelect = true;

            lstVenderProdutos.Columns.Add("Id", 70, HorizontalAlignment.Center);
            lstVenderProdutos.Columns.Add("Nome", 320, HorizontalAlignment.Center);
            lstVenderProdutos.Columns.Add("Qtd. Estoque", 150, HorizontalAlignment.Center);
            lstVenderProdutos.Columns.Add("Preço", 200, HorizontalAlignment.Center);

            //REMOVER
            Produto P = new Produto();
            P.Id = 1;
            P.Nome = "Nescau";
            P.Preco = 5;
            P.Qtd = 10;
            P.Perecivel = false;
            Program.ListaProdutos.Add(P);

            Produto P1 = new Produto();
            P1.Id = 2;
            P1.Nome = "Arroz";
            P1.Preco = 22;
            P1.Qtd = 10;
            P1.Perecivel = false;
            Program.ListaProdutos.Add(P1);

            Produto P2 = new Produto();
            P2.Id = 3;
            P2.Nome = "Feijão";
            P2.Preco = 11;
            P2.Qtd = 10;
            P2.Perecivel = false;
            Program.ListaProdutos.Add(P2);
            //REMOVER

            lblId.Text = venda.Id.ToString();
            lblData.Text = venda.Data.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lstVenderProdutos.Items.Clear();
            foreach (Produto p in Program.ListaProdutos)
            {
                if (p.Nome == txtPesquisa.Text)
                {
                    string[] row = {p.Id.ToString(), p.Nome, p.Qtd.ToString(), p.Preco.ToString("R$0.00")};
                    var listViewItem = new ListViewItem(row);
                    lstVenderProdutos.Items.Add(listViewItem);
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            bool find = false;
            try
            {
                string idSelecionado = "";
                foreach (ListViewItem item in lstVenderProdutos.SelectedItems)
                    idSelecionado += item.SubItems[0].Text;

                foreach (Produto produto in Program.ListaProdutos)
                    if (produto.Id == int.Parse(idSelecionado))
                    {
                        foreach (Produto p in venda.Produtos)
                            if (produto.Id == p.Id)
                                find = true;
                        
                        if (find)
                        {
                            produto.QtdVenda++;
                            venda.Valor_Total += produto.Preco;
                        }                         
                        else
                        {
                            produto.QtdVenda++;
                            venda.Produtos.Add(produto);
                            venda.Valor_Total += produto.Preco;
                        }                                         
                    }
                lblListaProdutos.Text = "";
                foreach (Produto produto in venda.Produtos)
                {
                    lblListaProdutos.Text += $"{produto.QtdVenda} {produto.Nome}, ";          
                }
                lblValorTotal.Text = venda.Valor_Total.ToString("R$0.00");
            }
            catch
            {
                MessageBox.Show("Produto Não Adicionado!");
            }
                                      
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (Produto p in Program.ListaProdutos)
            {
                string[] row = { p.Id.ToString(), p.Nome, p.Qtd.ToString(), p.Preco.ToString("R$0.00") };
                var listViewItem = new ListViewItem(row);
                lstVenderProdutos.Items.Add(listViewItem);
            }
        }
    }
}
