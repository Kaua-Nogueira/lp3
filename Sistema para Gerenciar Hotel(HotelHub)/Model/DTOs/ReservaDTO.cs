using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;
using System;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO
{
    internal class ReservaDTO
    {
        public int Id { get; set; }
        public ClienteDTO Cliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double Valor { get; set; }
        public int NumHospedes { get; set; }
        public int NumQuartos { get; set; }

        // Construtor para criar uma reserva sem ID (para novas reservas)
        public ReservaDTO(ClienteDTO cliente, DateTime inicio, DateTime fim, double valor,
                          int numHospede)
        {
            Cliente = cliente;
            DataInicio = inicio;
            DataFim = fim;
            Valor = valor;
            NumHospedes = numHospede;
        }

        // Construtor para criar uma reserva com ID (para reservas existentes)
        public ReservaDTO(int id, ClienteDTO cliente, DateTime CheckIn, DateTime CheckOut, double valor,
                          int numHospede)
        {
            Id = id;
            Cliente = cliente;
            DataInicio = CheckIn;
            DataFim = CheckOut;
            Valor = valor;
            NumHospedes = numHospede;
        }
    }
}
