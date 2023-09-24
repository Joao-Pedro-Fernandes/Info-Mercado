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
    public partial class CadastroProd : Form
    {
        public CadastroProd()
        {
            InitializeComponent();
            dataValidade.Value = DateTime.Now;
            //pictureBox1.SendToBack();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            bool flagId = false;
            int verificaNum;
            double verificaValor;

            if (txtId.Text == String.Empty || txtProd.Text == String.Empty || txtPreco.Text == String.Empty || txtQtd.Text == String.Empty)
                MessageBox.Show("Todos os campos são Obrigatórios");
            else
            {
                if (int.TryParse(txtId.Text, out verificaNum) && int.TryParse(txtQtd.Text, out verificaNum))
                {
                    if (double.TryParse(txtPreco.Text, out verificaValor))
                    {
                        foreach (Produto item in Program.ListaProdutos)
                        {

                            if (item.Id.ToString() == txtId.Text)
                                flagId = true;
                        }
                        if (flagId)
                            MessageBox.Show("Este número de lote já existe!");
                        else
                        {
                            prod.Id = int.Parse(txtId.Text);
                            prod.Nome = txtProd.Text;
                            prod.Qtd = int.Parse(txtQtd.Text);
                            prod.Preco = double.Parse(txtPreco.Text);
                            prod.Perecivel = dataValidade.Value.ToString("dd/MM/yyyy");
                            Program.ListaProdutos.Add(prod);
                            MessageBox.Show("Produto cadastrado!");
                            txtId.Text = "";
                            txtProd.Text = "";
                            txtQtd.Text = "";
                            txtPreco.Text = "";
                            dataValidade.Value = DateTime.Now;
                        }
                    }
                    else
                        MessageBox.Show("Campo Preço só aceita número!");
                }
                else
                    MessageBox.Show("Campo N¨ Lote ou Quantidade só aceitam números inteiros!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
