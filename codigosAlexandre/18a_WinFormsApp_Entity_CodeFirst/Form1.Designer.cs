namespace _18a_WinFormsApp_Entity_CodeFirst
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
            this.listView_pacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.panel_campos = new System.Windows.Forms.Panel();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nomePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_pacientes
            // 
            this.listView_pacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_pacientes.Location = new System.Drawing.Point(12, 12);
            this.listView_pacientes.Name = "listView_pacientes";
            this.listView_pacientes.Size = new System.Drawing.Size(459, 133);
            this.listView_pacientes.TabIndex = 0;
            this.listView_pacientes.UseCompatibleStateImageBehavior = false;
            this.listView_pacientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IdPaciente";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome Paciente";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 150;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(12, 151);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 1;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.Location = new System.Drawing.Point(93, 151);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 2;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(174, 151);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(75, 23);
            this.button_editar.TabIndex = 3;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Location = new System.Drawing.Point(255, 151);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 4;
            this.button_pesquisar.Text = "Pesquisar";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // panel_campos
            // 
            this.panel_campos.Controls.Add(this.button_salvar);
            this.panel_campos.Controls.Add(this.textBox_email);
            this.panel_campos.Controls.Add(this.label2);
            this.panel_campos.Controls.Add(this.textBox_nomePaciente);
            this.panel_campos.Controls.Add(this.label1);
            this.panel_campos.Enabled = false;
            this.panel_campos.Location = new System.Drawing.Point(12, 198);
            this.panel_campos.Name = "panel_campos";
            this.panel_campos.Size = new System.Drawing.Size(459, 100);
            this.panel_campos.TabIndex = 5;
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(106, 70);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 4;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(106, 41);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(350, 23);
            this.textBox_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // textBox_nomePaciente
            // 
            this.textBox_nomePaciente.Location = new System.Drawing.Point(106, 11);
            this.textBox_nomePaciente.Name = "textBox_nomePaciente";
            this.textBox_nomePaciente.Size = new System.Drawing.Size(350, 23);
            this.textBox_nomePaciente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Paciente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 310);
            this.Controls.Add(this.panel_campos);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.listView_pacientes);
            this.Name = "Form1";
            this.Text = "Gestão de Pacientes";
            this.panel_campos.ResumeLayout(false);
            this.panel_campos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button_cadastrar;
        private Button button_deletar;
        private Button button_editar;
        private Button button_pesquisar;
        private Panel panel_campos;
        private TextBox textBox_nomePaciente;
        private Label label1;
        private TextBox textBox_email;
        private Label label2;
        private Button button_salvar;
        private ListView listView_pacientes;
    }
}