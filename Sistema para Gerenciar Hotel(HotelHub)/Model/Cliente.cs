using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string email {  get; set; } = string.Empty;
        public DateTime dataNascimento { get; set; } = DateTime.MinValue;

    }
}
