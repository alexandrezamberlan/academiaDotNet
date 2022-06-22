namespace _14_GlicemiaCRUD
{
    partial class Form1
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
            this.button_conectar = new System.Windows.Forms.Button();
            this.button_desconectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(82, 64);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(83, 23);
            this.button_conectar.TabIndex = 0;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // button_desconectar
            // 
            this.button_desconectar.Enabled = false;
            this.button_desconectar.Location = new System.Drawing.Point(183, 64);
            this.button_desconectar.Name = "button_desconectar";
            this.button_desconectar.Size = new System.Drawing.Size(90, 23);
            this.button_desconectar.TabIndex = 1;
            this.button_desconectar.Text = "Desconectar";
            this.button_desconectar.UseVisualStyleBackColor = true;
            this.button_desconectar.Click += new System.EventHandler(this.button_desconectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do banco de dados";
            // 
            // textBox_nomeBanco
            // 
            this.textBox_nomeBanco.Location = new System.Drawing.Point(162, 12);
            this.textBox_nomeBanco.Name = "textBox_nomeBanco";
            this.textBox_nomeBanco.Size = new System.Drawing.Size(191, 23);
            this.textBox_nomeBanco.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 330);
            this.Controls.Add(this.textBox_nomeBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_desconectar);
            this.Controls.Add(this.button_conectar);
            this.Name = "Form1";
            this.Text = "Teste de conexao com Classe Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_conectar;
        private Button button_desconectar;
        private Label label1;
        private TextBox textBox_nomeBanco;
    }
}