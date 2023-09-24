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
    public partial class PesquisaProd : Form
    {
        public PesquisaProd()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            listProd.Items.Clear(); 
            int verificaNum;
            bool flagId = true;
            if (int.TryParse(txtId.Text, out verificaNum))
            {
                if (Program.ListaProdutos.Any())
                {
                    foreach (Produto item in Program.ListaProdutos)
                    {
                        if (item.Id.ToString() == txtId.Text)
                        {
                            string aux = item.Nome + "     R$:" + item.Preco.ToString("N2") + "     Quantidade:" + item.Qtd + "    Validade:" + item.Perecivel.ToString();
                            listProd.Items.Add(aux);
                            flagId = false;
                        }
                                                    
                    }
                    if(flagId)
                        MessageBox.Show("Número de lote não existe.");

                }
                else
                    MessageBox.Show("Não exite nenhum produto cadastrado.");

            }
            else
                MessageBox.Show("Campo só aceita número inteiros.");
            
        }
    }
}
