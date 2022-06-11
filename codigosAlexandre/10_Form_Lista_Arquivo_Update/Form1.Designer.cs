namespace _10_Form_Lista_Arquivo_Update
{
    partial class Form_TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_nomePessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_remover = new System.Windows.Forms.Button();
            this.textBox_listaPessoas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_nomePessoa
            // 
            this.textBox_nomePessoa.Location = new System.Drawing.Point(116, 6);
            this.textBox_nomePessoa.Name = "textBox_nomePessoa";
            this.textBox_nomePessoa.Size = new System.Drawing.Size(275, 23);
            this.textBox_nomePessoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome de pessoa:";
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(116, 57);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 2;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_remover
            // 
            this.button_remover.Location = new System.Drawing.Point(212, 57);
            this.button_remover.Name = "button_remover";
            this.button_remover.Size = new System.Drawing.Size(75, 23);
            this.button_remover.TabIndex = 3;
            this.button_remover.Text = "Remover";
            this.button_remover.UseVisualStyleBackColor = true;
            this.button_remover.Click += new System.EventHandler(this.button_remover_Click);
            // 
            // textBox_listaPessoas
            // 
            this.textBox_listaPessoas.Enabled = false;
            this.textBox_listaPessoas.Location = new System.Drawing.Point(12, 107);
            this.textBox_listaPessoas.Multiline = true;
            this.textBox_listaPessoas.Name = "textBox_listaPessoas";
            this.textBox_listaPessoas.Size = new System.Drawing.Size(379, 188);
            this.textBox_listaPessoas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de Pessoas Cadastradas";
            // 
            // Form_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_listaPessoas);
            this.Controls.Add(this.button_remover);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nomePessoa);
            this.Name = "Form_TelaPrincipal";
            this.Text = "Formulário Cadastro e Remoção de Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_nomePessoa;
        private Label label1;
        private Button button_cadastrar;
        private Button button_remover;
        private TextBox textBox_listaPessoas;
        private Label label2;
    }
}