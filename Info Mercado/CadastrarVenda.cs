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
            lstVenderProdutos.Items.Clear();
            foreach (Produto p in Program.ListaProdutos)
            {
                string[] row = { p.Id.ToString(), p.Nome, p.Qtd.ToString(), p.Preco.ToString("R$0.00") };
                var listViewItem = new ListViewItem(row);
                lstVenderProdutos.Items.Add(listViewItem);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (rdbCartao.Checked) venda.Pagamento = "Cartão";
            else venda.Pagamento = "Dinheiro";
            if (txtNomeCLiente.Text == "")
            {
                MessageBox.Show("O nome do cliente não pode estar vazio!");
                Dispose();
                return;
            }
            if (venda.Produtos == null)
            {
                MessageBox.Show("Não produtos nesta venda!");
                Dispose();
                return;
            }
            foreach (Produto p in venda.Produtos)
            {
                if (p.Qtd > 0)
                {
                    foreach (Produto produto in Program.ListaProdutos)
                        if (p.Id == produto.Id)
                        {
                            int x = produto.Qtd; int y = produto.QtdVenda;
                            if ((x-y)>=0)
                                produto.Qtd -= produto.QtdVenda;
                            else
                            {
                                MessageBox.Show("Quantidade insuficiente!");
                                Dispose();
                                return;
                            }
                        }                       
                }     
                else
                {
                    MessageBox.Show("Não temos esse produto em estoque!");
                    Dispose();
                    return;
                }
            }
            venda.Cliente = txtNomeCLiente.Text;
            Program.ListaVendas.Add(venda);
            Program.CountVendas++;
            MessageBox.Show("Venda realizada com sucesso!");
            Dispose();
        }
    }
}
