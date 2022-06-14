using System.Configuration;
using Microsoft.Data.SqlClient;

namespace _13_WinFormsAppConectandoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //string sqlTexto = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida, [Paciente].nome FROM MedidaGlicemia, Paciente WHERE[MedidaGlicemia].idPaciente = [Paciente].idPaciente";
                string sqlTexto = "SELECT idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente FROM MedidaGlicemia";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);

                listView_medidasGlicemias.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    listView_medidasGlicemias.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                    //listView_medidasGlicemias.Items[i].SubItems.Add(leitor["nome"].ToString());
                    listView_medidasGlicemias.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }
                conexao.Close();
                button_conectarBD.Enabled = false;
                MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception e)
            {
                MessageBox.Show("Problemas de conexão com o Banco de Dados " + e.ToString(), "Alerta");
            }

        }

        private void button_conectarBD_Click(object sender, EventArgs e)
        {
            carregarListView();   
        }
    }
}