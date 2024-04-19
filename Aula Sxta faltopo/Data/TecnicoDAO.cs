using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // ADO.net


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
        public DataSet BuscaTecnico(string Pesquisa = "")
        {
            //Constante com o codigo sql que faz busca a partir do texto
            const string query = "Select * From Tecnicos Where Nome Like @pesquisa";

            //validar erro
            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                using (var adaptador = new SqlDataAdapter(comando))
                {
                    string parametroPesquisa = $"%{Pesquisa}%";
                    comando.Parameters.AddWithValue("@pesquisa", parametroPesquisa);
                    conexaoBd.Open();
                    var dsTecnicos = new DataSet();
                    adaptador.Fill(dsTecnicos, "Tecnicos");
                    return dsTecnicos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar Tecnicos: {ex.Message}");
            }
        }
        public Tecnico ObtemTecnico(int codigoTecnico)
        {
            // Defini o sql para obter o cliente 
            const string query = @"select * from Tecnicos where CodigoTecnico =@CodigoTecnico";

            Tecnico tecnico = null;

            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaobd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaobd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                            {
                                CodigoTecnico = Convert.ToInt32(reader["CodigoTecnico"]),
                                Nome = reader["Nome"].ToString(),
                                Especialidade = reader["Especialidade"].ToString(),
                                Obs = reader["Obs"].ToString(),
                                Email = reader["Email"].ToString(),
                                Senha = reader["Senha"].ToString(),
                            };
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o tecnico{ex.Message}", ex);
            }
            return tecnico;
        }
        public void AlterarTecnico(Tecnico tecnico)
        {
            const string query = @"update Tecnicos set Nome=@Nome, Senha = @Senha, Especialidade = @Especialidade, Obs = @Obs, Email = @Email where CodigoTecnico = @CodigoTecnico";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@nome", tecnico.Nome);
                    comando.Parameters.AddWithValue("@especialidade", tecnico.Especialidade);
                    comando.Parameters.AddWithValue("@email", tecnico.Email);
                    comando.Parameters.AddWithValue("@senha", tecnico.Senha);
                    comando.Parameters.AddWithValue("@obs", tecnico.Obs);
                    comando.Parameters.AddWithValue("@CodigoTecnico", tecnico.CodigoTecnico);

                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro{ex}");
            }
        }
        public void ExcluirTecnico(int codigoTecnico)
        {
            const string query = @"delete from Tecnicos Where CodigoTecnico = @CodigoTecnico";

            try
            {
                using (var conexaoBd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaoBd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaoBd.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir{ex.Message}");
            }
        }
        public void ExcluirTdTecnico(int codigoTecnico)
        {
            //const string query = @"delete from Clientes Where CodigoTecnico = @CodigoTecnico";
            const string query = @" delete from Tecnicos
                                     declare @maxId int
                                        select @maxId = isnull(max(CodigoTecnico), 0) from Tecnicos
                                            dbcc checkident ('Tecnicos', reseed, @maxId)";
            Tecnico tecnico = null;
            try
            {
                using (var conexaobd = new SqlConnection(_conexao))
                using (var comando = new SqlCommand(query, conexaobd))
                {
                    comando.Parameters.AddWithValue("@CodigoTecnico", codigoTecnico);
                    conexaobd.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                            {
                                CodigoTecnico = Convert.ToInt32(reader["CodigoTecnico"]),
                                Nome = reader["Nome"].ToString(),
                                Especialidade = reader["Especialidade"].ToString(),
                                Obs = reader["Obs"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Email = reader["Email"].ToString(),
                            };
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao obter o Tecnico{ex.Message}", ex);
            }

        }
    }
}
