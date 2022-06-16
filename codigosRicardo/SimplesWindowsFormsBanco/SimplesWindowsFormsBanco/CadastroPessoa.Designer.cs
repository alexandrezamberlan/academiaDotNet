namespace SimplesWindowsFormsBanco
{
    partial class CadastroPessoa
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbidade = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.tbend = new System.Windows.Forms.TextBox();
            this.tbbairro = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(93, 35);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(159, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbidade
            // 
            this.tbidade.Location = new System.Drawing.Point(93, 70);
            this.tbidade.Name = "tbidade";
            this.tbidade.Size = new System.Drawing.Size(159, 20);
            this.tbidade.TabIndex = 1;
            // 
            // tbcpf
            // 
            this.tbcpf.Location = new System.Drawing.Point(93, 106);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(159, 20);
            this.tbcpf.TabIndex = 2;
            // 
            // tbend
            // 
            this.tbend.Location = new System.Drawing.Point(93, 141);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(159, 20);
            this.tbend.TabIndex = 3;
            // 
            // tbbairro
            // 
            this.tbbairro.Location = new System.Drawing.Point(93, 178);
            this.tbbairro.Name = "tbbairro";
            this.tbbairro.Size = new System.Drawing.Size(159, 20);
            this.tbbairro.TabIndex = 4;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(93, 216);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(159, 20);
            this.tbCEP.TabIndex = 5;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(93, 252);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(159, 20);
            this.tbCidade.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(23, 73);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(34, 13);
            this.lblidade.TabIndex = 8;
            this.lblidade.Text = "Idade";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(23, 113);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(27, 13);
            this.lblcpf.TabIndex = 9;
            this.lblcpf.Text = "CPF";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(23, 148);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(53, 13);
            this.lblend.TabIndex = 10;
            this.lblend.Text = "Endereço";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(23, 185);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(34, 13);
            this.lblbairro.TabIndex = 11;
            this.lblbairro.Text = "Bairro";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(23, 219);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 12;
            this.lblCEP.Text = "CEP";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(23, 255);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 13;
            this.lblCidade.Text = "Cidade";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(177, 293);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 328);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbbairro);
            this.Controls.Add(this.tbend);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.tbidade);
            this.Controls.Add(this.tbNome);
            this.Name = "CadastroPessoa";
            this.Text = "Cadastro de pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbidade;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.TextBox tbend;
        private System.Windows.Forms.TextBox tbbairro;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnSalvar;
    }
}

