using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.UserViewsDTO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string estadoCivil { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;

    }
}
