using MySqlConnector;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DAO
{
    internal class ReservaDAO
    {
        private MySqlConnection conBd;
        private string? comandosql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public ReservaDAO()
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

        public bool AdicionarReservaBd(Reserva instance)
        {
            try
            {
                conBd.Open();
                comandosql = "INSERT INTO reserva (idCliente, dataInicio, dataFim, valorReserva, numHospedes, numQuartos)" +
                         " VALUES (@idCliente, @dataInicio, @dataFim, @valorReserva, @numHospedes, @numQuartos)";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                // parâmetros
                envelope.Parameters.AddWithValue("@idCliente", instance.cliente.Id);
                envelope.Parameters.AddWithValue("@dataInicio", instance.dataInicio);
                envelope.Parameters.AddWithValue("@dataFim", instance.dataFim);
                envelope.Parameters.AddWithValue("@valorReserva", instance.valorReserva);
                envelope.Parameters.AddWithValue("@numHospedes", instance.numHospedes);
                envelope.Parameters.AddWithValue("@numQuartos", instance.numQuartos);

                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar reserva" + ex.Message);
                return false;
            }
        }

        public bool AlterarReservaBd(Reserva instance)
        {
            try
            {
                conBd.Open();
                comandosql = "UPDATE reserva SET idCliente = @idCliente, dataInicio = @dataInicio, dataFim = @dataFim, " +
                             "valorReserva = @valorReserva, numHospedes = @numHospedes, numQuartos = @numQuartos WHERE idReserva = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                // parâmetros
                envelope.Parameters.AddWithValue("@idCliente", instance.cliente.Id);
                envelope.Parameters.AddWithValue("@dataInicio", instance.dataInicio);
                envelope.Parameters.AddWithValue("@dataFim", instance.dataFim);
                envelope.Parameters.AddWithValue("@valorReserva", instance.valorReserva);
                envelope.Parameters.AddWithValue("@numHospedes", instance.numHospedes);
                envelope.Parameters.AddWithValue("@numQuartos", instance.numQuartos);
                envelope.Parameters.AddWithValue("@Id", instance.Id);

                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar reserva" + ex.Message);
                return false;
            }
        }

        public List<ReservaDTO> ListarReservas()
        {
            List<ReservaDTO> lista = new List<ReservaDTO>();
            try
            {
                conBd.Open();
                comandosql = "SELECT * FROM reserva";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                cursor = envelope.ExecuteReader();

                while (cursor.Read())
                {
                   
                    ReservaDTO reserva = new ReservaDTO
                    (
                          cursor.GetInt32("idReserva"),
                           new ClienteDAO().buscarCliente(cursor.GetInt32("idCliente")),
                           cursor.GetDateTime("CheckIn"),
                           cursor.GetDateTime("CheckOut"),
                            cursor.GetDouble("valor"),
                           cursor.GetInt32("numHospede")
                       
                    );

                    lista.Add(reserva);
                }
                conBd.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar reservas: " + ex.Message);
                return null;
            }
        }

        public bool DeletarReserva(int id)
        {
            try
            {
                conBd.Open();
                comandosql = "DELETE FROM reserva WHERE idReserva = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                envelope.Parameters.AddWithValue("@Id", id);
                envelope.Prepare();
                bool status = envelope.ExecuteNonQuery() > 0 ? true : false;
                conBd.Close();
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar reserva: " + ex.Message);
                return false;
            }
        }

        public ReservaDTO BuscarReserva(int id)
        {
            try
            {
                conBd.Open();
                comandosql = "SELECT idReserva, idCliente, dataInicio, dataFim, valorReserva, numHospedes, numQuartos " +
                             "FROM reserva WHERE idReserva = @Id";
                envelope = new MySqlCommand(comandosql);
                envelope.Connection = conBd;
                envelope.Parameters.AddWithValue("@Id", id);
                cursor = envelope.ExecuteReader();
                if (cursor.Read())
                {

                    ReservaDTO reserva = new ReservaDTO
                    (
                        cursor.GetInt32("idReserva"),
                        new ClienteDAO().buscarCliente(cursor.GetInt32("idCliente")),
                        cursor.GetDateTime("CheckIn"),
                        cursor.GetDateTime("CheckOut"),
                        cursor.GetDouble("valor"),
                        cursor.GetInt32("numHospede")
                    );
                    return reserva;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar reserva: " + ex.Message);
                return null;
            }
        }
    }
}
