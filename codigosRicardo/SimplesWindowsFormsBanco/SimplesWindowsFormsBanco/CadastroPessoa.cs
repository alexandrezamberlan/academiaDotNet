using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplesWindowsFormsBanco
{
    public partial class CadastroPessoa : Form
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*string nome tbnome
             * int idade = tbidade
             * string cpf = tbcpf
             * string end = tbend
             * string bairro tbbairro
             * string cep tbcep
             * string cidade tbcidade
             * */
            Pessoa p = new Pessoa(tbNome.Text,int.Parse(tbidade.Text), tbcpf.Text, tbend.Text, tbbairro.Text, tbCEP.Text, tbCidade.Text);
            MessageBox.Show("Nome do individuo: " + p.nome + " CPF: " + p.cpf);
            tbNome.Text = "";
            tbidade.Text = "";
            tbcpf.Text = "";
            tbend.Text = "";
            tbbairro.Text = "";
            tbCEP.Text = "";
            tbCidade.Text = "";
            p.gravarPessoa();
        }
    }
}
