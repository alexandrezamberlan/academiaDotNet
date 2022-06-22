using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace _14_GlicemiaCRUD
{
    /// <summary>
    /// classe genérica para conectar e realizar operações em uma base de dados
    /// </summary>
    public class Banco
    {
        //private string stringConexao = "Data Source=localhost; Initial Catalog=ATOSUFN; User ID=usuario; password='senha';language=Portuguese";
        //string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;


        /// <summary>
        /// armazena o nome do banco ou do catálogo para usar no sistema
        /// </summary>
        string nomeBanco = "";
        

        /// <summary>
        /// string de conexao com banco de dados 
        /// </summary>
        string conexaoString = "";

        /// <summary>
        /// objeto de conexao com o banco de dados
        /// </summary>
        private SqlConnection conexao;

        /// <summary>
        /// método para conectar ao banco, tendo como referência a conexaoString
        /// </summary>
        private void conectar()
        {
            conexao = new SqlConnection(conexaoString);
        }

        /// <summary>
        /// método que abre a conexão com o banco de dados
        /// </summary>
        /// <returns>retorna um objeto que representa a conexao</returns>
        public SqlConnection abrirConexao(string nomeBanco)
        {
            this.nomeBanco = nomeBanco;
            try
            {
                conexaoString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=" + this.nomeBanco + ";TrustServerCertificate=True;Integrated Security=True";
                conectar();
                conexao.Open();

                return conexao;
            }
            catch (Exception)
            {                
                return null;
            }
        }

        /// <summary>
        /// método que encerra a conexao com o banco de dados
        /// </summary>
        public void fecharConexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception)
            {
                return;
            }
        }     

        public SqlDataReader executarConsulta(string sql)
        {
            SqlCommand command = new SqlCommand(sql, conexao);

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }


        /// <summary>
        /// método que recebe uma string contendo comandos sql e os executa no banco conectado
        /// </summary>
        /// <param name="sql">string contendo comando sql</param>
        /// <returns>retorna uma tabela com as respostas do comando usados no parâmetro</returns>
        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao(this.nomeBanco);

                SqlCommand command = new SqlCommand(sql, conexao);
                command.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);//adapter preenche o datatable com os dados do command

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
