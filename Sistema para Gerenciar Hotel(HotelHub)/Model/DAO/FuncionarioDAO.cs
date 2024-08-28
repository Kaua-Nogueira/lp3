using MySqlConnector;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DAO
{
    internal class FuncionarioDAO
    {
        private MySqlConnection conBd;
        private string? comandosql; // A interrogação indica que este atributo pode receber valores null
        private MySqlCommand? envelope; // Precisamos explicitar que isso pode acontecer
        private MySqlDataReader? cursor;

        public FuncionarioDAO()
        {
            try
            {
                ConexaoBD conBd = new ConexaoBD();
                this.conBd = conBd.RetornaConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algum problema na conexão com o Banco de dados" + ex.Message);
            }
        }

        public bool AdicionarFuncionarioBd(FuncionarioDTO instance)
        {
            try
            {
                conBd.Open();
                comandosql = "INSERT INTO funcionario (nome,sobrenome,cpf,email,data_Nasc,estado_civil)" +
                         " VALUES (@nome,@sobrenome,@cpf,@email,@data_Nasc,@estado_civil)";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                // parâmetros
                envelope.Parameters.AddWithValue("@nome", instance.Nome);
                envelope.Parameters.AddWithValue("@sobrenome", instance.Sobrenome);
                envelope.Parameters.AddWithValue("@cpf", instance.Cpf);
                envelope.Parameters.AddWithValue("@email", instance.Email);
                envelope.Parameters.AddWithValue("@data_Nasc", instance.DataNascimento);
                envelope.Parameters.AddWithValue("@estado_civil", instance.EstadoCivil);

                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário" + ex);
                return false;
            }
        }

        public bool AlterarFuncionarioBd(FuncionarioDTO instance)
        {
            try
            {
                conBd.Open();
                comandosql = "UPDATE funcionario SET nome = @nome, sobrenome=@sobrenome, cpf=@cpf, email=@email" +
                             ", data_nasc=@data_Nasc, estado_civil=@estado_civil WHERE idFuncionario = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                // parâmetros
                envelope.Parameters.AddWithValue("@nome", instance.Nome);
                envelope.Parameters.AddWithValue("@sobrenome", instance.Sobrenome);
                envelope.Parameters.AddWithValue("@cpf", instance.Cpf);
                envelope.Parameters.AddWithValue("@email", instance.Email);
                envelope.Parameters.AddWithValue("@data_Nasc", instance.DataNascimento);
                envelope.Parameters.AddWithValue("@estado_civil", instance.EstadoCivil);
                envelope.Parameters.AddWithValue("@Id", instance.Id);

                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário" + ex);
                return false;
            }
        }

        public List<FuncionarioDTO> ListarFuncionarios()
        {
            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            try
            {
                conBd.Open();
                comandosql = "SELECT * FROM funcionario";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    FuncionarioDTO funcionarioDTO = new FuncionarioDTO(
                        cursor.GetInt32("idFuncionario"),
                        cursor.GetString("nome"),
                        cursor.GetString("sobrenome"),
                        cursor.GetString("cpf"),
                        cursor.GetString("email"),
                        cursor.GetDateTime("data_nasc"),
                        cursor.GetString("estado_civil")
                    );

                    lista.Add(funcionarioDTO);
                }
                conBd.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        public bool DeletarFuncionario(int id)
        {
            try
            {
                conBd.Open();
                comandosql = "DELETE FROM funcionario WHERE idFuncionario = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                // parâmetros
                envelope.Parameters.AddWithValue("@id", id);
                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar funcionário" + ex);
                return false;
            }
        }

        public FuncionarioDTO BuscarFuncionario(int id)
        {
            try
            {
                conBd.Open();
                comandosql = "SELECT idFuncionario, nome, sobrenome,cpf,email,data_nasc,estado_civil " +
                             "FROM funcionario WHERE idFuncionario = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                // parâmetro
                envelope.Parameters.AddWithValue("@Id", id);
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {
                    FuncionarioDTO funcionarioDTO = new FuncionarioDTO(
                        cursor.GetInt32("idFuncionario"),
                        cursor.GetString("nome"),
                        cursor.GetString("sobrenome"),
                        cursor.GetString("cpf"),
                        cursor.GetString("email"),
                        cursor.GetDateTime("data_nasc"),
                        cursor.GetString("estado_civil")
                    );
                    return funcionarioDTO;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa" + ex);
                return null;
            }
        }
    }

}
