using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SimplesWindowsFormsBanco
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string cpf;
        public string end;
        public string bairro;
        public string cep;
        public string cidade;
        public Pessoa(string nome, int idade, string cpf, string end, string bairro, string cep, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.end = end;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;

        }

        public bool gravarPessoa()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
  
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into pessoa values (@nome, @idade, @cpf, @ende, @bairro, @cep, @cidade);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@idade", SqlDbType.Int);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@ende", SqlDbType.VarChar);
            command.Parameters.Add("@bairro", SqlDbType.VarChar);
            command.Parameters.Add("@cep", SqlDbType.VarChar);
            command.Parameters.Add("@cidade", SqlDbType.VarChar);
            command.Parameters[0].Value = this.nome;
            command.Parameters[1].Value = this.idade;
            command.Parameters[2].Value = this.cpf;
            command.Parameters[3].Value = this.end;
            command.Parameters[4].Value = this.bairro;
            command.Parameters[5].Value = this.cep;
            command.Parameters[6].Value = this.cidade;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }

            finally
            {
                banco.fecharConexao();
            }


        }
           
    }
}
