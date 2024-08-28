using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO
{
    public class Reserva
    {
        public int Id { get; set; }
        public Cliente cliente { get; set; }
        public DateTime dataInicio { get; set; } = DateTime.MinValue;
        public DateTime dataFim { get; set; } = DateTime.MinValue;
        public double valorReserva { get; set; } = double.MinValue;
        public int numHospedes { get; set; } = 0;
        public int numQuartos { get; set; } = 0;

    }
}
