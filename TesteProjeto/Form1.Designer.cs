namespace TesteProjeto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPopulacao = new System.Windows.Forms.TextBox();
            this.txtTerritorio = new System.Windows.Forms.TextBox();
            this.txtExpectativaVida = new System.Windows.Forms.TextBox();
            this.txtPIB = new System.Windows.Forms.TextBox();
            this.txtIDH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(167, 328);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 71);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(178, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(178, 136);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(100, 20);
            this.txtPopulacao.TabIndex = 2;
            // 
            // txtTerritorio
            // 
            this.txtTerritorio.Location = new System.Drawing.Point(178, 177);
            this.txtTerritorio.Name = "txtTerritorio";
            this.txtTerritorio.Size = new System.Drawing.Size(100, 20);
            this.txtTerritorio.TabIndex = 3;
            // 
            // txtExpectativaVida
            // 
            this.txtExpectativaVida.Location = new System.Drawing.Point(178, 216);
            this.txtExpectativaVida.Name = "txtExpectativaVida";
            this.txtExpectativaVida.Size = new System.Drawing.Size(100, 20);
            this.txtExpectativaVida.TabIndex = 4;
            // 
            // txtPIB
            // 
            this.txtPIB.Location = new System.Drawing.Point(178, 253);
            this.txtPIB.Name = "txtPIB";
            this.txtPIB.Size = new System.Drawing.Size(100, 20);
            this.txtPIB.TabIndex = 5;
            // 
            // txtIDH
            // 
            this.txtIDH.Location = new System.Drawing.Point(178, 291);
            this.txtIDH.Name = "txtIDH";
            this.txtIDH.Size = new System.Drawing.Size(100, 20);
            this.txtIDH.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "População";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Territorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expectativa de vida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PIB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IDH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDH);
            this.Controls.Add(this.txtPIB);
            this.Controls.Add(this.txtExpectativaVida);
            this.Controls.Add(this.txtTerritorio);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPopulacao;
        private System.Windows.Forms.TextBox txtTerritorio;
        private System.Windows.Forms.TextBox txtExpectativaVida;
        private System.Windows.Forms.TextBox txtPIB;
        private System.Windows.Forms.TextBox txtIDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

