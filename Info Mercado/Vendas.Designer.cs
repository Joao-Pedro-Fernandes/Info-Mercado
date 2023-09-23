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
            this.label1 = new System.Windows.Forms.Label();
            this.lstVendas = new System.Windows.Forms.ListView();
            this.btnCadastrarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabela de Vendas";
            // 
            // lstVendas
            // 
            this.lstVendas.HideSelection = false;
            this.lstVendas.Location = new System.Drawing.Point(12, 46);
            this.lstVendas.Name = "lstVendas";
            this.lstVendas.Size = new System.Drawing.Size(608, 533);
            this.lstVendas.TabIndex = 2;
            this.lstVendas.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrarVenda
            // 
            this.btnCadastrarVenda.Location = new System.Drawing.Point(632, 46);
            this.btnCadastrarVenda.Margin = new System.Windows.Forms.Padding(6);
            this.btnCadastrarVenda.Name = "btnCadastrarVenda";
            this.btnCadastrarVenda.Size = new System.Drawing.Size(206, 54);
            this.btnCadastrarVenda.TabIndex = 5;
            this.btnCadastrarVenda.Text = "Cadastrar Venda";
            this.btnCadastrarVenda.UseVisualStyleBackColor = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 591);
            this.Controls.Add(this.btnCadastrarVenda);
            this.Controls.Add(this.lstVendas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstVendas;
        private System.Windows.Forms.Button btnCadastrarVenda;
    }
}