using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADO.net
using System.Data.SqlClient; // ADO para SQL SERVER

namespace Data
{
    public class TecnicoDAO
    {
        private string _conexao;

        // Metodo Construtor => Inicializa Objeto buscando Conexao
        public TecnicoDAO(string conexao)
        {
            // RECEBA Conexão 
            _conexao = conexao;
        }

        // Inserir Cliente Vulgo XUXAR
        public void IncluiTecnico(Tecnico tecnico)
        {
            using (SqlConnection conexaoBd = new SqlConnection(_conexao))
            {
                string sql = "insert into Tecnicos (Nome,Especialidade,Email,Senha,Obs) values (@nome,@especialidade,@email,@senha,@obs)";

                using (SqlCommand comando = new SqlCommand(sql, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@email", tecnico.Email);
                    comando.Parameters.AddWithValue("@senha", tecnico.Senha);
                    comando.Parameters.AddWithValue("@obs", tecnico.Obs);

                    try
                    {
                        conexaoBd.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao Incluir Tecnico:" + ex.Message);
                    }
                }

            }
        }

    }
}
