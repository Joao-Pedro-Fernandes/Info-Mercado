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
            lstVendas.LabelEdit = true;
            lstVendas.AllowColumnReorder = true;
            lstVendas.FullRowSelect = true;
            lstVendas.GridLines = true;

            lstVendas.Columns.Add("Id", 50, HorizontalAlignment.Left);
            lstVendas.Columns.Add("Cliente", 100, HorizontalAlignment.Left);
            lstVendas.Columns.Add("Produtos", 260, HorizontalAlignment.Left);
            lstVendas.Columns.Add("Valor", 100, HorizontalAlignment.Left); 
        }
    }
}
