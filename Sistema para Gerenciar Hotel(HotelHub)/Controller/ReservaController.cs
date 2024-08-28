using System;
using System.Collections.Generic;
using System.Linq;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Classesforview;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Controller
{
    public class ReservaController
    {
        private List<Reserva> listRes = new List<Reserva>();

        public ReservaController() { }

        // Adiciona uma nova reserva à lista
        public void AdicionarReserva(Reserva reserva)
        {
            if (reserva == null)
            {
                throw new ArgumentNullException(nameof(reserva), "Reserva não pode ser nula.");
            }

            // Gerar um ID único
            reserva.Id = listRes.Count > 0 ? listRes.Max(r => r.Id) + 1 : 1;
            listRes.Add(reserva);
        }

        // Atualiza uma reserva existente
        public void AtualizarReserva(Reserva reserva)
        {
            if (reserva == null)
            {
                throw new ArgumentNullException(nameof(reserva), "Reserva não pode ser nula.");
            }

            var reservaExistente = listRes.FirstOrDefault(r => r.Id == reserva.Id);
            if (reservaExistente == null)
            {
                throw new KeyNotFoundException("Reserva não encontrada.");
            }

            reservaExistente.cliente = reserva.cliente;
            reservaExistente.dataInicio = reserva.dataInicio;
            reservaExistente.dataFim = reserva.dataFim;
            reservaExistente.valorReserva = reserva.valorReserva;
            reservaExistente.numHospedes = reserva.numHospedes;
            reservaExistente.numQuartos = reserva.numQuartos;
        }

        // Remove uma reserva pelo ID
        public void RemoverReserva(int id)
        {
            var reserva = listRes.FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                throw new KeyNotFoundException("Reserva não encontrada.");
            }

            listRes.Remove(reserva);
        }

        // Lista todas as reservas
        public List<Reserva> ListarReservas()
        {
            return listRes.ToList();
        }

        // Busca uma reserva pelo ID
        public Reserva BuscarReservaPorId(int id)
        {
            var reserva = listRes.FirstOrDefault(r => r.Id == id);
            if (reserva == null)
            {
                throw new KeyNotFoundException("Reserva não encontrada.");
            }

            return reserva;
        }
    }
}
