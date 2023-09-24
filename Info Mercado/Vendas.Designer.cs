namespace Info_Mercado
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstVendas = new System.Windows.Forms.ListView();
            this.btnCadastrarVenda = new System.Windows.Forms.Button();
            this.btnMostrarVendas = new System.Windows.Forms.Button();
            this.txtPesquisaVenda = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVendas
            // 
            this.lstVendas.HideSelection = false;
            this.lstVendas.Location = new System.Drawing.Point(12, 64);
            this.lstVendas.Name = "lstVendas";
            this.lstVendas.Size = new System.Drawing.Size(608, 515);
            this.lstVendas.TabIndex = 2;
            this.lstVendas.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrarVenda
            // 
            this.btnCadastrarVenda.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCadastrarVenda.Location = new System.Drawing.Point(632, 72);
            this.btnCadastrarVenda.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastrarVenda.Name = "btnCadastrarVenda";
            this.btnCadastrarVenda.Size = new System.Drawing.Size(206, 54);
            this.btnCadastrarVenda.TabIndex = 5;
            this.btnCadastrarVenda.Text = "Cadastrar Venda";
            this.btnCadastrarVenda.UseVisualStyleBackColor = false;
            this.btnCadastrarVenda.Click += new System.EventHandler(this.btnCadastrarVenda_Click);
            // 
            // btnMostrarVendas
            // 
            this.btnMostrarVendas.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMostrarVendas.Location = new System.Drawing.Point(632, 138);
            this.btnMostrarVendas.Margin = new System.Windows.Forms.Padding(6);
            this.btnMostrarVendas.Name = "btnMostrarVendas";
            this.btnMostrarVendas.Size = new System.Drawing.Size(206, 54);
            this.btnMostrarVendas.TabIndex = 6;
            this.btnMostrarVendas.Text = "Mostrar Vendas";
            this.btnMostrarVendas.UseVisualStyleBackColor = false;
            this.btnMostrarVendas.Click += new System.EventHandler(this.btnMostrarVendas_Click);
            // 
            // txtPesquisaVenda
            // 
            this.txtPesquisaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaVenda.Location = new System.Drawing.Point(12, 15);
            this.txtPesquisaVenda.Name = "txtPesquisaVenda";
            this.txtPesquisaVenda.Size = new System.Drawing.Size(608, 38);
            this.txtPesquisaVenda.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPesquisar.Location = new System.Drawing.Point(632, 11);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(206, 51);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar Cliente";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(844, 591);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisaVenda);
            this.Controls.Add(this.btnMostrarVendas);
            this.Controls.Add(this.btnCadastrarVenda);
            this.Controls.Add(this.lstVendas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstVendas;
        private System.Windows.Forms.Button btnCadastrarVenda;
        private System.Windows.Forms.Button btnMostrarVendas;
        private System.Windows.Forms.TextBox txtPesquisaVenda;
        private System.Windows.Forms.Button btnPesquisar;
    }
}