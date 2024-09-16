using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DAO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Controller
{
    public class ReservaController
    {
        public ReservaController() { }

        internal bool AdicionarReserva(ClienteDTO cliente, DateTime dataInicio, DateTime dataFim, double valorReserva, int numHospedes, int numQuartos)
        {
            ReservaDTO reservaDTO = new ReservaDTO(cliente, dataInicio, dataFim, valorReserva, numHospedes);
            ReservaDAO reservaDAO = new ReservaDAO();
            if (!reservaDAO.AdicionarReservaBd(reservaDTO))
            {
                return false;
            }

            return true;
        }

        public bool AtualizarReserva(int id, ClienteDTO cliente, DateTime dataInicio, DateTime dataFim, double valorReserva, int numHospedes, int numQuartos)
        {
            ReservaDTO reservaDTO = new ReservaDTO(id, cliente, dataInicio, dataFim, valorReserva, numHospedes);
            ReservaDAO reservaDAO = new ReservaDAO();
            if (!reservaDAO.AlterarReservaBd(reservaDTO))
            {
                return false;
            }

            return true;
        }

        public bool RemoverReserva(int id)
        {
            ReservaDAO reservaDAO = new ReservaDAO();
            if (!reservaDAO.DeletarReserva(id))
            {
                return false;
            }
            return true;
        }

        internal Reserva BuscarReservaPorId(int id)
        {
            ReservaDAO reservaDAO = new ReservaDAO();
            ReservaDTO dto = reservaDAO.BuscarReserva(id);
            if (dto == null)
            {
                throw new KeyNotFoundException("Reserva não encontrada.");
            }


            Reserva reserva = new Reserva();
            reserva.Id = dto.Id;
            reserva.cliente = new ClienteController().toCliente(dto.Cliente);
            reserva.dataInicio = dto.DataInicio;
            reserva.dataFim = dto.DataFim;
            reserva.valorReserva = dto.Valor;
            reserva.numHospedes = dto.NumHospedes;
            reserva.numQuartos = dto.NumQuartos;

            return reserva;
        }

        public List<Reserva> ListarReservas()
        {
            ReservaDAO reservaDAO = new ReservaDAO();
            List<ReservaDTO> reservasDTO = reservaDAO.ListarReservas();
            List<Reserva> reservaList = new List<Reserva>();

            MessageBox.Show("teste: ");
            foreach (var dto in reservasDTO)
            {
                Reserva reserva = new Reserva();
                reserva.Id = dto.Id;
                reserva.cliente = new ClienteController().toCliente(dto.Cliente);
                reserva.dataInicio = dto.DataInicio;
                reserva.dataFim = dto.DataFim;
                reserva.valorReserva = dto.Valor;
                reserva.numHospedes = dto.NumHospedes;
                reserva.numQuartos = dto.NumQuartos;

                reservaList.Add(reserva);

            }

            return reservaList;
        }
    }
}
