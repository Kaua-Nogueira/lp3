using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.DTO
{
    internal class ReservaDTO
    {
        private int id;
        private Cliente cliente;
        private DateTime datainicio;
        private DateTime datafim;
        private double valor_reserva;
        private int num_hospedes;
        private int num_Quartos;

        public ReservaDTO(Cliente cliente, DateTime inicio, DateTime fim, double valor,
                          int numhospede, int numquartos) 
        {
            this.cliente = cliente;
            this.datainicio = inicio;
            this.datafim = fim;
            this.valor_reserva = valor;
            this.num_hospedes = numhospede;
            this.num_Quartos = numquartos;
        
        }
        public ReservaDTO(int id, Cliente cliente, DateTime inicio, DateTime fim, double valor,
                          int numhospede, int numquartos)
        {
            this.id = id;
            this.cliente = cliente;
            this.datainicio = inicio;
            this.datafim = fim;
            this.valor_reserva = valor;
            this.num_hospedes = numhospede;
            this.num_Quartos = numquartos;

        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime dataInicio { get; set; } = DateTime.MinValue;
        public DateTime dataFim { get; set; } = DateTime.MinValue;
        public double valorReserva { get; set; } = double.MinValue;
        public int numHospedes { get; set; } = 0;
        public int numQuartos { get; set; } = 0;
    }
}
