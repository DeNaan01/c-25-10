namespace monique_e_rery
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXBidade = new System.Windows.Forms.TextBox();
            this.TXBaltura = new System.Windows.Forms.TextBox();
            this.TXBpeso = new System.Windows.Forms.TextBox();
            this.LBidade = new System.Windows.Forms.Label();
            this.LBaltura = new System.Windows.Forms.Label();
            this.LBpeso = new System.Windows.Forms.Label();
            this.BTNcalculo = new System.Windows.Forms.Button();
            this.BTNdirigir = new System.Windows.Forms.Button();
            this.LBresultado = new System.Windows.Forms.Label();
            this.TXBdivida = new System.Windows.Forms.TextBox();
            this.TXBqtd = new System.Windows.Forms.TextBox();
            this.BTNsimular = new System.Windows.Forms.Button();
            this.LBvalor = new System.Windows.Forms.Label();
            this.LBqtd = new System.Windows.Forms.Label();
            this.LBjuros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXBidade
            // 
            this.TXBidade.Location = new System.Drawing.Point(194, 86);
            this.TXBidade.Name = "TXBidade";
            this.TXBidade.Size = new System.Drawing.Size(62, 20);
            this.TXBidade.TabIndex = 0;
            this.TXBidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TXBaltura
            // 
            this.TXBaltura.Location = new System.Drawing.Point(279, 86);
            this.TXBaltura.Name = "TXBaltura";
            this.TXBaltura.Size = new System.Drawing.Size(69, 20);
            this.TXBaltura.TabIndex = 1;
            this.TXBaltura.TextChanged += new System.EventHandler(this.TXBaltura_TextChanged);
            // 
            // TXBpeso
            // 
            this.TXBpeso.Location = new System.Drawing.Point(374, 86);
            this.TXBpeso.Name = "TXBpeso";
            this.TXBpeso.Size = new System.Drawing.Size(70, 20);
            this.TXBpeso.TabIndex = 2;
            // 
            // LBidade
            // 
            this.LBidade.AutoSize = true;
            this.LBidade.Location = new System.Drawing.Point(190, 54);
            this.LBidade.Name = "LBidade";
            this.LBidade.Size = new System.Drawing.Size(34, 13);
            this.LBidade.TabIndex = 3;
            this.LBidade.Text = "Idade";
            // 
            // LBaltura
            // 
            this.LBaltura.AutoSize = true;
            this.LBaltura.Location = new System.Drawing.Point(276, 54);
            this.LBaltura.Name = "LBaltura";
            this.LBaltura.Size = new System.Drawing.Size(34, 13);
            this.LBaltura.TabIndex = 4;
            this.LBaltura.Text = "Altura";
            // 
            // LBpeso
            // 
            this.LBpeso.AutoSize = true;
            this.LBpeso.Location = new System.Drawing.Point(371, 54);
            this.LBpeso.Name = "LBpeso";
            this.LBpeso.Size = new System.Drawing.Size(31, 13);
            this.LBpeso.TabIndex = 5;
            this.LBpeso.Text = "Peso";
            // 
            // BTNcalculo
            // 
            this.BTNcalculo.Location = new System.Drawing.Point(194, 144);
            this.BTNcalculo.Name = "BTNcalculo";
            this.BTNcalculo.Size = new System.Drawing.Size(84, 36);
            this.BTNcalculo.TabIndex = 6;
            this.BTNcalculo.Text = "Calculo IMC";
            this.BTNcalculo.UseVisualStyleBackColor = true;
            this.BTNcalculo.Click += new System.EventHandler(this.BTNcalculo_Click);
            // 
            // BTNdirigir
            // 
            this.BTNdirigir.Location = new System.Drawing.Point(293, 144);
            this.BTNdirigir.Name = "BTNdirigir";
            this.BTNdirigir.Size = new System.Drawing.Size(96, 36);
            this.BTNdirigir.TabIndex = 7;
            this.BTNdirigir.Text = "Posso dirigir?";
            this.BTNdirigir.UseVisualStyleBackColor = true;
            this.BTNdirigir.Click += new System.EventHandler(this.BTNdirigir_Click);
            // 
            // LBresultado
            // 
            this.LBresultado.AutoSize = true;
            this.LBresultado.Location = new System.Drawing.Point(191, 109);
            this.LBresultado.Name = "LBresultado";
            this.LBresultado.Size = new System.Drawing.Size(13, 13);
            this.LBresultado.TabIndex = 8;
            this.LBresultado.Text = "_";
            // 
            // TXBdivida
            // 
            this.TXBdivida.Location = new System.Drawing.Point(193, 278);
            this.TXBdivida.Name = "TXBdivida";
            this.TXBdivida.Size = new System.Drawing.Size(85, 20);
            this.TXBdivida.TabIndex = 9;
            this.TXBdivida.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TXBqtd
            // 
            this.TXBqtd.Location = new System.Drawing.Point(293, 278);
            this.TXBqtd.Name = "TXBqtd";
            this.TXBqtd.Size = new System.Drawing.Size(96, 20);
            this.TXBqtd.TabIndex = 10;
            // 
            // BTNsimular
            // 
            this.BTNsimular.Location = new System.Drawing.Point(193, 323);
            this.BTNsimular.Name = "BTNsimular";
            this.BTNsimular.Size = new System.Drawing.Size(75, 37);
            this.BTNsimular.TabIndex = 11;
            this.BTNsimular.Text = "simular o parcelamento";
            this.BTNsimular.UseVisualStyleBackColor = true;
            this.BTNsimular.Click += new System.EventHandler(this.BTNsimular_Click);
            // 
            // LBvalor
            // 
            this.LBvalor.AutoSize = true;
            this.LBvalor.Location = new System.Drawing.Point(191, 252);
            this.LBvalor.Name = "LBvalor";
            this.LBvalor.Size = new System.Drawing.Size(79, 13);
            this.LBvalor.TabIndex = 13;
            this.LBvalor.Text = "Valor da Divida";
            // 
            // LBqtd
            // 
            this.LBqtd.AutoSize = true;
            this.LBqtd.Location = new System.Drawing.Point(290, 252);
            this.LBqtd.Name = "LBqtd";
            this.LBqtd.Size = new System.Drawing.Size(73, 13);
            this.LBqtd.TabIndex = 14;
            this.LBqtd.Text = "QTD parcelas";
            // 
            // LBjuros
            // 
            this.LBjuros.AutoSize = true;
            this.LBjuros.Location = new System.Drawing.Point(407, 278);
            this.LBjuros.Name = "LBjuros";
            this.LBjuros.Size = new System.Drawing.Size(107, 13);
            this.LBjuros.TabIndex = 15;
            this.LBjuros.Text = "% juros parcelamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.LBjuros);
            this.Controls.Add(this.LBqtd);
            this.Controls.Add(this.LBvalor);
            this.Controls.Add(this.BTNsimular);
            this.Controls.Add(this.TXBqtd);
            this.Controls.Add(this.TXBdivida);
            this.Controls.Add(this.LBresultado);
            this.Controls.Add(this.BTNdirigir);
            this.Controls.Add(this.BTNcalculo);
            this.Controls.Add(this.LBpeso);
            this.Controls.Add(this.LBaltura);
            this.Controls.Add(this.LBidade);
            this.Controls.Add(this.TXBpeso);
            this.Controls.Add(this.TXBaltura);
            this.Controls.Add(this.TXBidade);
            this.Name = "Form1";
            this.Text = "quantidade de parcelas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBidade;
        private System.Windows.Forms.TextBox TXBaltura;
        private System.Windows.Forms.TextBox TXBpeso;
        private System.Windows.Forms.Label LBidade;
        private System.Windows.Forms.Label LBaltura;
        private System.Windows.Forms.Label LBpeso;
        private System.Windows.Forms.Button BTNcalculo;
        private System.Windows.Forms.Button BTNdirigir;
        private System.Windows.Forms.Label LBresultado;
        private System.Windows.Forms.TextBox TXBdivida;
        private System.Windows.Forms.TextBox TXBqtd;
        private System.Windows.Forms.Button BTNsimular;
        private System.Windows.Forms.Label LBvalor;
        private System.Windows.Forms.Label LBqtd;
        private System.Windows.Forms.Label LBjuros;
    }
}

