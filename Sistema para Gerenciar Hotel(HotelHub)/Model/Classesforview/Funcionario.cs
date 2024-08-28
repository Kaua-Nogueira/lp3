using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_para_Gerenciar_Hotel_HotelHub_.Model.Classesforview
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
        public string estadoCivil { get; set; }
        public DateTime dataNasc { get; set; }

    }
}
