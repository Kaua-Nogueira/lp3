using MySqlConnector;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DAO
{
    internal class ClienteDAO
    {
        private MySqlConnection conBd;
        private string? comandosql;//A interrogação indica que este atributo pode receber valores null
        private MySqlCommand? envelope;//Precisamos explicitar que isso pode acontecer
        private MySqlDataReader? cursor;

        public ClienteDAO() 
        {
            try
            {
                ConexaoBD conBd = new ConexaoBD();
                this.conBd = conBd.RetornaConexao();

            }
            catch(Exception ex){
                MessageBox.Show("Algum problema na conexão com o Banco de dados" + ex.Message);
            }
            
        }

        public bool AdicionarClienteBd(ClienteDTO instance)
        {
            try
            {
                conBd.Open();
                comandosql = "INSERT INTO cliente (nome,sobrenome,cpf,telefone,email,data_Nasc,estado_civil)" +
                         " VALUES (@nome,@sobrenome,@cpf,@telefone,@email,@data_Nasc,@estado_civil)";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                //parametros
                envelope.Parameters.AddWithValue("@nome", instance.Nome);
                envelope.Parameters.AddWithValue("@sobrenome", instance.Sobrenome);
                envelope.Parameters.AddWithValue("@cpf", instance.Cpf);
                envelope.Parameters.AddWithValue("@telefone", instance.Telefone);
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
                MessageBox.Show("Erro ao cadastrar cliente" + ex);
                return false;
            }
        }

        public bool alterarClienteBd(ClienteDTO instance)
        {
            try
            {
                conBd.Open();
                comandosql = "UPDATE cliente SET nome = @nome, sobrenome =@sobrenome,cpf=@cpf,telefone=@telefone,email=@email" +
                             ",data_nasc=@data_nasc, estado_civil=@estado_civil WHERE idCliente = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                //parametros
                envelope.Parameters.AddWithValue("@nome", instance.Nome);
                envelope.Parameters.AddWithValue("@sobrenome", instance.Sobrenome);
                envelope.Parameters.AddWithValue("@cpf", instance.Cpf);
                envelope.Parameters.AddWithValue("@telefone", instance.Telefone);
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
                MessageBox.Show("Erro ao atualizar cliente" + ex);
                return false;
            }

        }

        public List<ClienteDTO> listarClientes()
        {
            List<ClienteDTO> lista = new List<ClienteDTO>();
            try
            {
                conBd.Open();
                comandosql = "SELECT * FROM cliente";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                cursor = envelope.ExecuteReader();
                while (cursor.Read()) 
                {


                    ClienteDTO clienteDTO = new ClienteDTO(
                        cursor.GetInt32("idCliente"),
                        cursor.GetString("nome"),
                        cursor.GetString("sobrenome"),
                        cursor.GetString("cpf"),
                        cursor.GetString("email"),
                        cursor.GetString("telefone"),
                        cursor.GetDateTime("data_nasc"),
                        cursor.GetString("estado_civil")
                        );

                    lista.Add(clienteDTO);

                }
                conBd.Close();
                return lista;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return null;
            }
        }

        public bool deletarCliente(int id)
        {
            try
            {
                conBd.Open();
                comandosql = "DELETE FROM cliente WHERE idCliente = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                //parametros
                envelope.Parameters.AddWithValue("@id", id);
                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente" + ex);
                return false;
            }
        }

        public ClienteDTO buscarCliente(int id)
        {
            try
            {
                conBd.Open();
                comandosql = "SELECT idCliente, nome, sobrenome,cpf,email,telefone,data_nasc,estado_civil " +
                             "FROM cliente WHERE idCliente = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                //parâmetro
                envelope.Parameters.AddWithValue("@Id", id);
                cursor = envelope.ExecuteReader();
                while (cursor.Read())
                {


                    ClienteDTO clienteDTO = new ClienteDTO(
                        cursor.GetInt32("idCliente"),
                        cursor.GetString("nome"),
                        cursor.GetString("sobrenome"),
                        cursor.GetString("cpf"),
                        cursor.GetString("email"),
                        cursor.GetString("telefone"),
                        cursor.GetDateTime("data_nasc"),
                        cursor.GetString("estado_civil")
                    );
                    return clienteDTO;
                }

                return null;


            }
            catch(Exception ex){
                MessageBox.Show("erro na pesquisa" + ex);
                return null;
            }
        }
    }
}
