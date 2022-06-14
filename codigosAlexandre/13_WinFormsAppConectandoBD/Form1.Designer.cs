namespace _13_WinFormsAppConectandoBD
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
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button_conectarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(12, 12);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(589, 182);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idGlicemia";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicêmico";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 100;
            // 
            // button_conectarBD
            // 
            this.button_conectarBD.Location = new System.Drawing.Point(12, 200);
            this.button_conectarBD.Name = "button_conectarBD";
            this.button_conectarBD.Size = new System.Drawing.Size(75, 23);
            this.button_conectarBD.TabIndex = 1;
            this.button_conectarBD.Text = "Conectar";
            this.button_conectarBD.UseVisualStyleBackColor = true;
            this.button_conectarBD.Click += new System.EventHandler(this.button_conectarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 383);
            this.Controls.Add(this.button_conectarBD);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestão de medidas glicêmicas";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_medidasGlicemias;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button_conectarBD;
    }
}